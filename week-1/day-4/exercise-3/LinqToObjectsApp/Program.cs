using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;

namespace LinqToObjectsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "John", Age = 25, Country = "USA" },
                new Person { Name = "Jane", Age = 30, Country = "Canada" },
                new Person { Name = "Mark", Age = 28, Country = "USA" },
                new Person { Name = "Emily", Age = 22, Country = "Australia" }
            };


            //Write queries using LINQ for following operations
            //1. Get all people from USA
            //2. Get all people above 30
            //3. Sort people by name
            //4. Project/Select only Name and Country of all people


            // Get all people from USA
            IEnumerable<string> namesOfPeopleFromUsa =
            from person in people
            where person.Country == "USA"
            select person.Name;

            foreach (string name in namesOfPeopleFromUsa)
            {
                //Console.WriteLine(name);
                Console.WriteLine($"{name} is from the USA.");
            }

            // Get all people above 30
            IEnumerable<string> namesOfPeopleOver30 =
            from person in people
            where person.Age > 30
            select person.Name;

            foreach (string name in namesOfPeopleOver30)
            {
                //Console.WriteLine(name);
                Console.WriteLine($"{name} is {name.Age} years old.");
            }

            // Sort people by name
            IEnumerable<Person> sortedPeopleByName =
            from person in people
            orderby person.Name ascending
            select person;

            foreach (Person p in sortedPeopleByName)
            {
                //Console.WriteLine(p);
                Console.WriteLine($"{p.Name} is from {p.Country} and is {p.Age} years old.");
            }

            // Project/Select only Name and Country of all people
            IEnumerable<object> projectedPeople =
            from person in people
            select new { Name = person.Name, Country = person.Country };

            foreach (var p in projectedPeople)
            {
                Console.WriteLine($"Name: {p.Name}, Country: {p.Country}");
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
    }
}