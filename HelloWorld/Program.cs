using System;
using HouseFuction;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            House Oisin = new House();

            Oisin.MiceName = "Stewart";

            Oisin.Owner = "Oisin";

            Console.WriteLine(Oisin.MiceName);

            Console.WriteLine(Oisin.Owner);

            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you are " + age + " years old");
        }
    }
}
