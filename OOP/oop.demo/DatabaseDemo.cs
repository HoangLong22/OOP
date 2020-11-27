using OOP.oop.dao;
using OOP.oop.entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.oop.demo
{
    class DatabaseDemo
    {
       public void insertTableTest<T>(string name, T row)
        {
            var db = Database.getInstants();
            db.insertTable(name, row);
        }

        public ArrayList selectTableTest(string name)
        {
            var db = Database.getInstants();
            var result = db.selectTable(name);
            return result;
        }

        public void updateTableTest<T>(int id, string name,T row)
        {
            var db = Database.getInstants();
            db.updateTable(id, name, row);

        }

        public void deleteTableTest<T>(string name, T row)
        {
            var db = Database.getInstants();
            db.deleteTable(name, row);
        }

        public void truncateTableTest(string name)
        {
            var db = Database.getInstants();
            db.truncateTable(name);
        }

        public void initDabase()
        {
            var db = Database.getInstants();
            for (int i = 0; i < 10; i++)
            {
                var product = new Product(i, "Product " + i, i);
                var category = new Category(i, "Category " + i);
                var accessory = new Accessotion(i, "Accessory " + i);

                db.insertTable<Product>(Database.PRODUCT, product);
                db.insertTable<Category>(Database.CATEGORY, category);
                db.insertTable<Accessotion>(Database.ACCESSORY, accessory);

            }
        }

        public void printTableTest(string name)
        {
            var db = Database.getInstants();
            if (name == Database.PRODUCT)
            {
                var products = db.selectTable(Database.PRODUCT);
                for (int i = 0; i < products.Count; i++)
                {
                    Product product = (Product)Convert.ChangeType(products[i], typeof(Product));
                    Console.WriteLine("Product");
                    Console.WriteLine("id:" + product.Id);
                    Console.WriteLine("name:" + product.Name);
                    Console.WriteLine("categoryId:" + product.CategoryId);
                    Console.WriteLine();
                }
            }
            if (name == Database.CATEGORY)
            {
                var categories = db.selectTable(Database.CATEGORY);
                for (int i = 0; i < categories.Count; i++)
                {
                    Category category = (Category)Convert.ChangeType(categories[i], typeof(Category));
                    Console.WriteLine("Category");
                    Console.WriteLine("id:" + category.Id);
                    Console.WriteLine("name:" + category.Name);
                    Console.WriteLine();
                }
            }
            if (name == Database.ACCESSORY)
            {
                var accessories = db.selectTable(Database.ACCESSORY);
                for (int i = 0; i < accessories.Count; i++)
                {
                    Accessotion accessotion = (Accessotion)Convert.ChangeType(accessories[i], typeof(Accessotion));
                    Console.WriteLine("Accessotion");
                    Console.WriteLine("id:" + accessotion.Id);
                    Console.WriteLine("name:" + accessotion.Name);
                    Console.WriteLine();
                }
            }
        }
    }
}
