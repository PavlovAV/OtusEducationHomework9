using OtusEducationHomework9.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusEducationHomework9.Models
{
    public class Product : IMyCloneable<Product>, ICloneable
    {
        public Guid ProductId { get; set; }
        public string Number { get; set; }
        public decimal Quantity { get; set; }

        public Product(decimal quantity)
        {
            ProductId = Guid.NewGuid();
            Number = ProductId.ToString();
            Quantity = quantity;
        }
        public Product MyClone()
        {
            return new Product(this.Quantity);
        }

        public object Clone()
        {
            return MyClone();
        }

        public override string ToString()
        {
            return $"ProductId = {ProductId}; Number = {Number}; Quantity = {Quantity}";
        }

    }
}
