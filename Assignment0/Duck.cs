using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment0
{
    //A class cannot support multiple Inheritance, It can be achieved through interfaces.
    //A class can implement multiple interfaces
    public class Duck : IAnimal, IBird
    {
        public void AnimalSound()
        {
            Console.WriteLine("Duck says crowwww crowwww");
        }

        public void Fly()
        {
            Console.WriteLine("The duck is flying");
        }
    }
}
