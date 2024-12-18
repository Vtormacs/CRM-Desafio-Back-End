using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CRM_Desafio_Back_End.Models.Enums;
using Microsoft.AspNetCore.Components.Web;

namespace CRM_Desafio_Back_End.Model
{
    public class MovementModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; private set; }
        public DateTime created_at { get; private set; }
        public DateTime updated_at { get; private set; }
        public IList<ProductModel> products { get; private set; } = new List<ProductModel>();
        public UserModel user { get; private set; }
        public PaymentType paymentType { get; private set; }
        public Boolean blocked { get; private set; }

        public MovementModel()
        {
        }

        public MovementModel(DateTime created_at, DateTime updated_at, IList<ProductModel> products, UserModel user, PaymentType paymentType, bool blocked)
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
