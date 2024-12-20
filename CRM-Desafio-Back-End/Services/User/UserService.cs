using CRM_Desafio_Back_End.Data;
using CRM_Desafio_Back_End.Model;
using CRM_Desafio_Back_End.Models;

namespace CRM_Desafio_Back_End.Services.User
{
    public class UserService : IUserInterface
    {
        private readonly AppDbContext _context;
        public UserService(AppDbContext context) { 
            _context = context;
        }

        public Task<ResponseModel<UserModel>> buscarUserPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<UserModel>> excluirUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<UserModel>>> listarUsers()
        {
            throw new NotImplementedException();
        }
    }
}