﻿using CarteleriaCine.Expose.Request;
using CarteleriaCine.Expose.Response;
using CarteleriaCine.Repository;
using Microsoft.EntityFrameworkCore;

namespace CarteleriaCine.Business.Impl
{
	public class PeliculaServicesImpl(CarteleriaContexto carteleriaContexto) : IPeliculaService
	{
		private readonly CarteleriaContexto _carteleriaContexto = carteleriaContexto;

		public async Task<List<PeliculaResponse>> ListarPeliculas(PeliculaRequest request)
		{
			return await _carteleriaContexto.Peliculas
				.Include(p => p.HorariosPelicula.Where(h => h.HoraInicio.Contains(request.HoraInicio)))
				.ThenInclude(h => h.Sala)
				.Include(p => p.Genero)
				.Where(p => (request.IdSala == 0 || (request.IdSala > 0 && p.HorariosPelicula.Any(x => x.Sala.Id == request.IdSala)))
						   && (request.Titulo == "" || (request.Titulo != "" && p.Titulo.Contains(request.Titulo)))
						   && (request.IdGenero == 0 || (request.IdGenero > 0 && p.Genero.Id == request.IdGenero))
						   && (request.HoraInicio == "" || (request.HoraInicio != "" && p.HorariosPelicula.Any(x => x.HoraInicio == request.HoraInicio))))
				.Select(p => new PeliculaResponse
				{
					Id = p.Id,
					Titulo = p.Titulo,
					Sinopsis = p.Sinopsis,
					Duracion = p.Duracion,
					UrlImagen = p.UrlImagen,
					Genero = p.Genero.Descripcion,
					Horarios = p.HorariosPelicula.Select(h => new HorariosResponse
					{
						HoraInicio = h.HoraInicio,
						HoraFin = h.HoraFin
					}).ToList()
				}).ToListAsync();
		}

		public async Task<DetallePeliculaResponse?> DetallePelicula(int idPelicula)
		{
			return await _carteleriaContexto.Peliculas
				.Include(p => p.HorariosPelicula)
				.ThenInclude(h => h.Sala)
				.Include(p => p.Genero)
				.Where(p => p.Id == idPelicula)
				.Select(p => new DetallePeliculaResponse
				{
					Id = p.Id,
					Titulo = p.Titulo,
					Sinopsis = p.Sinopsis,
					Duracion = p.Duracion,
					UrlImagen = p.UrlImagen,
					Genero = p.Genero.Descripcion,
					Salas = p.HorariosPelicula.Select(h => new SalaResponse
					{
						Numero = h.Sala.Numero,
						EntradasDisponibles = h.Sala.EntradasDisponibles,
						Horario = new HorariosResponse
						{
							HoraInicio = h.HoraInicio,
							HoraFin = h.HoraFin
						}
					}).ToList()
				}).FirstOrDefaultAsync();
		}
	}
}
