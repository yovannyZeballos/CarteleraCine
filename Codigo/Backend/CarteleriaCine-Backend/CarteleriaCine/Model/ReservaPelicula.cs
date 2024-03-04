using System.ComponentModel.DataAnnotations.Schema;

namespace CarteleriaCine.Model
{
	[Table("ReservaPelicula")]
	public class ReservaPelicula
	{
		[Column(TypeName = "int")]
		public int Id { get; set; }

		[Column(TypeName = "datetime")]
		public DateTime FechaCreacion { get; set; }
        public Cliente Cliente { get; set; }
        public required HorarioPelicula HorarioPelicula { get; set; }
	}
}
