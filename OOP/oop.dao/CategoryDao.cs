﻿using OOP.oop.entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.oop.dao
{
    class CategoryDao:BaseDao,IDao
    {
        public CategoryDao()
        {
            tableName = Database.CATEGORY;
        }
    }
}
