using System.ComponentModel.DataAnnotations.Schema;

namespace CarteleriaCine.Model
{
	public class GeneroPelicula
	{
		[Column(TypeName = "int")]
		public int Id { get; set; }

		[Column(TypeName = "varchar(50)")]
		public string? Descripcion { get; set; }

		public virtual ICollection<Pelicula>? Peliculas { get; }
	}
}
