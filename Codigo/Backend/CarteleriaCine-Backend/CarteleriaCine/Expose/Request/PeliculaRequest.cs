namespace CarteleriaCine.Expose.Request
{
	public class PeliculaRequest
	{
		public int NumeroSala { get; set; }
		public string Titulo { get; set; } = "";
		public string Genero { get; set; } = "";
		public string HoraInicio { get; set; } = "";
	}
}
