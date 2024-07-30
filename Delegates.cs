
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Delegates;

namespace ConsoleApp1
{
    internal class Delegates
    {
        public delegate void VoidDelegates();                       // normal delegates
        public delegate void VoidDelegateWithParam(string msg);    // delegate with parameter
        public delegate int CalculateDelegate(int a, int b);      // return type delegate

        public delegate void AnnoymousDelegetes(string msg);
        public delegate void DelegateWithLambdaExp(string msg);


        public static void Main1()
        {
            // Delegates are without parameters


                    VoidDelegates del = print; // creating the instance or 'refrence' of 'VoidDelegates' as 'del' and then assign a print 'method' in it 
                    del += print2;                   // can call multiple method using the delegates like this 
                    myClass.ExecuteDelegates(del);   // executing the delegate using ExecuteDelegates function in which we are passing the instance or refrence of void Delegates

                    // Delegates with parameters 

                    VoidDelegateWithParam del2 = printWithParam;
                    myClass.ExecuteDelegatesWithParameter(del2);


                    // Delegates with return types
                    CalculateDelegate del3 = Add;
                    myClass.ExecutableDelegatesWithInt(del3);


                    //Annoymous Delegetes
                    AnnoymousDelegetes del4 = delegate (string s)
                    {
                        Console.WriteLine(s);
                    };
                    del4("Annoymous Delegete");


                    DelegateWithLambdaExp del5 = s => { Console.WriteLine(s); };
                    del5("Delegate with Lambda exp");




            //In built Delegates Func:- in which we have 'n' parameters in which n-1 are value or input values and last one is the Return type
            //like if Func have only one then that is the return type and no parameters
            Func<string> func = GetMessage;   //  
            Console.WriteLine(func());



            Func<string, string> func2 = GetMessageWithParam;   // if n total then n-1 parameter or last one is return type
            Console.WriteLine(func2(" Parameter"));


            Func<int, string> func3 = GetIntWithParam;
            Console.WriteLine(func3(5));


            // only difference between Action and Func is that Func is used for return type method
            // and Action only used with void method and pass only parameters

            Action<int> ac1 = GetMessageInt;
            ac1(6);





        }

        private static void GetMessageInt(int num)
        {
            Console.WriteLine("Action delegate with int type parameter whose value is :-  " + num); 
        }

        private static string GetIntWithParam(int num)
        {
            return "Func delegate with int parameter or string return type : " + num;
        }

        private static string GetMessageWithParam(string str)
        {
            return "Func Delegate with " + str;
        }
        public static string GetMessage()
        {
            return "Func Delegate";

        }
        private static int Add(int a, int b)
        {
            return a + b;
        }

        private static int Sub(int a, int b)
        {
            return a - b;
        }
        private static void printWithParam(string msg)
        {
            Console.WriteLine(msg);

        }

        private static void print2()
        {
            Console.WriteLine("Void Delegate1 (multiple) at once");
        }
        private static void print()
        {
            Console.WriteLine("Void Delegate1");

        }
    }

    class myClass
    {
        public static void ExecuteDelegates(VoidDelegates del1)
        {
            del1();
        }

        public static void ExecuteDelegatesWithParameter(VoidDelegateWithParam del2)
        {
            del2("Void delegate with parameters");
        }

        public static void ExecutableDelegatesWithInt(CalculateDelegate del3)
        {
            Console.Write("Delegate with Return type int (a+b) :-  ");
            Console.WriteLine(del3(4, 5));
        }
    }
}
