namespace CarteleriaCine.Expose.Request
{
	public class RegistrarReservaRequest
	{
		public int HorarioId { get; set; }
		public required string Nombres { get; set; }
		public required string ApellidoPaterno { get; set; }
		public required string ApellidoMaterno { get; set; }
		public required string NumeroDocumento { get; set; }
		public required string Genero { get; set; }
		public DateTime FechaNacimiento { get; set; }
		public required int TipoDocumentoIdentidadId { get; set; }
	}
}
