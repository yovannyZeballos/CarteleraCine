using System.ComponentModel.DataAnnotations.Schema;

namespace CarteleriaCine.Model
{
	[Table("HorarioPelicula")]
	public class HorarioPelicula
	{
		[Column(TypeName = "int")]
		public int Id { get; set; }

		[Column(TypeName = "Date")]
		public required DateOnly Fecha { get; set; }

		[Column(TypeName = "char(5)")]
		public required string HoraInicio { get; set; }

		[Column(TypeName = "char(5)")]
		public required string HoraFin { get; set; }

		public virtual required Pelicula Pelicula { get; set; }

		public virtual required SalaPelicula Sala { get; set; }

	}
}
