using CRM_Desafio_Back_End.Data;
using CRM_Desafio_Back_End.Model;

namespace CRM_Desafio_Back_End.Repositories.Movement
{
    public class MovementRpository : IMovementRepository
    {
        private readonly AppDbContext _appDbContext;
        public MovementRpository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<MovementModel> cadastrarMovimento(MovementModel movimento)
        {
            await _appDbContext.movements.AddAsync(movimento);
            await _appDbContext.SaveChangesAsync();
            return movimento;
        }
    }
}
