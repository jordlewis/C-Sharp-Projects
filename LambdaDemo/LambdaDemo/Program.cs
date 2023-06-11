using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // This creates a new list name 'employees'
            List<Employee> employees = new List<Employee>();

            // This adds 10 employees to the list 'employees'
            employees.Add(new Employee { Id = 1, FirstName = "Joe", LastName = "Dirt" });
            employees.Add(new Employee { Id = 2, FirstName = "Mickey", LastName = "Mouse" });
            employees.Add(new Employee { Id = 3, FirstName = "Bruce", LastName = "Banner" });
            employees.Add(new Employee { Id = 4, FirstName = "Patrick", LastName = "Starr" });
            employees.Add(new Employee { Id = 5, FirstName = "Anakin", LastName = "Skywalker" });
            employees.Add(new Employee { Id = 6, FirstName = "Joe", LastName = "Schmo" });
            employees.Add(new Employee { Id = 7, FirstName = "Han", LastName = "Solo" });
            employees.Add(new Employee { Id = 8, FirstName = "Boba", LastName = "Fett" });
            employees.Add(new Employee { Id = 9, FirstName = "Mace", LastName = "Windu" });
            employees.Add(new Employee { Id = 10, FirstName = "Joe", LastName = "Snuff" });

            // This creates a new list with employees who's first name is 'Joe' using a lambda expression
            List<Employee> onlyJoes = employees.Where(x => x.FirstName == "Joe").ToList();
            // This creates a new list with the employees who's Id is greateer than 5 using a lambda expressin
            List<Employee> greatId5 = employees.Where(y => y.Id > 5).ToList();

            // This prints each item in the onlyJoes list
            foreach (var joe in onlyJoes)
            {
                Console.WriteLine(joe.FirstName + " " + joe.LastName);
            }
            // This print each item in the greatIds list
            foreach (var greatId in greatId5)
            {
                Console.WriteLine("\n" + greatId.FirstName + " " + greatId.LastName);
            }


            Console.ReadLine();
        }

    }
}
