using Microsoft.EntityFrameworkCore;
using WebAppArticulos.Models;

namespace WebAppArticulos.Persistencia
{
    public class ArticuloContext: DbContext
    {
        public ArticuloContext(DbContextOptions<ArticuloContext> options): base(options) { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }

    }
}
