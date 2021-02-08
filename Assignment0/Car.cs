using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment0
{
    class Car : Vehicle
    {
        public override void VehicleSound() //Here we have overided the abstract method vehiclesound() which is in base class
        {
            Console.WriteLine("car sounds as zzzzzzzzzzzzzzz");
        }
    }
}
