using OOP.oop.entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.oop.dao
{
    class AccessoryDao:BaseDao,IDao
    {
       public AccessoryDao()
        {
            tableName = Database.ACCESSORY;
        }
    }
}
