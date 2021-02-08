using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment0
{
    public class AndroidPhone : Phone
    {
        public string model { get; set; } //property

        //Bellow are the methods
        public void GoogleAssistant()
        {
            Console.WriteLine("opened googleassistant");
        }

        //overiding the base class method RingTone
        public override void Ringtone()
        {
            Console.WriteLine("The Android phone is ringing : lala lala lalala");
        }

    }
}
