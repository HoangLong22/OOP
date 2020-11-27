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
        protected string tableName;
        Database db = Database.getInstants();

        public int insert<T>(T row)
        {
           return db.insertTable<T>(tableName, row);
        }
        public int update<T>(T row)
        {
            return db.updateTable<T>(tableName, row);
        }
        public bool delete<T>(T row)
        {
            return db.deleteTable<T>(tableName, row);
        }
        public ArrayList findAll()
        {
            return db.selectTable(tableName);
        }
    }
}
