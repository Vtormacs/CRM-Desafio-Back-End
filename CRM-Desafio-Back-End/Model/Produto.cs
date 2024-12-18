using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_Desafio_Back_End.Model
{
    [Table("produto")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; private set; }
        public string name { get; private set; }
        public int amount { get; private set; }
        public decimal value { get; private set; }

        public Produto()
        {
        }

        public Produto(string name, int amount, decimal value)
        {
            this.name = name;
            this.amount = amount;
            this.value = value;
        }
    }
}
