using OOP.oop.entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.oop.dao
{
    class ProductDao:BaseDao,IDao
    {
        Database db = Database.getInstants();
        public override bool insert<Product>(Product product)
        {
            db.insertTable<Product>(Database.PRODUCT, product);
            return true;
        }
        public override int update<Product>(Product product)
        {
            db.updateTable(Database.PRODUCT, product);
            return 1;
        }

        public override ArrayList findAll(string name)
        {
            var result = db.selectTable(name);
            return result;
        }

        public override bool delete<Product>(Product product)
        {
            db.deleteTable<Product>(Database.PRODUCT, product);
            return true;
        }
    }
}
