using CarteleriaCine.Expose.Request;
using CarteleriaCine.Expose.Response;
using CarteleriaCine.Model;
using CarteleriaCine.Repository;
using Microsoft.EntityFrameworkCore;

namespace CarteleriaCine.Business.Impl
{
	public class ReservaServiceImpl(CarteleriaContexto contexto) : IReservaService
	{
		private readonly CarteleriaContexto _contexto = contexto;

		public async Task<RegistrarReservaResponse> Registrar(RegistrarReservaRequest request)
		{
			var horario = await _contexto.HorariosPelicula
				.Include(x => x.Sala)
				.FirstOrDefaultAsync(x => x.Id == request.HorarioId) ?? throw new Exception("Horario no encontrado");

			var reserva = new ReservaPelicula
			{
				FechaCreacion = DateTime.Now,
				Cliente = new Cliente
				{
					ApellidoMaterno = request.ApellidoMaterno,
					ApellidoPaterno = request.ApellidoPaterno,
					Nombres = request.Nombres,
					TipoDocumento = await _contexto.TipoDocumentosIdentidad.FindAsync(request.TipoDocumentoIdentidadId),
					Genero = request.Genero,
					NumeroDocumento = request.NumeroDocumento,
					FechaNacimiento = DateOnly.FromDateTime(request.FechaNacimiento)
				},
				HorarioPelicula = horario
			};

			if (horario.Sala.EntradasDisponibles == 0) throw new Exception("No hay entradas disponibles");

			horario.Sala.EntradasDisponibles -= 1;
			_contexto.ReservasPelicula.Add(reserva);
			await _contexto.SaveChangesAsync();

			return new RegistrarReservaResponse
			{
				NroTicket = reserva.Id
			};
		}
	}
}
