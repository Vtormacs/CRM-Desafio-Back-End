using CRM_Desafio_Back_End.Dtos.User;
using CRM_Desafio_Back_End.Model;
using CRM_Desafio_Back_End.Models;

namespace CRM_Desafio_Back_End.Services.User
{
    public interface IUserInterface
    {
        Task<ResponseModel<List<UserModel>>> listarUsers();
        Task<ResponseModel<UserModel>> buscarUserPorId(int id);
        Task<ResponseModel<UserModel>> excluirUser(int id);
        Task<ResponseModel<List<UserModel>>> criarUser(UserCriacaoDto userCriacaoDto);
    }
}
