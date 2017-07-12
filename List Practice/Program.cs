using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<int> favNumbers = new List<int>();
            //favNumbers.Add(7);
            //favNumbers.Add(25);
            //favNumbers.Add(30);

            //foreach(int number in favNumbers)
            //{
            //    Console.WriteLine(number);                
            //}
            //Console.WriteLine("There are " + favNumbers.Count + "numbers in the list");

            //List<string> books = new List<string>() {"Cat in the Hat", "Toad and Frog", "Green eggs and ham" };

            //Console.WriteLine(books[0]);
            //books.Insert(0, "Horton hears a Who");
            //Console.WriteLine(books[0]);

            //Create a List and add 5 animlas using the .Add() Print each animal in the list
            //Complete!

            //List<string> animals = new List<string>();
            //animals.Add("cat");
            //animals.Add("Axolotle");
            //animals.Add("snake");
            //animals.Add("rat");
            //animals.Add("lion");

            //for(int i = 0; i < animals.Count; i++)
            //{
            //    Console.WriteLine(animals[i]);
            //}            

            //Create the following list:
            //A bool list {true,false,false,true,false}
            //Loop throug each value
            //If the value is true print "Better bring an umbrella"
            //If the value is false print "No rain today, enjoy the sun!"
            //Complete!

            //List<bool> rainCheck = new List<bool> { true, false, false, true, false};                                   

            //foreach (bool check in rainCheck)
            //{
            //    if (check == true)
            //    {
            //        Console.WriteLine("Better bring an umbrella");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No rain, enjoy the sun!");
            //    }
            //}

            //How to check a list, to see if something is in it. I can type in a word and it searches for it in the list.

            List<string> faveFoods = new List<string> {"Steak", "Fish", "Katsudon", "Icecream", "Nachos" };

            if(faveFoods.Contains("Fish") == true)
            {
                Console.WriteLine("I like fish too!");
            }

        }
    }
}
