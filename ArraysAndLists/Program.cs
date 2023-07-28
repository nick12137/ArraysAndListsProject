using System;
using System.Collections.Generic;
namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Create two Lists of type int.
            //Name one List "evens" 
            //Name the other List "odds"

            var evens = new List<int>();
            var odds = new List<int>();


            // Using either a foreach or for loop,
             // nest an if statement to check to see
             // if a number is even or odd.
             //Then add those numbers to either the evens List
             //or the odds List

            //this is how to write a foreach loop
            // the num means what kind, and the numbers is from the top meaning what you are working with
            //foreach(var num in numbers)
            //{
            //    if (num % 2 == 0)
            //    {
            //        evens.Add(num);

            //    }
            //    else
            //    {
            //        odds.Add(num);
            //    }
            //}

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evens.Add(numbers[i]);
                }
                
                    else
                    {
                        odds.Add(numbers[i]);
                    }

                
            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            // after in keyword is where you put the name in the collection
            // temporarily the name will be "item" and can be renamed whenever you want
            
            foreach (var item in evens)
            {
                Console.WriteLine($"{item} is an even number ");

            }
            // cannot reuse the sanem name after var so had to change it.
            foreach (var items in odds)
            {
                Console.WriteLine($"{items} is an odd number ");
            }
        }
    }
}
