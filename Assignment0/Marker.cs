using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment0
{
     public class Marker
    {

        // **if we don't specify an access modifier, by default all the members of the class will be private**
        public string brand = "expo"; //field
        public string color = "black"; //field

        /*below is the private property which is accesible only with in the class
         * If we try to access outside the class we get
         * 'Marker.size' is inaccessible due to its protection level
            The field 'Marker.size is assigned but its value is never used*/
        private int size = 5; //field
                
        //Below are the class Methods
        public void Write() //Method
        {
            Console.WriteLine("Wrote one line");
        }
    }
}
