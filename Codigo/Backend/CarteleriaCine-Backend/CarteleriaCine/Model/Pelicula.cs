using System.ComponentModel.DataAnnotations.Schema;

namespace CarteleriaCine.Model
{
	[Table("Pelicula")]
	public class Pelicula
	{
		[Column(TypeName = "int")]
		public int Id { get; set; }

		[Column(TypeName = "varchar(50)")]
		public required string Titulo { get; set; }

		[Column(TypeName = "varchar(500)")]
		public required string Sinopsis { get; set; }

		[Column(TypeName = "int")]
		public int Duracion { get; set; }

		[Column(TypeName = "varchar(250)")]
		public string? UrlImagen { get; set; }

        public virtual required GeneroPelicula Genero { get; set; }
		public virtual ICollection<HorarioPelicula> HorariosPelicula { get; } = new List<HorarioPelicula>();

	}
}
