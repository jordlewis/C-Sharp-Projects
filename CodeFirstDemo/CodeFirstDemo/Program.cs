using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstDemo;

class Program
{
    static void Main(string[] args)
    {
        // This creates a connection to the database for students
        using var db = new StudentContext();
        // This prompts the user to enter a new student name
        Console.Write("Enter New Student Name: ");
        // This saves the user's input to the variable 'name'
        var name = Console.ReadLine();
        var student = new Student { Id =1, Name = name};
        // This addes the student to the database
        db.Students.Add(student);
        // This saves the changes to the database
        db.SaveChanges();
        Console.Read();

        // This will query all of the entries in the database and order them by 'Name'
        var query = db.Students.OrderBy(s => s.Name);


        Console.WriteLine("All Students:");
        // This is a foreach loop to iterate through and print each student in the database to the console using the query above
        foreach (var item in query)
        {
            Console.WriteLine(item.Name);
        }

        // This prompts the user to hit any key to exit the quit the application
        Console.WriteLine("Hit any key to quit");
        Console.ReadKey();
    }
}


    public class Student
    {
        // This sets the properties for Student objects
        public int Id { get; set; }
        public string Name { get; set; }
    }

    // This declares the DbSet property 'Students'
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
