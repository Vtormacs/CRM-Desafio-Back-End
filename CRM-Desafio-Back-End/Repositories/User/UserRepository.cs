using CRM_Desafio_Back_End.Data;
using CRM_Desafio_Back_End.Dtos.User;
using CRM_Desafio_Back_End.Model;
using Microsoft.EntityFrameworkCore;

namespace CRM_Desafio_Back_End.Repositories.User
{
    public class UserRepository : IUserRespository
    {
        private readonly AppDbContext _appDbContext;

        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<UserModel> buscarPorId(int id)
        {
            return await _appDbContext.users
            .Include(u => u.movements)
            .FirstOrDefaultAsync(x => x.id == id);
        }

        public async Task<List<UserModel>> criarUser(UserModel userModel)
        {
            await _appDbContext.users.AddAsync(userModel);
            await _appDbContext.SaveChangesAsync();
            return await listarUsers();
        }

        public async Task<UserModel?> excluirPorId(int id)
        {
            var user = await _appDbContext.users.FindAsync(id);
            if (user == null)
            {
                return null;
            }

            _appDbContext.users.Remove(user);
            await _appDbContext.SaveChangesAsync();
            return user;
        }

        public async Task<List<UserModel>> listarUsers()
        {
            return await _appDbContext.users
                .OrderByDescending(u => u.created_at)
                .ToListAsync();
        }
    }
}
