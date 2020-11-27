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
        Database db = Database.getInstants();
        public override bool insert<Accessotion>(Accessotion accessotion)
        {
            db.insertTable<Accessotion>(Database.ACCESSORY, accessotion);
            return true;
        }
        public override int update<Accessotion>(Accessotion accessotion)
        {
            db.updateTable<Accessotion>(Database.ACCESSORY, accessotion);
            return 1;
        }
        public override ArrayList findAll(string name)
        {
            var result = db.selectTable(name);
            return result;
        }

        public override bool delete<Accessotion>(Accessotion accessotion)
        {
            db.deleteTable<Accessotion>(Database.ACCESSORY, accessotion);
            return true;
        }
    }
}
