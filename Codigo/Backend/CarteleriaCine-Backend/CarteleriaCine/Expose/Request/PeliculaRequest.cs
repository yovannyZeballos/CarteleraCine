namespace CarteleriaCine.Expose.Request
{
	public class PeliculaRequest
	{
		public int IdSala { get; set; }
		public string Titulo { get; set; } = "";
		public int IdGenero { get; set; }
		public string? HoraInicio { get; set; } = "";
	}
}
