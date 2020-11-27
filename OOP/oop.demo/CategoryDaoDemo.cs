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
    class CategoryDaoDemo
    {
        public int insertCategoryTest(Category category)
        {
            CategoryDao categoryDao = new CategoryDao();
            var result = categoryDao.insert(category);
            return result;
        }

        public int updateCategoryDaoTest(Category category)
        {
            CategoryDao categoryDao = new CategoryDao();
            var result = categoryDao.update(category);
            return 1;
        }

        public ArrayList findCategoryDaoTest(string name)
        {
            CategoryDao categoryDao = new CategoryDao();
            var result = categoryDao.findAll();
            return result;
        }
        public bool deleteCategoryDaoTest(Category category)
        {
            CategoryDao categoryDao = new CategoryDao();
            var result = categoryDao.delete(category);
            return true;
        }
    }
}
