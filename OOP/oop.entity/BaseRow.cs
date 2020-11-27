using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.oop.entity
{
    public abstract class BaseRow
    {
        public int id;
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
        public abstract int getId();
        public abstract void setId(int id);
        public abstract string getName();
        public abstract void setName(string name);
    }
}
