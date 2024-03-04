using CarteleriaCine.Business;
using CarteleriaCine.Expose.Request;
using Microsoft.AspNetCore.Mvc;

namespace CarteleriaCine.Expose
{
	[Route("api/[controller]")]
	[ApiController]
	public class PeliculaController(IPeliculaService peliculaService) : ControllerBase
	{
		private readonly IPeliculaService _peliculaService = peliculaService;

		[HttpGet]
		public async Task<IActionResult> Listar([FromQuery] PeliculaRequest request)
		{
			var peliculas = await _peliculaService.ListarPeliculas(request);
			return Ok(peliculas);
		}


		[HttpGet]
		[Route("{idPelicula}")]
		public async Task<IActionResult> Detalle(int idPelicula)
		{
			var pelicula = await _peliculaService.DetallePelicula(idPelicula);
			if (pelicula == null)
			{
				return NotFound();
			}
			return Ok(pelicula);
		}

	}
}
