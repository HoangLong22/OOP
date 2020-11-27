using OOP.oop.entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.oop.dao
{
    class CategoryDao:BaseDao,IDao
    {
        Database db = Database.getInstants();
        public override bool insert<Category>(Category category)
        {
            db.insertTable<Category>(Database.CATEGORY, category);
            return true;
        }
        public override int update<Category>(Category category)
        {
            db.updateTable<Category>(Database.CATEGORY, category);
            return 1;
        }
        public override ArrayList findAll(string name)
        {
            var result = db.selectTable(name);
            return result;
        }
        public override bool delete<Category>(Category category)
        {
            db.deleteTable<Category>(Database.CATEGORY, category);
            return true;
        }
    }
}
