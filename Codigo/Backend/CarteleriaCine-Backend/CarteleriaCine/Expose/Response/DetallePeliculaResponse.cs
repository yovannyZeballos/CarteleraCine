namespace CarteleriaCine.Expose.Response
{
	public class DetallePeliculaResponse
	{
		public int Id { get; set; }

		public required string Titulo { get; set; }

		public required string Sinopsis { get; set; }

		public string? Genero { get; set; }

		public int Duracion { get; set; }

		public string? UrlImagen { get; set; }

		public List<SalaResponse> Salas { get; set; } = [];
	}
}
