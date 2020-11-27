using OOP.oop.entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.oop.dao
{
    class Database
    {
        private static Database instants = new Database();
        private Database() { }

        public const string  PRODUCT =  "productTable";
        public const string CATEGORY = "categoryTable";
        public const string ACCESSORY = "accessoryTable";

        private static ArrayList productTable = new ArrayList();
        private static ArrayList categoryTable = new ArrayList();
        private static ArrayList accessoryTable = new ArrayList();

        public static Database getInstants()
        {
            return instants;
        }
        public int insertTable<T>(string name, T row)
        {
            if(name.Equals(PRODUCT))
            {
                Product product = (Product)Convert.ChangeType(row, typeof(Product));
                productTable.Add(product);
                return 1;
            }
            if(name.Equals(CATEGORY))
            {
                Category category = (Category)Convert.ChangeType(row, typeof(Category));
                categoryTable.Add(category);
                return 1;
            }
            if(name.Equals(ACCESSORY))
            {
                Accessotion accessotion = (Accessotion)Convert.ChangeType(row, typeof(Accessotion));
                accessoryTable.Add(accessotion);
                return 1;
            }

            return 0;
        }

        public ArrayList selectTable(string name)
        {
            if(name == PRODUCT)
            {
                return productTable;
            }
            if (name == CATEGORY)
            {
                return categoryTable;
            }
            if (name == ACCESSORY)
            {
                return accessoryTable;
            }
            return null;
        }

        public int updateTable<T>(string name, T row)
        {
            if(name == PRODUCT)
            {
                Product product = (Product)Convert.ChangeType(row, typeof(Product));
                var i = productTable.IndexOf(product);
                productTable[i] = row;
            }
            if (name == CATEGORY)
            {
                Category category = (Category)Convert.ChangeType(row, typeof(Category));
                var i = productTable.IndexOf(category);
                productTable[i] = row;
            }
            if (name == ACCESSORY)
            {
                Accessotion accessotion = (Accessotion)Convert.ChangeType(row, typeof(Accessotion));
                var i = productTable.IndexOf(accessotion);
                productTable[i] = row;
            }
            return 0;
        }
        public bool deleteTable<T>(string name, T row)
        {
            if (name.Equals(PRODUCT))
            {
                Product product = (Product)Convert.ChangeType(row, typeof(Product));
                productTable.Remove(product);
                return true;
            }
            if (name.Equals(CATEGORY))
            {
                Category category = (Category)Convert.ChangeType(row, typeof(Category));
                categoryTable.Remove(category);
                return true;
            }
            if (name.Equals(ACCESSORY))
            {
                Accessotion accessotion = (Accessotion)Convert.ChangeType(row, typeof(Accessotion));
                accessoryTable.Remove(accessotion);
                return true;
            }
            return false;
        }

        public void truncateTable(string name)
        {
            if (name.Equals(PRODUCT))
            {
                productTable.Clear();
            }
            if (name.Equals(CATEGORY))
            {
                categoryTable.Clear();
            }
            if (name.Equals(ACCESSORY))
            {
                accessoryTable.Clear();
            }
        }
        public int updateTable<T>(int id, string name, T row)
        {
            if (name == PRODUCT)
            {
                Product product = (Product)Convert.ChangeType(row, typeof(Product));
                var i = productTable.IndexOf(product);
                productTable[i] = row;
            }
            if (name == CATEGORY)
            {
                Category category = (Category)Convert.ChangeType(row, typeof(Category));
                var i = productTable.IndexOf(category);
                productTable[i] = row;
            }
            if (name == ACCESSORY)
            {
                Accessotion accessotion = (Accessotion)Convert.ChangeType(row, typeof(Accessotion));
                var i = productTable.IndexOf(accessotion);
                productTable[i] = row;
            }
            return 0;
        }
    }
}
