using System;

namespace ConsoleApp1
{
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal sound");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Bark");
        }
    }

    internal class InheritanceAndPolymorphismExam
    {
        public static void Main5()
        {
            Animal myAnimal = new Dog();
            myAnimal.Speak();
        }
    }


}

