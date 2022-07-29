using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        //function baanaya h mene ye
        static void Greet()
            {
                Console.WriteLine("new function");
            }

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
            //if-else Stamements for checking conditions
            Console.WriteLine("---if-else Stamements--------");
            int sameer=21;
            if(sameer<1||2==2){ 
            Console.WriteLine("you are born");
            }
            else if (sameer>18||2!=2){
            Console.WriteLine("you are adult");
            }
            else
            {
            Console.WriteLine("you are child");
            }


            //Switch Staments for checking conditions
            Console.WriteLine("---Switch Staments---");

            int swt=20;
            switch (swt)
            {
                case 18:
                    Console.WriteLine("please wait");
                    break;
                case 19:
                    Console.WriteLine("you are 19");
                    break;
                default:
                    Console.WriteLine("Enjoy");
                    break;
            }


Console.WriteLine("------------------------lOOPS----------------------------------");
            //Loops
            //execution speed sb ki brabar ha


            //1. While loop
            //pehle condition chk krega phr iteration krega
            //or while tbh chalega jb condition true hogi warna nh chalega

            Console.WriteLine("---While---");
            int v=0;
            while (v < 10)
            {
                Console.WriteLine(v);
                v++;
            }

            //2.Do While loop
            //pehle iteration krega phr condition chk krega
            //ye kam s kam ek bar chalta h

            Console.WriteLine("---Do While---");
            int dio= 0;
            do{
                Console.WriteLine(dio+1);
                dio++;
            } while(dio<5);


            //3. For loop
            
            Console.WriteLine("---For---");
            for(int fo=0; fo<10; fo++)
            {
                Console.WriteLine(fo);
            }

            //Break and Continue
            
            //break: Leave this loop forever.
            //break mtlb tordo or agar ye kisi loop m, laga hoga to us loop ki iteration chalegi
            //or jesiii break ayega tw loop break hojaega khtm hojaega
            
            Console.WriteLine("---Break in loop---");
            for(int foo=0; foo<10; foo++)
            {
                Console.WriteLine(foo);
                break;
            }


            //Continue
            //Continue: Leave this particular iteration of the loop.
            //Continue mtlb mere ni9che jo bh h usse ignore kro or new iteration chalao

            Console.WriteLine("---Continue in loop---");
            for(int fto=0; fto<10; fto++)
            {
                if (fto == 0)
                {
                    continue;
                }
                Console.WriteLine(fto);
            }

Console.WriteLine("------------------------Methods/Function--------------------------------------");
            //Mehtods means Function or hum function q banate h??
            //har hume jaga jaga same same kam krna h tw hum erepeat nh krna parega simple uska func bana k use krlege 

            Console.WriteLine("---Function---");
            //make on line 11 and call here
            Greet();
            

Console.WriteLine("------------------------Practice Sets--------------------------------------");
            //fabionacci series using while loop

            //while loop for for decision making loop first you have condition then iterate
           
            Console.WriteLine("---fabionacci series---");
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



            


            //Even No using if else statements
            //using if else statement
            Console.WriteLine("---Even No.---");
            int even=10045;
            if(even%2==0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }


            //specified operations
            Console.WriteLine("---specified operations---");
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);



            //swap two numbers
            Console.WriteLine("---swap two numbers---");
            int xxx=2;
            int yyy=5;
            int swap=xxx;
             xxx=yyy;
             yyy=swap;
            Console.WriteLine(xxx);
            Console.WriteLine(yyy);


            //multiplication of three numbers
            Console.WriteLine("---multiplication of three numbers--------");
            int mul1=3;
            int mul2=5;
            int mul3=8;
            Console.WriteLine(mul1*mul2*mul3);
            Console.WriteLine((mul1+mul2)*mul3);
            Console.WriteLine(mul1*mul2+mul3*mul2);



            //Table of 2 using foor loop
            Console.WriteLine("---Table of 2--------");
            int num=10;
            int table=4;
            for (int i=1;i<=num;i++){
                Console.WriteLine(table*i);
            }



            //age elder or smaller
            Console.WriteLine("---age elder or smaller--------");
            int agee=19;
            if (agee > 20){
            Console.WriteLine("You look older than 20");
            }
            else
            {
            Console.WriteLine("You look smaller rhan 20");

            }
            







            //swap two numbers
            Console.WriteLine("---swap two numbers--------");
            //Read to commandline 
            Console.ReadLine();
        }
    }
}
