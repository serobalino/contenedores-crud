using Microsoft.Data.SqlClient;
using System.Data;

namespace Clientes.Data
{
    public class DockerDbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public DockerDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DockerDb");

        }
        public IDbConnection CrearConexion() => new SqlConnection(_connectionString);
    }
}
