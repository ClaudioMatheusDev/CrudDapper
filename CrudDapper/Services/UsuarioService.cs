using AutoMapper;
using CrudDapper.Dto;
using CrudDapper.Models;
using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CrudDapper.Services
{
    public class UsuarioService : IUsuarioInterface
    {

        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;   
        public UsuarioService(IConfiguration configuration, IMapper mapper)
        {
            _configuration = configuration;
            _mapper = mapper;
        }

        public async Task<ResponseModel<List<UsuarioListarDto>>> BuscarUsuarios()
        {
            ResponseModel<List<UsuarioListarDto>> response = new ResponseModel<List<UsuarioListarDto>>();

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))//Iniciando conexão dentro do USING
            {

                var usuariosBanco = await connection.QueryAsync<Usuario>("select * from Usuarios"); //Query SQL para selecionar todos os usuarios

                if (usuariosBanco.Count() == 0) //Se a lista usuarios dentro do banco de dados estiver vazia
                {
                    response.Mensagem = "Nenhum usuário localizado";
                    response.Status = false;
                    return response;
                }


                //Transformação Mapper

                var usuarioMapeado = _mapper.Map<List<UsuarioListarDto>>(usuariosBanco);

                response.Dados = usuarioMapeado;
                response.Mensagem = "Usuários localizados com sucesso!";


            }
            return response;
        }
    }
}
