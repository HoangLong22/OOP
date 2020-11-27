using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.oop.dao
{
    interface IDao
    {
        int insert<T>(T row);
        int update<T>(T row);
        ArrayList findAll();
        bool delete<T>(T row);
    }
}
