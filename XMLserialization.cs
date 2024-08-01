using System;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    public class RefasArguExample
    {
        public static void show(ref int val)
        {
            val *= val;
            Console.WriteLine(val);
        }
        public static void test()
        {
            int v = 10;

            Console.WriteLine(v);
            show(ref v);
            Console.WriteLine(v);

        }
    }
}