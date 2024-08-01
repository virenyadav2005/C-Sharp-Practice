using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class CollectionsExam
    {
        public void ListExamples()
        {
            var names = new List<string>();
            // also initialize like this
            /*
             var names1 = new List<string>() {"viren","Dhiru","Abhi"};
            */

            names.Add("viren");
            names.Add("dhiren");
            names.Add("raj");
            names.Add("yadav");


            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }


        public void HashSetExample()
        {
            var marks = new HashSet<int>();
            marks.Add(30);
            marks.Add(50);
            marks.Add(60);
            marks.Add(100);
            marks.Add(30);  // Duplicate value and HashSet only have Distinct value

            foreach (var mark in marks)
            {
                Console.WriteLine(mark);
            }
        }


        public void SortedSetExample()
        {
            Console.Write("Enter N:- ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            SortedSet<int> numbers = new SortedSet<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }


            foreach (var i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }

        public void StackExamples()
        {
            Console.Write("Enter Stack Size:- ");
            int size = Convert.ToInt32(Console.ReadLine());

            Stack<string> city = new Stack<string>();

            for (int i = 0; i < size; i++)
            {
                city.Push(Console.ReadLine());
            }
            Console.WriteLine("\nPeek value or the top value in stack is :- " + city.Peek());
            Console.WriteLine("Popped items :- " + city.Pop());
            Console.WriteLine("Next top value or name :- " + city.Peek());

        }


        public void QueueExample()
        {
            Console.Write("Queue Example:- ");
            var district = new Queue<string>();
            district.Enqueue("ajmer");
            district.Enqueue("alwar");
            district.Enqueue("jaipur");


            foreach (var i in district)
            {
                Console.Write(i + " ");
            }

        }

        public void LinkedListExample()
        {
            Console.WriteLine("Linked List Example: ");
            LinkedList<string> subject = new LinkedList<string>();

            subject.AddLast("Math's");
            subject.AddLast("Checmistry");
            subject.AddLast("Physics");
            subject.AddFirst("Hindi");


            Console.Write("Subjects List:- ");
            foreach (var i in subject)
            {
                Console.WriteLine(i);
            }


            Console.Write("\nDo you want to add new Subject Enter true/false :- ");
            bool res = Convert.ToBoolean(Console.ReadLine());


            if (res)
            {
                Console.Write("\nEnter New Subject name :- ");
                string newSubject = Console.ReadLine();

                Console.Write("\nEnter subject after which you wannt to add new Subject ");
                string oldSubject = Console.ReadLine();

                LinkedListNode<string> Node = subject.Find(oldSubject);
                subject.AddAfter(Node, newSubject);

                Console.WriteLine("New Subject Added Successfully..");
                Console.WriteLine("\n");

                Console.WriteLine("Subject List :- ");
                Console.WriteLine("\n");
                foreach (var i in subject)
                {
                    Console.WriteLine(i);
                }

            }
            else
            {
                Console.WriteLine("Ok");
            }


        }


        public void DictionaryExample()
        {
            Console.WriteLine("Dictionary Example:- ");
            Dictionary<int, string> districts = new Dictionary<int, string>();

            Console.WriteLine("Do you want to Add Districts name with the ranking , Enter \"yes\" or \"No\":- ");
            string yesOrNo = Console.ReadLine();
            if (yesOrNo == "yes")
            {
                Console.Write("Enter how many districts you want to give ranking:- ");
                int n = Convert.ToInt32(Console.ReadLine());
                while ( n > 0)
                {
                    Console.WriteLine("Enter Districts name and ranking according to you :- ");
                    string distName = Console.ReadLine();
                    int ranking = Convert.ToInt32(Console.ReadLine());


                    districts.Add(ranking, distName);
                    n--;
                }

                Console.WriteLine("Districts and Rankings are added successfully....");

                Console.WriteLine("Your Dictionary is looking like this:- ");
                foreach (KeyValuePair<int, string> kvp in districts)
                {
                    Console.WriteLine("Ranking:- " + kvp.Key + "," + " District name:- " + kvp.Value);
                }

            }
            else
            {
                Console.WriteLine("Dictionary is Empty..");
            }   

            
        }
    }






}