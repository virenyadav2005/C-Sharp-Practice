using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp1
{
    internal class ExceptionHandlingExa
    {

        internal static void ExceptionExam()
        {
            try
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[5]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of range!");
            }
            finally
            {
                Console.WriteLine("Try-catch block finished.");
            }
        }
    }
}

            