using Microsoft.Data.SqlClient;

namespace WebAppArticulos.DAO
{
    public class ConexionDB
    {
        private const string CADENA = "Server=ANA\\SQLEXPRESS;Database=articulosDBNew;Trusted_Connection=True;User Id=XX;Password=XXXX;TrustServerCertificate=true";
        public static SqlConnection connection = new SqlConnection(CADENA);
    }
}
