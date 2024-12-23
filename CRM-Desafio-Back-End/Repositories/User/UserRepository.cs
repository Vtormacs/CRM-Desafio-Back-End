using CRM_Desafio_Back_End.Data;
using CRM_Desafio_Back_End.Dtos.User;
using CRM_Desafio_Back_End.Model;
using Microsoft.EntityFrameworkCore;

namespace CRM_Desafio_Back_End.Repositories.User
{
    /// <summary>
    /// Repositório para gerenciar operações relacionadas a usuários no banco de dados.
    /// </summary>
    public class UserRepository : IUserRespository
    {
        private readonly AppDbContext _appDbContext;

        /// <summary>
        /// Construtor para injetar dependências.
        /// </summary>
        /// <param name="appDbContext">Contexto do banco de dados.</param>
        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        /// <summary>
        /// Busca um usuário pelo ID.
        /// </summary>
        /// <param name="id">ID do usuário.</param>
        /// <returns>Modelo do usuário encontrado.</returns>
        public async Task<UserModel> buscarPorId(int id)
        {
            return await _appDbContext.users
                .Include(u => u.movements)
                .FirstOrDefaultAsync(x => x.id == id);
        }

        /// <summary>
        /// Cria um novo usuário no banco de dados.
        /// </summary>
        /// <param name="userModel">Modelo do usuário a ser criado.</param>
        /// <returns>Lista atualizada de usuários.</returns>
        public async Task<List<UserModel>> criarUser(UserModel userModel)
        {
            await _appDbContext.users.AddAsync(userModel);
            await _appDbContext.SaveChangesAsync();
            return await listarUsers();
        }

        /// <summary>
        /// Exclui um usuário pelo ID.
        /// </summary>
        /// <param name="id">ID do usuário.</param>
        /// <returns>Modelo do usuário excluído ou null se não encontrado.</returns>
        public async Task<UserModel?> excluirPorId(int id)
        {
            var user = await _appDbContext.users.FirstOrDefaultAsync(x => x.id == id);
            if (user == null)
            {
                return null;
            }

            _appDbContext.users.Remove(user);
            await _appDbContext.SaveChangesAsync();
            return user;
        }

        /// <summary>
        /// Lista todos os usuários do banco de dados em ordem decrescente de criação.
        /// </summary>
        /// <returns>Lista de usuários.</returns>
        public async Task<List<UserModel>> listarUsers()
        {
            return await _appDbContext.users
                .OrderByDescending(u => u.created_at)
                .ToListAsync();
        }
    }
}
