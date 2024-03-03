using CarteleriaCine.Expose.Request;
using CarteleriaCine.Expose.Response;

namespace CarteleriaCine.Business
{
    public interface IPeliculaService
	{
		Task<List<PeliculaResponse>> ListarPeliculas(PeliculaRequest request);
		Task<DetallePeliculaResponse?> DetallePelicula(int idPelicula);
	}
}
