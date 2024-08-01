using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int viren = 19;
            // Data types :-  int, float , char , string, bool 


            /*
            Console.WriteLine("Hello World");
            Console.Write("virendra");
            Console.WriteLine(" yadav");
            Console.WriteLine("My age is :-  " + viren);
            Console.WriteLine("virendra");
            */

            //taking Inputs 
            //string str = Console.ReadLine();
            //Console.WriteLine(str);




            //Type Casting double to float 
            // that's why it is type safe languagee

            /*
            int a = 34;
            float b = 34.4f;     // 'f' necessary
            double c = 34.4;      // 'd' not necessary 
            bool isTrue = true;
            char ch = 'a';
            string s = "virenndra yadav";
            Console.WriteLine("a is equal to :- " + a);
            Console.WriteLine("b is equals to :- " + b);
            Console.WriteLine("c is equals to :- " + c);
            Console.WriteLine("bool is equals to :- " + isTrue);
            Console.WriteLine("char is equals to :- " + ch);
            Console.WriteLine("string is equals to :- " + s);
            */


            // Type casting of other data types 
            // 1. implicit type casting 
            // char to int to long to float to double

            /*
            int i = 3;
            float y = i;
            int c = 'a';   // it will store integer value but that is ascii value which is 97;
            Console.WriteLine(i);
            Console.WriteLine(y);
            Console.WriteLine(c);
            */

            // 2. Explicit casting 
            /*
            int a = (int)34.4;
            double x = (double)34.05;

            Console.WriteLine(x);
            Console.WriteLine(a);
            */


            /*
            Console.WriteLine("Eneter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine("How many y you want : ");
            string can = Console.ReadLine();
            Console.WriteLine("You will get 2 more : " + (Convert.ToInt32(can) + 2));// showing sum or interger here "can_vlaue + 2"
            Console.WriteLine("You will get 2 more : " + (Convert.ToInt32(can + 2)));// showing string "can_value2" like this
            */


            // operators in C#

            /* 
             * 1. Arithmatic :-  + , - , / , *
             * 2. Assignment :- += , -= , *= , /= 
             * 3. Logical :- && (AND) , || (OR)
             * 4. Comaparison :-  == , >= ,<= , != 
             */


            /*
            int a = 6;
            int b = 2;

            Console.WriteLine("The value of a + b is: " + (a + b));
            Console.WriteLine("The value of a - b is: " + (a - b));
            Console.WriteLine("The value of a / b is: " + (a / b));
            Console.WriteLine("The value of a * b is: " + (a * b));
            */




            // String interpolation 

            //string name = Console.ReadLine();
            //string candies = Console.ReadLine();
            //Console.WriteLine($"Your Name is {name} and you will get {candies} candies");



            // 2D arrays

            /*
            int[,] matrix = { { 1, 2, 3, 4, 5, }, { 6, 7, 8, 9,10 } };

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine(matrix[i, j]);
                }
            }

            foreach(int i in matrix)
            {
                Console.WriteLine(i);
            }

            */


            /*
            Method1 me = new Method1();
            me.MyMethod("USA");
            me.MyMethod();
            me.MyMethod("Cannda");
            me.MyMethod("America");
            me.MyMethod("Norway");
            */


            //Delegates Class

            //Delegates.Main1();



            //FileStream class :- examples
            /*
             FileStreams.WriteFile();
             FileStreams.ReadFile();
            */

            //Stream and StreamWriter example
            /*
            StreamReaderAndWriterExample.StreamWriterExa();
            StreamReaderAndWriterExample.StreamReaderExa();
            */



            //Serialization
            // 1 . Json Serialization 

            JsonSerializationExample.JsonSerializationUsingSystemTextJson();



            //ExceptionHandling
            /*
            ExceptionHandlingExa.ExceptionExam();
            */


            //Inheritance and polymorphism
            /*
            InheritanceAndPolymorphismExam.Main5();
            */


            //CollectionsExam class 
            /*
            CollectionsExam ce = new CollectionsExam();
            ce.ListExamples();
            ce.HashSetExample();
            ce.SortedSetExample();
            ce.StackExamples();
            ce.QueueExample();
            ce.LinkedListExample();
            ce.DictionaryExample();
            */


            //XMLserialization Class 

           


            




            Console.ReadLine();




        }
    }

    
}
