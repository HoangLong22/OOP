using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.oop.entity
{
    class Product : BaseRow
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
        public int getCategoryId()
        {
            return this.categoryId;
        }
        public void setCategoryId(int id)
        {
            this.categoryId = id;
        }
    }
}
