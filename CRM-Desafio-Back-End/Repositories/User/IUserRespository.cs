using CRM_Desafio_Back_End.Model;

namespace CRM_Desafio_Back_End.Repositories.User
{
    public interface IUserRespository
    {
        Task<List<UserModel>> listarUsers();
        Task<UserModel> buscarPorId(int id);
        Task<UserModel?> excluirPorId(int id);
    }
}
