using CrudDapper.Dto;
using CrudDapper.Models;

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
            throw new NotImplementedException();
        }
    }
}
