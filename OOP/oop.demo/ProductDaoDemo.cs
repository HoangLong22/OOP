using OOP.oop.dao;
using OOP.oop.entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.oop.demo
{
    class ProductDaoDemo
    {
        public int insertProductTest(Product product)
        {
            ProductDao productDao = new ProductDao();
            var result = productDao.insert(product);
            return result;
        }

        public int updateProductDaoTest(Product product)
        {
            ProductDao productDao = new ProductDao();
            var result = productDao.update(product);
            return 1;
        } 
        public ArrayList findProductDaoTest(string name)
        {
            ProductDao productDao = new ProductDao();
            var result = productDao.findAll();
            return result;
        }

        public bool deleteProductDaoTest(Product product)
        {
            ProductDao productDao = new ProductDao();
            var result = productDao.delete(product);
            return true;
        }
    }
}
