using WebAppArticulos.DAO;

namespace WebAppArticulos.Models.DTO_s
{
    public class CategoriaDTO
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Eliminado { get; set; }
        public ICollection<ProductoCategoriaDTO>? Productos { get; set; }

        public CategoriaDTO() { }

        public CategoriaDTO(Categoria categoria)
        {
            Nombre = categoria.Nombre;
            Descripcion = categoria.Descripcion;
            Eliminado = categoria.Eliminado;
            Productos = categoria.Productos.Select(p => new ProductoCategoriaDTO(p)).ToList();
        }
    }
}
