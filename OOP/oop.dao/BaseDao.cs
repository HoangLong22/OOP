using OOP.oop.entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.oop.dao
{
    public abstract class BaseDao
    {
        Database db = Database.getInstants();
        public abstract bool insert<T>(T row);
        public abstract int update<T>(T row);
        public abstract ArrayList findAll(string name);
        public abstract bool delete<T>(T row);
    }
}
