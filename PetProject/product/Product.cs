using PetProject.user;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PetProject.product
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Product(string name, string description, decimal price)
        {
            this.Name = name;
            this.Price = price;
            this.Description = description;
        }
    }
    public class Products 
    {
        public List<Product> products { get; set; } = new List<Product>();
        public void AddProduct(string name, string description, decimal price)
        {
            Product product = new Product(name, description, price);
            products.Add(product);
        }
        public void DeleteProduct(string name)
        {
            products.RemoveAll(item => item.Name == name);
        }
        public void ShowProducts(List<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine($"Имя-{product.Name}, Описание-{product.Description}, Цена-{product.Price}");
            }
        }
    }

}
