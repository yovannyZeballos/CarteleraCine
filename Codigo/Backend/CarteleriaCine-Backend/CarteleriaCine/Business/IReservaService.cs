using CarteleriaCine.Expose.Request;
using CarteleriaCine.Expose.Response;

namespace CarteleriaCine.Business
{
	public interface IReservaService
	{
		Task<RegistrarReservaResponse> Registrar(RegistrarReservaRequest request);
	}
}
