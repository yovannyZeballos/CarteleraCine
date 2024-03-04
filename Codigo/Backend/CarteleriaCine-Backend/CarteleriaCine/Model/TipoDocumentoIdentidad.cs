using System.ComponentModel.DataAnnotations.Schema;

namespace CarteleriaCine.Model
{
	[Table("TipoDocumentoIdentidad")]
	public class TipoDocumentoIdentidad
	{
		[Column(TypeName = "int")]
		public int Id { get; set; }

		[Column(TypeName = "varchar(50)")]
		public required string Descripcion { get; set; } 
    }
}
