using System.Runtime.Intrinsics.X86;

namespace LinqFilterAndSort
{
    internal class Program
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }

            public Person(string firstName, string lastName, int age)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
            }
        }

        static void Main(string[] args)
        {
            // Create a list of Person objects
            // Use LINQ to filter and sort the list
            // Print the filtered and sorted list of people to the console

            List<Person> people = new List<Person>
            {
                new Person("John", "Doe", 25),
                new Person("Jane", "Smith", 16),
                new Person("Bob", "Johnson", 42),
                new Person("Emily", "Jones", 18),
                new Person("Michael", "Brown", 56)
            };

            // Use LINQ to filter the list to only include people who are 18 years old or older
            var listOfPerson18 = from person in people
                         where person.Age >= 18
                         select person;

            foreach (var name in listOfPerson18)
            {
                Console.WriteLine($"{name.FirstName} is {name.Age} years old.");
            }


            // Print the filtered and sorted list of people to the console
            var sortedPeople = from person in people
                               where person.Age >= 18
                               orderby person.LastName ascending, person.FirstName ascending
                               select person;

            foreach (var person in sortedPeople)
            {
                Console.WriteLine($"{person.LastName} {person.FirstName}");
            }
        }
    }
}