using OOP.oop.dao;
using OOP.oop.demo;
using OOP.oop.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDemo productDemo = new ProductDemo();
            var product = productDemo.createProduct(10, "Lead", 3);
            productDemo.printProduct(product);

            CategortDemo categoryDemo = new CategortDemo();
            var category = categoryDemo.createCategory(10, "Honda");
            categoryDemo.printCategory(category);
            

            AccessotionDemo accessotionDemo = new AccessotionDemo();
            var accessotion = accessotionDemo.createAccessotion(1, "Yess");
            accessotionDemo.printAccessory(accessotion);

            DatabaseDemo databaseDemo = new DatabaseDemo();
            databaseDemo.insertTableTest<Product>(Database.PRODUCT, product);
            databaseDemo.insertTableTest<Category>(Database.CATEGORY, category);
            databaseDemo.insertTableTest<Accessotion>(Database.ACCESSORY, accessotion);

            //var productTable = databaseDemo.selectTableTest(Database.PRODUCT);
            //var categoryTable = databaseDemo.selectTableTest(Database.CATEGORY);
            //var accessoryTable = databaseDemo.selectTableTest(Database.ACCESSORY);


            databaseDemo.initDabase();
            databaseDemo.printTableTest(Database.PRODUCT);
            databaseDemo.printTableTest(Database.CATEGORY);
            databaseDemo.printTableTest(Database.ACCESSORY);

            CategoryDaoDemo categoryDaoDemo = new CategoryDaoDemo();
            categoryDaoDemo.printCategoryDao(category);

            ProductDaoDemo productDaoDemo = new ProductDaoDemo();
            productDaoDemo.printProductDao(product);

            Console.ReadKey();

        }

    }
}
