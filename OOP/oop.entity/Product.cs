using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.oop.entity
{
    class Product : BaseRow, IEntity
    {
        private int categoryId;
        public int CategoryId
        {
            set { categoryId = value; }
            get { return categoryId; }
        }
        public Product(int id, string name, int categoryid)
        {
            this.id = id;
            this.name = name;
            this.categoryId = categoryid;
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

        public int getCategoryId()
        {
            return categoryId;
        }
        public void setCategoryId(int id)
        {
            this.categoryId = id;
        }
    }
}
