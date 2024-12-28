using CRM_Desafio_Back_End.Models.Enums;

namespace CRM_Desafio_Back_End.DTOs.Movement
{
    public class MovementCriacaoDTO
    {
        public int idUser { get; set; }
        public PaymentType paymentType { get; set; }
        public List<ProductMovementCriacaoDTO> products { get; set; }
    }

    public class  ProductMovementCriacaoDTO
    {
        public int idProduct { get; set; }
        public int quantity { get; set; }
    }
}
