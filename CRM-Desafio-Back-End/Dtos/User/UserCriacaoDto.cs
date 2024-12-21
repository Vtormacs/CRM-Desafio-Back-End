using System.ComponentModel.DataAnnotations;

namespace CRM_Desafio_Back_End.Dtos.User
{
    public class UserCriacaoDto
    {
        public string name { get; set; }
        [EmailAddress(ErrorMessage = "The email field is not a valid e-mail address.")]
        public string email { get; set; }
        public DateOnly birthday { get; set; }
    }
}