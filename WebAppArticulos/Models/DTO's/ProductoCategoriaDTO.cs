using WebAppArticulos.Models;

namespace WebAppArticulos.Models.DTO_s
{
    public class ProductoCategoriaDTO
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string Codigo { get; set; }
        public int PrecioUnitario { get; set; }
        public int Stock { get; set; }

        public ProductoCategoriaDTO() { }

        public ProductoCategoriaDTO(Producto producto)
        {
            Nombre = producto.Nombre;
            Descripcion = producto.Descripcion;
            FechaCreacion = producto.FechaCreacion;
            FechaModificacion = producto.FechaModificacion;
            Codigo = producto.Codigo;
            PrecioUnitario = producto.PrecioUnitario;
            Stock = producto.Stock;
        }
    }
}
