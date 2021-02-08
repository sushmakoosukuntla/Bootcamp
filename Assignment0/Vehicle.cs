using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment0
{
    abstract class Vehicle
    {
        public abstract void VehicleSound(); //this is a abstarct method, we have to overide it compulsory in derived classes

        //methods goes here
        public void Move()
        {
            Console.WriteLine("vehicle is moving: drrrrrrrr");
        }
    }
}
