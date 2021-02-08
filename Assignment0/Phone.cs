using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment0
{
    public class Phone
    {
        public string color { get; set; } //property
        public int spaceinGb { get; set; } //property

        //Below are the methods
        public void SendMessage()
        {
            Console.WriteLine("Message sent succuessfully");
        }
        //creating virtual method for Ringtone in baseclass so that we can override it in derived class
        public virtual void Ringtone()
        {
            Console.WriteLine("The phone is ringing : trin trin ...");
        }
    }
}
