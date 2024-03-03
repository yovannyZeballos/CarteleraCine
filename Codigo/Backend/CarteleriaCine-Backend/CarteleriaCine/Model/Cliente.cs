using System.ComponentModel.DataAnnotations.Schema;

namespace CarteleriaCine.Model
{
	[Table("Cliente")]
	public class Cliente
	{
		[Column(TypeName = "int")]
		public int Id { get; set; }

		[Column(TypeName = "varchar(30)")]
		public required string Nombres { get; set; }

		[Column(TypeName = "varchar(30)")]
		public required string ApellidoPaterno { get; set; }

		[Column(TypeName = "varchar(30)")]
		public required string ApellidoMaterno { get; set; }

		[Column(TypeName = "varchar(20)")]
		public required string NumeroDocumento { get; set; }

		[Column(TypeName = "char(1)")]
		public required string Genero { get; set; }

		[Column(TypeName = "Date")]
		public DateOnly FechaNacimiento { get; set; }
		public required TipoDocumentoIdentidad TipoDocumento { get; set; }

	}
}
