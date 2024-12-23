using CRM_Desafio_Back_End.Dtos.User;
using CRM_Desafio_Back_End.Model;
using CRM_Desafio_Back_End.Models;
using CRM_Desafio_Back_End.Repositories.User;

namespace CRM_Desafio_Back_End.Services.User
{
    /// <summary>
    /// Serviço para gerenciar operações relacionadas a usuários.
    /// </summary>
    public class UserService : IUserService
    {
        private readonly IUserRespository _userRespository;

        /// <summary>
        /// Construtor para injetar dependências.
        /// </summary>
        /// <param name="userRespository">Repositório de usuários.</param>
        public UserService(IUserRespository userRespository)
        {
            _userRespository = userRespository;
        }

        /// <summary>
        /// Busca um usuário pelo ID.
        /// </summary>
        /// <param name="id">ID do usuário.</param>
        /// <returns>Modelo de resposta contendo o usuário.</returns>
        public async Task<ResponseModel<UserModel>> buscarUserPorId(int id)
        {
            ResponseModel<UserModel> resposta = new ResponseModel<UserModel>();
            try
            {
                var user = await _userRespository.buscarPorId(id);

                if (user == null)
                {
                    resposta.mensagem = "Usuario não encontrado";
                    resposta.status = false;
                    return resposta;
                }

                resposta.dados = user;
                resposta.mensagem = "Usuario coletado do banco";
                return resposta;
            }
            catch (Exception e)
            {
                resposta.mensagem = e.Message;
                resposta.status = false;
                return resposta;
            }
        }

        /// <summary>
        /// Cria um novo usuário e retorna a lista atualizada de usuários.
        /// </summary>
        /// <param name="userCriacaoDto">Objeto DTO contendo as informações do usuário a ser criado.</param>
        /// <returns>Modelo de resposta contendo a lista de usuários atualizada.</returns>
        public async Task<ResponseModel<List<UserModel>>> criarUser(UserCriacaoDto userCriacaoDto)
        {
            ResponseModel<List<UserModel>> resposta = new ResponseModel<List<UserModel>>();
            try
            {
                var user = new UserModel(
                    name: userCriacaoDto.name,
                    email: userCriacaoDto.email,
                    birthday: userCriacaoDto.birthday,
                    created_at: DateTime.UtcNow,
                    updated_at: DateTime.UtcNow
                    );

                await _userRespository.criarUser(user);

                var users = await _userRespository.listarUsers();
                resposta.dados = users;
                resposta.mensagem = "Usuario criado com sucesso";
                return resposta;
            }
            catch (Exception e)
            {
                resposta.mensagem = $"An error occurred: {e.Message}";
                if (e.InnerException != null)
                {
                    resposta.mensagem += $" Inner exception: {e.InnerException.Message}";
                }
                resposta.status = false;
                return resposta;
            }
        }

        /// <summary>
        /// Exclui um usuário pelo ID.
        /// </summary>
        /// <param name="id">ID do usuário.</param>
        /// <returns>Modelo de resposta contendo o usuário excluído.</returns>
        public async Task<ResponseModel<UserModel>> excluirUser(int id)
        {
            ResponseModel<UserModel> resposta = new ResponseModel<UserModel>();
            try
            {
                var user = await _userRespository.excluirPorId(id);

                if (user == null)
                {
                    resposta.mensagem = "Usuario não encontrado";
                    return resposta;
                }

                resposta.dados = user;
                resposta.mensagem = "Usuario excluído com sucesso";
                return resposta;
            }
            catch (Exception e)
            {
                resposta.mensagem = e.Message;
                resposta.status = false;
                return resposta;
            }
        }

        /// <summary>
        /// Lista todos os usuários.
        /// </summary>
        /// <returns>Modelo de resposta contendo a lista de usuários.</returns>
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