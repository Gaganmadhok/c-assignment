using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;

namespace c__project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //write a simple C# program that prints "Hello , World!" to the console
            /* Console.WriteLine("Hello ,World!");*/


            //write a C# program that prints your name and the current date and time
            /*string name = "gagan";
            Console.WriteLine(name);*/


            //write a C# program that declares an interger varibale, assigns it  a value , and print it 
            /* int num = 21;
             Console.WriteLine(num);
             Console.ReadLine();*/

            //writte a C# program that ouputs "Welcome to C# programming!" and "This is an example of output in C#".
            /*Console.WriteLine("Welcome to C# programming!");
            Console.WriteLine("This is an example of output in C#");
            Console.ReadLine();*/

            //Add both single-line and multi-line comments to the following code:
            //Console.WriteLine("This will run.");
            /*Console.WriteLine("This will not run.");*/

            //Declare variables of different data types and print their values.
            /*string Firstname = "Gagan";
            Console.WriteLine(Firstname);
            int number = 10;
            Console.WriteLine(number);
            bool value = true;
            Console.WriteLine(value);
            double dotnumber = 21.10;
            Console.WriteLine(dotnumber);
            char vowel = 'a';
            Console.WriteLine(vowel);
            Console.ReadLine();*/

            //Write  a C# program that demonstrates different data types and their inialization.
            /*string veggi = "potato";
            int n = 2;
            bool value2 = false;
            char consonant = 'b';
            double doublenum = 10.99;
            Console.WriteLine("String : " + veggi);
            Console.WriteLine("Int : " + n);
            Console.WriteLine("Boolean : " + value2);
            Console.WriteLine("char : " + consonant);
            Console.WriteLine("double : " + doublenum);
            
*/
            //Demonstrate implicit and explicit type casting in C#
            // implicit casting :-

            /*char letter = 'A';
            int a = letter;
            Console.WriteLine(letter);
            Console.WriteLine(a);
            
            int b = 948;
            long lnum = b;
            Console.WriteLine(b);
            Console.WriteLine(lnum);
            Console.ReadLine();

            long lc = 12367l;
            float fnum = lc;
            Console.WriteLine(lc);
            Console.WriteLine(fnum);
            Console.ReadLine();

            float fc = 23.456f;
            double dnum = fc;
            Console.WriteLine(fc);
            Console.WriteLine(dnum);
            Console.ReadLine();

            Char ca = 'a';
            double db = ca;
            Console.WriteLine(ca);
            Console.WriteLine(db);
            Console.ReadLine();*/

            //explicit casting 
            /* double da = 2324.45654d;
             float fa = (float) da;
             Console.WriteLine(da);
             Console.WriteLine(fa);
             Console.ReadLine();

             float fb = 2324.45f;
             long la = (long) fb;
             Console.WriteLine(fb);
             Console.WriteLine(la);
             Console.ReadLine();*/

            /*long lb = 32325;
            int ia = (int)lb;
            Console.WriteLine(lb);
            Console.WriteLine(ia);
            Console.ReadLine();*/

            /* int ib = 345;
             char cb = (char)ib;
             Console.WriteLine(ib);
             Console.WriteLine(cb);
             Console.ReadLine();*/

            //Write  a C# program that takes user input for their name and age and print it

            /*Console.WriteLine("what your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);*/

            /*Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age);*/

            //Write a C# program to demonstrate the use of arithmetic operators

            /*  int sum = 2;
              int sum2 = 4;

              Console.WriteLine(sum + sum2);
              Console.WriteLine(sum * sum2);
              Console.WriteLine(sum2 % sum);
              Console.WriteLine(sum2 / sum);
              Console.WriteLine(sum - sum2);
              sum++;
              Console.WriteLine(sum++);
              sum--;
              Console.WriteLine(sum2--);*/

            //write a C# program to demonstrate the use of the Math class

            /*Console.WriteLine(Math.Max(7, 8));
            Console.WriteLine(Math.Min(98, 3304));
            Console.WriteLine(Math.Sqrt(89));
            Console.WriteLine(Math.Abs(-9.8));
            Console.WriteLine(Math.Round(98.50));*/

            //Write a C# program to demonstrate string concatenation and string methods

            /* string fname = "gagan";
             string lname = "madhok";

             Console.WriteLine(fname + " " + lname);*/

            /*string firstname = "Raman";
            string lastname = "madhok";
            Console.WriteLine(String.Concat(firstname,  lastname));*/

            //string method:-
            /*string name = "gagan madhok";
            Console.WriteLine("length of string =  " +  name.Length);*/

          /*  string name = "gagan";
            Console.WriteLine(name.ToUpper()); uppercase
            Console.WriteLine(name.ToLower()); lowercase*/


            //write a c# program that demonstrate the use of boolean variable

            /*int sum = 10;
            int sum3 = 90;

            Console.WriteLine(sum > sum3);*/

            //write a C# program that uses if..else statements to check if number is positive , negative or zero
            /*int num = 1;

            if(num > 0)
            {
                Console.WriteLine("Number is positive");
            }else if(num == 0){
                Console.WriteLine("Number is zero");
            }else
            {
                Console.WriteLine("number is negative");
            }*/

            //wrtie  a c# program that uses a switch statement to print the day of the week based on a number input(1-7)
            /*int day = 3;
             switch (day)
            {
                case 1:
                    Console.WriteLine("monday");
                break;
                case 2:
                    Console.WriteLine("tuesday");
                break;
                case 3:
                    Console.WriteLine("wednesday");
                break;
                case 4:
                    Console.WriteLine("thursday");
                break;
                case 5:
                    Console.WriteLine("friday");
                break;
                case 6:
                    Console.WriteLine("saturday");
                break;
                case 7:
                    Console.WriteLine("sunday");
                break;
            }*/
            // write a C# program that uses a prints numbers from 1 to 10 using a while loop 

            /*int num = 1;
            while(num <= 10)
            {
                Console.WriteLine(num);
                num++;
            }*/

            //write a c# program that prints the first 10 even numbers using a for loop

            /*for(int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }*/

            //write a c# program that demostrate the use of break and continue statement in a loop

            //break :- 
            /*int n = 1;
            while (n <= 10)
            {
                Console.WriteLine(n);
                n++;
                if(n == 3)
                {
                    break;
                }
            }*/

            //continue 
            /* for(int i = 0; i <= 10; i++)
             {
                if(i == 5)
                 {
                     continue;
                 }
                Console.WriteLine(i);
             }*/

            //write a c# program that declare array of integers , assigns values and print them.
            //Add functionally to find the sum of all element in the array

            /*int[] num = {1,2,3,4,5};
            int sum = 0;
            
            
            for(int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            Console.WriteLine("sum of number : " + sum);*/


            Console.ReadLine();








        }
    }
}
