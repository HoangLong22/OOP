using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.oop.entity
{
    class Category:BaseRow,IEntity
    {
        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override int getId()
        {
            return id;
        }
        public override void setId(int id)
        {
            this.id = id;
        }

        public override string getName()
        {
            return name;
        }
        
        public override void setName(string name)
        {
            this.name = name;
        }

    }
}
