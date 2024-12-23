using CRM_Desafio_Back_End.Model;

namespace CRM_Desafio_Back_End.Dtos.User
{
    public class UserViewDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public DateOnly birthday { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
