using System;

namespace ConsoleApp1
{
    internal class FileStreams
    {

        public static void Main2(string[] args)
        {
            FileStream f = new FileStream("b.txt", FileMode.OpenOrCreate);
            for (int i = 65; i <= 90; i++)
            {
                f.WriteByte((byte)i);
            }
            f.Close();
        }
    }
}
