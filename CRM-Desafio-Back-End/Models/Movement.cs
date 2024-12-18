using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CRM_Desafio_Back_End.Models.Enums;
using Microsoft.AspNetCore.Components.Web;

namespace CRM_Desafio_Back_End.Model
{
    [Table("movement")]
    public class Movement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; private set; }
        public DateTime created_at { get; private set; }
        public DateTime updated_at { get; private set; }
        public IList<Product> products { get; private set; } = new List<Product>();
        public User user { get; private set; }
        public PaymentType paymentType { get; private set; }
        public Boolean blocked { get; private set; }

        public Movement()
        {
        }

        public Movement(DateTime created_at, DateTime updated_at, IList<Product> products, User user, PaymentType paymentType, bool blocked)
        {
            this.created_at = created_at;
            this.updated_at = updated_at;
            this.products = products;
            this.user = user;
            this.paymentType = paymentType;
            this.blocked = blocked;
        }
    }
}
