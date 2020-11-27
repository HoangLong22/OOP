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
        public int insertAccseryTest(Accessotion accessotion)
        {
            AccessoryDao accessoryDao = new AccessoryDao();
            var result = accessoryDao.insert(accessotion);
            return result;
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
            var result = accessoryDao.findAll();
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
