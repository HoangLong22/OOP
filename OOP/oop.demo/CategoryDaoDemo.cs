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
        public bool insertCategoryTest(Category category)
        {
            CategoryDao categoryDao = new CategoryDao();
            var result = categoryDao.insert(category);
            return result;
        }
        public void printCategoryDao(Category category)
        {
            Console.WriteLine("Category Dao");
            Console.WriteLine("id:" + category.Id);
            Console.WriteLine("name:" + category.Name);
            Console.WriteLine();
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
            var result = categoryDao.findAll(name);
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
