using CRM_Desafio_Back_End.Model;
using CRM_Desafio_Back_End.Models;
using CRM_Desafio_Back_End.Repositories.User;

namespace CRM_Desafio_Back_End.Services.User
{
    public class UserService : IUserInterface
    {
        private readonly IUserRespository _userRespository;
        public UserService(IUserRespository userRespository)
        {
            _userRespository = userRespository;
        }

        public async Task<ResponseModel<UserModel>> buscarUserPorId(int id)
        {
            try
            {
                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<ResponseModel<UserModel>> excluirUser(int id)
        {
            try
            {
                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<ResponseModel<List<UserModel>>> listarUsers()
        {
            ResponseModel<List<UserModel>> resposta = new ResponseModel<List<UserModel>>();
            try
            {
                var users = await _userRespository.listarUsers();
                resposta.dados = users;
                resposta.mensagem = "Todos usuarios coletados do banco em ordem decrecente";
                return resposta;
            }
            catch (Exception e)
            {
                resposta.mensagem = e.Message;
                resposta.status = false;
                return resposta;
            }
        }
    }
}