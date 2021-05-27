using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    public class ProductModel
    {
        public ProductModel(int id, string name, double price, string image) 
        {
            Id = id;
            Name = name;
            Price = price;
            Image = image;
        }
        public string Image { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
