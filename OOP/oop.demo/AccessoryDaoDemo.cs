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
    class AccessoryDaoDemo
    {
        public bool insertAccseryTest(Accessotion accessotion)
        {
            AccessoryDao accessoryDao = new AccessoryDao();
            var result = accessoryDao.insert(accessotion);
            return result;
        }
        public void printAccseryDao(Accessotion accessotion)
        {
            Console.WriteLine("Accessory Dao");
            Console.WriteLine("id:" + accessotion.Id);
            Console.WriteLine("name:" + accessotion.Name);
            Console.WriteLine();
        }

        public int updateAccesoryDaoTest(Accessotion accessotion)
        {
            AccessoryDao accessoryDao = new AccessoryDao();
            var result = accessoryDao.update(accessotion);
            return 1;
        }
        public ArrayList findAccessoryDaoTest(string name)
        {
            AccessoryDao accessoryDao = new AccessoryDao();
            var result = accessoryDao.findAll(name);
            return result;
        }
        public bool deleteAccessoryDaoTest(Accessotion accessotion)
        {
            AccessoryDao accessoryDao = new AccessoryDao();
            accessoryDao.delete(accessotion);
            return true;
        }
    }
}
