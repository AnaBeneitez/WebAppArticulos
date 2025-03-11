using WebAppArticulos.DAO;

namespace WebAppArticulos.Models.DTO_s
{
    public class ProductoDTO
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string Codigo { get; set; }
        public int PrecioUnitario { get; set; }
        public int Stock { get; set; }
        public int Eliminado { get; set; }
        public CategoriaProductoDTO? Categoria { get; set; }

        public ProductoDTO() { }

        public ProductoDTO(Producto producto)
        {
            Nombre = producto.Nombre;
            Descripcion = producto.Descripcion;
            FechaCreacion = producto.FechaCreacion;
            FechaModificacion = producto.FechaModificacion;
            Codigo = producto.Codigo;
            PrecioUnitario = producto.PrecioUnitario;
            Stock = producto.Stock;
            Eliminado = producto.Eliminado;
            Categoria = new CategoriaProductoDTO(producto.Categoria);
        }
    }
}
