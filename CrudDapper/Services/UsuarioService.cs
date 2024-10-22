using CrudDapper.Dto;
using CrudDapper.Models;
using System.Data.SqlClient;

namespace CrudDapper.Services
{
    public class UsuarioService : IUsuarioInterface
    {

        private readonly IConfiguration _configuration;
        public UsuarioService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<ResponseModel<List<UsuarioListarDto>>> BuscarUsuarios()
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))//Iniciando conexão dentro do USING
            {

            }
        }
    }
}
