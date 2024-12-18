﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_Desafio_Back_End.Model
{
    [Table("product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; private set; }
        public string name { get; private set; }
        public int amount { get; private set; }
        public decimal value { get; private set; }
        public IList<Movement> movements { get; private set; } = new List<Movement>();

        public Product()
        {
        }

        public Product(string name, int amount, decimal value)
        {
            this.name = name;
            this.amount = amount;
            this.value = value;
        }
    }
}