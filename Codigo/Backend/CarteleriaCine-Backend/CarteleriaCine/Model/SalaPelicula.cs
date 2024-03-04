using System.ComponentModel.DataAnnotations.Schema;

namespace CarteleriaCine.Model
{
	[Table("SalaPelicula")]
	public class SalaPelicula
	{
		[Column(TypeName = "int")]
		public int Id { get; set; }

		[Column(TypeName = "int")]
		public int Numero { get; set; }

		[Column(TypeName = "int")]
		public int EntradasDisponibles { get; set; }

		public required ICollection<HorarioPelicula> HorarioPeliculas { get; set; }
	}
}
