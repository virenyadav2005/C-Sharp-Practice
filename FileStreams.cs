using System.IO;
using System;

namespace ConsoleApp1
{
    internal class FileStreams
    {
        public static void WriteFile()
        {
            FileStream f = new FileStream("b.txt", FileMode.Open);
            for (int i = 65; i <= 90; i++)
            {
                f.WriteByte((byte)i);
            }
            f.Close();

            Console.WriteLine("File created successfully and data has writtern successfully in file ");
        }

        public static void ReadFile()
        {
            FileStream f = new FileStream("b.txt", FileMode.Open);

            int i = 0;
            Console.Write("File Data is :- ");
            while((i = f.ReadByte()) != -1)
            {
                Console.Write((char)i);
            }
            f.Close();

            Console.WriteLine("\nFile open successfully and data has read successfully from file ");


        }
    }
}
