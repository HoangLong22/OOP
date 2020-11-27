using OOP.oop.entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.oop.dao
{
    public class ProductDao : BaseDao, IDao
    {
        public ProductDao()
        {
            tableName = Database.PRODUCT;
        }
    }
}
