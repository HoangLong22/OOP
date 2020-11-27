using OOP.oop.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.oop.demo
{
    class ProductDemo
    {
        public Product createProduct(int id, string name, int categoryid)
        {
            Product product = new Product(id, name, categoryid);
            return product;
        }

        public void printProduct(Product product)
        {
            Console.WriteLine("Product");
            Console.WriteLine("id:" + product.Id);
            Console.WriteLine("name:" + product.Name);
            Console.WriteLine("categoryId:" + product.CategoryId);
            Console.WriteLine();
        }
    }
}
