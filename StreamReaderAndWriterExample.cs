using System.IO;
using System.Security.Policy;
using System;

namespace ConsoleApp1
{
    internal class StreamReaderAndWriterExample
    {
        public static void StreamWriterExa()
        {
            FileStream f = new FileStream("c.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(f);
            
            sw.WriteLine("Hello i am writing a line ");
            sw.Close();
            f.Close();

            Console.WriteLine("File Created Successfully...");
        }

        public static void StreamReaderExa()
        {
            FileStream f = new FileStream("c.txt", FileMode.Open);
            StreamReader sr = new StreamReader(f);
            string str = sr.ReadLine();
            Console.WriteLine(str);

            sr.Close();
            f.Close();
        }
    }
}