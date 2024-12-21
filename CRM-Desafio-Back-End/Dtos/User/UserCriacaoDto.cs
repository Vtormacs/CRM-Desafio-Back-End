namespace CRM_Desafio_Back_End.Dtos.User
{
    public class UserCriacaoDto
    {
        public string name { get; private set; }
        public string email { get; private set; }
        public DateOnly birthday { get; private set; }
    }
}