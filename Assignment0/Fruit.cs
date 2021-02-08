using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment0
{
    class Fruit
    {
        public string color;
        public string name;
        //Below are the contructors
        //constructors can be overloaded
        public Fruit()
        {
            this.color = "Red";
            this.name = "Strawberry";
        }

        public Fruit(string color)
        {
            //takes one parameter to initilize an object
            this.color = color;
        }

        public Fruit(string color, string name):this(color)
        {
            //takes two parameters to initialize an object
            this.name = name;
        }

        //Below are the methods
        public void Eat()
        {
            Console.WriteLine("This fruit is yummy");
        }
    }
}
