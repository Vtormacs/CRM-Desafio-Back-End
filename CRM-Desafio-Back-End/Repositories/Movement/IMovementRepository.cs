using CRM_Desafio_Back_End.Model;

namespace CRM_Desafio_Back_End.Repositories.Movement
{
    public interface IMovementRepository
    {
        Task<MovementModel> cadastrarMovimento(MovementModel movimento);
    }
}
