using OOP.oop.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.oop.demo
{
    class AccessotionDemo
    {
        public Accessotion createAccessotion(int id, string name)
        {
            Accessotion accessotion = new Accessotion(id, name);
            return accessotion;
        }

        public void printAccessory(Accessotion accessotion)
        {
            Console.WriteLine("Accessory");
            Console.WriteLine("id:" + accessotion.Id);
            Console.WriteLine("name:" + accessotion.Name);
            Console.WriteLine();
        }
    }
}
