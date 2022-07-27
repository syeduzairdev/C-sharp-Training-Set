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
            //we use /n for new line 
            //we use /t for one tab space  
            //we use /" for   

            //c# type save language

             /* 
              MultiLine Comments
             */

            
Console.WriteLine("-------------------------Data Types-------------------------------------");
            //Data types
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




Console.WriteLine("-------------------------Printing statements-------------------------------------");
            //take input from user
            Console.WriteLine("Enter your name: " );
            String name=Console.ReadLine();
            Console.WriteLine("my name is: "+name);
            Console.WriteLine("Enter your age: ");
            String age = Console.ReadLine();
            Console.WriteLine("my age is: " + (Convert.ToInt32(age)+4));
            Console.WriteLine($"my name is {name} and age is {(Convert.ToInt32(age)+4)} "); //string interpolation

           


Console.WriteLine("--------------------------Type Casting------------------------------------");
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




Console.WriteLine("------------------------Operators--------------------------------------");
            //Operators in C#
            //1. Arithematic Operators + - * /
            Console.WriteLine("---Arithematic Operators--------");
            int cc=20;
            int dd=10;
            Console.WriteLine("The add is "+(cc+dd));
            Console.WriteLine("The minus is "+(cc-dd));
            Console.WriteLine("The multiply is "+(cc*dd));
            Console.WriteLine("The divide is "+(cc/dd));
            //2. Assignment Operators = += -= *= /=
            int ee=20;
            int ff=ee;
            ee +=4;
            ff-=4;

            Console.WriteLine(ee);
            Console.WriteLine(ff);

            //3. Logical Operators &&(AND) ||(OR) !(NOT)

            //Logical AND If both left and right operands or expressions are true, it will return true. Otherwise, it will return false.
            //If all of them are false, it will return false.
            Console.WriteLine("---Logical Operators--------");
            Console.WriteLine(true && false);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);

            //Logical OR If one of the operands or expressions is true it will return true
            //If all of them are false, it will return false.
            Console.WriteLine(true || false);
            Console.WriteLine(true || true);
            Console.WriteLine(false || false);

            //Logical NOT operator is used to inverse the current decision.
            //Say, if current state is true, Logical NOT (!) operator will make it false.
            Console.WriteLine(!false);
            Console.WriteLine(!true);


            //4. Comparision/Relational Operators == != < <= > >=
            Console.WriteLine("---Comparision Operators--------");
            Console.WriteLine(12==12);
            Console.WriteLine(12!=33);
            Console.WriteLine(12>33);
            Console.WriteLine(12<33);
            Console.WriteLine(12<=33);
            Console.WriteLine(12>=33);




Console.WriteLine("------------------------Math Library--------------------------------------");
            //Math Library in C#
            Console.WriteLine("---Math Library--------");
            int gg =Math.Max(34,355);
            int hh =Math.Min(34,355);
            double ii =Math.Sqrt(16);
            Console.WriteLine(gg);
            Console.WriteLine(hh);
            Console.WriteLine(ii);





 Console.WriteLine("------------------------String Methods--------------------------------------");
            //String Methods
            Console.WriteLine("---String Methods--------");
            String Uzair="My Name is Uzair";
            Console.WriteLine(Uzair.Length);
            Console.WriteLine(Uzair.ToUpper());
            Console.WriteLine(Uzair.ToLower());
            Console.WriteLine(Uzair+"Hassan");  //concatinate 1st method
            Console.WriteLine(String.Concat(Uzair+"Hassan"));   //concatinate 2nd method
            Console.WriteLine(Uzair[0]);
            Console.WriteLine(Uzair.IndexOf("Name"));
            Console.WriteLine(Uzair.Substring(5));
            
            
            
            
Console.WriteLine("------------------------Conditions/Statements/Decision Control--------------------------------------");
            //if-else Stamements
            Console.WriteLine("---if-else Stamements--------");
            int sameer=21;
            if(sameer>18){
                Console.WriteLine("you are adult");
            }
            else
            {
                Console.WriteLine("you are child");
            }








Console.WriteLine("------------------------Practice Sets of fabionacci series--------------------------------------");
            //fabionacci series

            //while loop for for decision making loop first you have condition then iterate

            int aee=0;
            int bee=1;
            int cee=0;
            int count=1;
            int n=10;
            while(count<n){ 
            Console.WriteLine(cee);
            count+=1;
            aee=bee;
            bee=cee;
             cee=aee+bee;
            }






            //Read to commandline 
            Console.ReadLine();
        }
    }
}
