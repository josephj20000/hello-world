﻿using System;

namespace ConsoleApplication2 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // The first name

            string name = "Jimmy";

            Console.WriteLine("My name is  "+ name);

            // The city's name

            string city = "Petion-Ville";

            Console.WriteLine("I am come from  " +city);

            //Display the date

            DateTime thisDate = new DateTime(2020, 1, 14);

            Console.WriteLine(thisDate.ToString("d"));


        }
    }
}
