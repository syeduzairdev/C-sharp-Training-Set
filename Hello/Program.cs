using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //c# type save language

             /* 
              Data types
             */

            int a = 4; //int -----> 4 bytes
            long uzair;//Long -----> 8 bytes
            float b = 0.0F; //float -----> 4 bytes
            double c = 0.1D; //double -----> 8 bytes
            char d = 'a';   //char -----> 2 bytes
            bool e = false; //float -----> 1 bit 
            String f = "uzair"; //String -----> 2 bytes per char

            //Print 
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine("MY First C# code");

Console.WriteLine("--------------------------------------------------------------");
            //take input from user
            Console.WriteLine("Enter your name: " );
            String name=Console.ReadLine();
            Console.WriteLine("my name is: "+name);
            Console.WriteLine("Enter your age: ");
            String age = Console.ReadLine();
            Console.WriteLine("my name is: " + (Convert.ToInt32(age)+4));
           

            Console.WriteLine("--------------------------------------------------------------");

            //Type Casting

            //1. implicit Casting
            // convert by compiler
            //char to int to long to float to double automatic type caste


            //2. Explicit Casting
            // convert by user

            int aa = (int)3.5;  //double convert to int
            Console.WriteLine(aa);


            //Type Casting using other methods in C#
            float bb = Convert.ToInt32(3.55);
            Console.WriteLine(bb);
Console.WriteLine("--------------------------------------------------------------");




            //Read to commandline 
            Console.ReadLine();
        }
    }
}
