﻿using OOP.oop.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.oop.demo
{
    class CategortDemo
    {
        public Category createCategory(int id, string name)
        {
            Category category = new Category(id, name);
            return category;
        }

        public void printCategory(Category category)
        {
            Console.WriteLine("Category");
            Console.WriteLine("id:" + category.Id);
            Console.WriteLine("name:" + category.Name);
            Console.WriteLine();
        }
    }
}
