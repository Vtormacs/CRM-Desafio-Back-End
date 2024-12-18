using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_Desafio_Back_End.Model
{
    [Table("userr")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; private set; }
        public string name { get; private set; }
        public string email { get; private set; }
        public DateOnly birthday { get; private set; }
        public DateTime created_at { get; private set; }
        public DateTime updated_at { get; private set; }
        public IList<Movement> movements { get; private set; } = new List<Movement>();

        public User()
        {
        }

        public User(string name, string email, DateOnly birthday, DateTime created_at, DateTime updated_at)
        {
            this.name = name;
            this.email = email;
            this.birthday = birthday;
            this.created_at = created_at;
            this.updated_at = updated_at;
        }
    }
}
