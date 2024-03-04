using CarteleriaCine.Business;
using CarteleriaCine.Expose.Request;
using CarteleriaCine.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarteleriaCine.Expose
{
	[Route("api/[controller]")]
	[ApiController]
	public class ReservaController : ControllerBase
	{
		private readonly  IReservaService _reservaService;

		public ReservaController(IReservaService reservaService)
		{
			_reservaService = reservaService;
		}

		[HttpPost]
		public async Task<IActionResult> Registrar([FromBody] RegistrarReservaRequest request)
		{
			var response = await _reservaService.Registrar(request);
			return Ok(response);
		}
	}
}
