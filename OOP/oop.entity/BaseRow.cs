using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.oop.entity
{
    public abstract class BaseRow
    {
        protected int id;
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        protected string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int getId()
        {
            return this.id;
        }
        public int setId(int id)
        {
           return this.id = id;
        }

        public string getName()
        {
            return this.name;
        }
        public string setName(string name)
        {
            return this.name = name;
        }
    }
}
