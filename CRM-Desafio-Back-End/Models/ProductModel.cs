﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_Desafio_Back_End.Model
{
    public class ProductModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; private set; }
        public string name { get; private set; }
        public int amount { get; private set; }
        public decimal value { get; private set; }
        public IList<MovementModel> movements { get; private set; } = new List<MovementModel>();

        public ProductModel()
        {
        }

        public ProductModel(string name, int amount, decimal value)
        {
            this.name = name;
            this.amount = amount;
            this.value = value;
        }
    }
}
