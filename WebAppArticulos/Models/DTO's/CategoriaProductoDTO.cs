using WebAppArticulos.Models;

namespace WebAppArticulos.Models.DTO_s
{
    public class CategoriaProductoDTO
    {
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public CategoriaProductoDTO() { }

        public CategoriaProductoDTO(Categoria categoria)
        {
            Nombre = categoria.Nombre;
            Descripcion = categoria.Descripcion;
        }
    }
}
