using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment0
{
    //since IosPhone is sealed class, nobody can extend this class.
    //If we try to extend we get the error as " 'Ios1': cannot derive from sealed type 'IosPhone : Phone' "
    sealed class IosPhone : Phone //derived class 
    {
        public string model { get; set; } //property

        //Below are the methods
        public void OpenAppStore()
        {
            Console.WriteLine("App store opened successfully");
        }

        //overiding the base class virtual method RingTone
        public override void Ringtone()
        {
            Console.WriteLine("The Iphone is ringing: Tadantan tadantan");
        }
    }
}

