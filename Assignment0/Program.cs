using System;
using System.IO;

namespace Assignment0
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating multiple objects and accessing properties/fields of the object
            var m = new Marker();
            Console.WriteLine("Brand of marker1 is {0}", m.brand);
            Console.WriteLine("color of marker1 is {0}", m.color);

            // creating another object for marker.
            var m2 = new Marker();
            Console.WriteLine("Brand of marker2 is {0}", m2.brand);
            Console.WriteLine("color of marker2 is {0}", m2.color);

            //Calling the Method Write() on Marker
            m.Write(); // It calls the write method on m(object)
            m2.Write(); // It calls the write method on m2(object)
            Console.WriteLine("*********************************************************************");

            //creating a Fruit object and setting the property values here.
            var f = new Fruit();
            f.color = "yellow";
            f.name = "Mango";
            Console.WriteLine("Fruit f name is {0} and color is {1}", f.name, f.color);

            //creating multiple objects for Fruit class
            var s = new Fruit();
            s.color = "Red";
            s.name = "Strawberry";

            var b = new Fruit();
            b.color = "Light Yellow";
            b.name = "Banana";

            Console.WriteLine(s.name);
            Console.WriteLine(b.name);

            //calling a method Eat() on Fruit
            s.Eat(); //It calls the Eat method on s(object)
            b.Eat(); //It calls the Eat method on b(object)
            Console.WriteLine("*********************************************************************");

            //creating multiple objects for Fruit class using contructor
            //calling two params constructor
            var o = new Fruit("Orange", "Orange");
            Console.WriteLine("Fruit O name is {0} and color is {1}", o.name, o.color);

            //calling one param constructor
            var w = new Fruit("Green");
            w.name = "WaterMillon";
            Console.WriteLine("Fruit W name is {0} and color is {1}", w.name, w.color);

            //calling no param constructor
            var s1 = new Fruit();
            Console.WriteLine("Fruit s1 name is {0} and color is {1}", s1.name, s1.color);
            Console.WriteLine("*********************************************************************");

            //creating person object using {get; set;}
            var p = new Person();
            p.Name = "Sushma";
            Console.WriteLine("My name is {0}", p.Name);
            Console.WriteLine("*********************************************************************");

            Console.WriteLine("*****************INHERITANCE***************");
            //creating the object for derived(child) class and calling the method from parent class and derived class
            var i = new IosPhone();
            i.spaceinGb = 256; //this is the property from parent class
            i.model = "Iphone12 ProMax"; //this is the property from derived class
            i.SendMessage(); //this is the method from parent class
            i.OpenAppStore(); //this is the method from derived class
            Console.WriteLine("My iphone model is {0} and space is {1}", i.model, i.spaceinGb);
            Console.WriteLine("*********************************************************************");

            Console.WriteLine("*****************POLYMORPHISM***************");
            Phone p1 = new Phone();
            Phone p2 = new IosPhone();
            Phone p3 = new AndroidPhone();
            
            //Here RingTone is a virtual method, it calls accordingly to the object created.
            p1.Ringtone();
            p2.Ringtone();
            p3.Ringtone();
            Console.WriteLine("*********************************************************************");

            Console.WriteLine("*****************ABSTRACT***************");
            Vehicle c = new Car(); //creating the car object
            c.Move(); //calling the method
            c.VehicleSound(); //calling the abstarct method
            Console.WriteLine("*********************************************************************");

            Console.WriteLine("*****************INTERFACE***************");
            Duck d = new Duck();
            d.Fly(); //Fly() is a abstract method in IBird, implemented in Duck class
            d.AnimalSound(); //AnimalSound() is a abstract method in IAnimal, implemented in Duck class
            Console.WriteLine("*********************************************************************");

            Console.WriteLine("*****************Enums***************");
            Size Size = Size.Medium;
            Console.WriteLine("size is:" + Size);

            //printing the size number, By default the first item of the enum starts with 0 and so on
            int SizeNumber = (int)Size.Medium;
            Console.WriteLine("size is:" + SizeNumber);

            int Size1 = (int)Size.Large;
            Console.WriteLine("size is:" + Size1);

            Console.WriteLine("***********switch statements using enums****************");
            Home myHome = Home.IndependentHouse;
            switch (myHome)
            {
                case Home.Condo:
                    Console.WriteLine("Condomenium");
                    break;
                case Home.TownHouse:
                    Console.WriteLine("Town House");
                    break;
                case Home.IndependentHouse:
                    Console.WriteLine("Independent House");
                    break;
            }

            Console.WriteLine("*********************************************************************");

            Console.WriteLine("*****************Files***************");
            //files provides static methods, where as file info provides instance methods.
            //C:\Users\sushm\OneDrive\Documents
            var path = @"C:\Users\sushm\OneDrive\Documents\udemyText.txt";
            var x = Files.NoOfWordsInTextFile(path);
            Console.WriteLine(x);
            var y = Files.LongestWord(path);
            Console.WriteLine(y);

            //writing the text in a file.
            string write = "The program that reads a text file and displays the number of words.";  // Create a text string
            // Create a file and write the content of writeText to it
            File.WriteAllText(@"C:\Users\sushm\OneDrive\Documents\udemyText.txt", write);

            Console.WriteLine("*********************************************************************");

            Console.WriteLine("*****************Exceptions***************");
            

            //using try catch block
            try
            {
                Exception.CheckPossitive(2);
                Exception.CheckPossitive(-1);
            }
            catch(ArithmeticException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }

        } 
    }
}

