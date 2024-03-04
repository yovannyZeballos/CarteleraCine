namespace CarteleriaCine.Expose.Response
{
	public class SalaResponse
	{
		public int Numero { get; set; }

		public int EntradasDisponibles { get; set; }

		public HorariosResponse Horario { get; set; } = new();

	}
}
