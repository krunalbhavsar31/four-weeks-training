using System;

namespace LinqListNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of integers
            List<int> numbers = new List<int> { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

            // Use LINQ to perform the following operations:
            // 1. Find all even numbers
            // 2. Find all numbers greater than a specific value (e.g., 20)
            // 3. Calculate the sum of all numbers
            // 4. Calculate the average of all numbers
            // 5. Find the minimum and maximum values in the list

            // Find all even numbers
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            foreach (var num in evenNumbers)
            {
                Console.WriteLine($"{num} is even number");
            }

            // Find all numbers greater than a specific value (e.g., 20)
            var greaterThan20 = numbers.Where(n => n > 20);
            foreach (var num in greaterThan20)
            {
                Console.WriteLine($"{num} is greater than 20");
            }

            // Calculate the sum of all numbers
            var sum = numbers.Sum();
            Console.WriteLine($"{sum} the sum of all numbers");

            // Calculate the average of all numbers
            var average = numbers.Average();
            Console.WriteLine($"{average} the average of all numbers");

            // Find the minimum values in the list
            var min = numbers.Min();
            Console.WriteLine($"{min} the minimum values in the list");

            // Find the maximum values in the list
            var max = numbers.Max();
            Console.WriteLine($"{max} the maximum values in the list");

            // Ascending values from the list
            var ascendingOrder = numbers.OrderBy(n => n);
            foreach (var numAsc in ascendingOrder)
            {
                Console.WriteLine($"{numAsc} the ascending values in the list");
            }

            // Descending values from the list
            var descendingOrder = numbers.OrderByDescending(n => n);
            foreach (var numDsc in descendingOrder)
            {
                Console.WriteLine($"{numDsc} the descending values in the list");
            }
           
        }
    }
}