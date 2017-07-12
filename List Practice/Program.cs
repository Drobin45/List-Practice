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

            //foreach (int number in favNumbers)
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
            // .Contain() does this!
            //List<string> faveFoods = new List<string> {"Steak", "Fish", "Katsudon", "Icecream", "Nachos" };

            //if(faveFoods.Contains("Fish") == true)
            //{
            //    Console.WriteLine("I like fish too!");
            //}

            //Create a list with the followign numbers: 1, 23, 9, 77, 922, 6, 32, 36, 63, 14, 5.
            //Use the contains method with the following values: 23, 77, 15.
            //Remove these elements: 23, 77, 32 and 6.
            //Use Contains() again on these values: 23, 77, 15.
            //Complete!

            //List<int> numbers = new List<int> { 1, 23, 9, 77, 922, 6, 32, 36, 63, 14, 5 };

            ////A faster way of getting a bool statement of whether a value is or isn't in a list
            ////Console.WriteLine(numbers.Contains(value));

            //if (numbers.Contains(23))
            //{
            //    Console.WriteLine("Yes, it has 23!");
            //}

            //if (numbers.Contains(77))
            //{
            //    Console.WriteLine("Yes, it has 77!");
            //}

            //if (numbers.Contains(15))
            //{
            //    Console.WriteLine("Yes, it has 15!");
            //}

            //numbers.Remove(23);
            //numbers.Remove(77);
            //numbers.Remove(32);
            //numbers.Remove(6);            

            //if (numbers.Contains(23))
            //{
            //    Console.WriteLine("Yes, it has 23!");
            //}

            //if (numbers.Contains(77))
            //{
            //    Console.WriteLine("Yes, it has 77!");
            //}

            //if (numbers.Contains(15))
            //{
            //    Console.WriteLine("Yes, it has 15!");
            //}


            //Aks the user for a movie
            //If the movie is not in the list, add it
            //inform the user that the movie has been added
            //If the movie is in the list, tell them it's on the way.
            //if the user enteres quit the program should exit
            //The user should be able to add as many movies as they want
            //When the user quits show them all of the movies in the list

            string movieSearch;
            Console.WriteLine("Welcome to Generic Movie Ordering Platform! \nPlease enter the movie you would like to order!");
            List<string> movies = new List<string> { "The Matrix", "Captain Awesome", "Transformers", "Up", "Moana" };

            do
            {         
                movieSearch = Console.ReadLine();

                if (movieSearch == "Quit")
                {                   
                    foreach (string mov in movies)
                    {
                        Console.WriteLine(mov);
                    }
                    Environment.Exit(0);
                }

                else if (movies.Contains(movieSearch))
                {
                    Console.WriteLine("Your movie is on it's way. Enjoy!");
                }                

                else if (movies.Contains(movieSearch) != true)
                {
                    movies.Add(movieSearch);
                    Console.WriteLine(movieSearch + " has been added to our list, and will be avialable to order immediately!");                                                        
                }             

            }
            while (movieSearch != "Quit");            

            Console.WriteLine("Enjoy your movie and please come again!");




        }
    }
}
