using CarteleriaCine.Model;
using Microsoft.EntityFrameworkCore;

namespace CarteleriaCine.Repository
{
	public class CarteleriaContexto : DbContext
	{
		public CarteleriaContexto(DbContextOptions<CarteleriaContexto> options)
		: base(options)
		{
		}

		public DbSet<Pelicula> Peliculas { get; set; }
		public DbSet<GeneroPelicula> GeneroPeliculas { get; set; }
		public DbSet<Cliente> Clientes { get; set; }
		public DbSet<HorarioPelicula> HorariosPelicula { get; set; }
		public DbSet<ReservaPelicula> ReservasPelicula { get; set; }
		public DbSet<SalaPelicula> SalasPelicula { get; set; }
		public DbSet<TipoDocumentoIdentidad> TipoDocumentosIdentidad { get; set; }

	}
}
