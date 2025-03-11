namespace WebAppArticulos.Models
{
    public class Categoria
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Eliminado { get; set; }
        public ICollection<Producto>? Productos { get; set; }
    }
}
