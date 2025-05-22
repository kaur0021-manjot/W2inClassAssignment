namespace W2inClassAssignment;
using System;


// Program.cs


class Program
{
    static void Main(string[] args)
    {
        // Exercise 1 & 2
        Book book = new Book("The Harry Porter", "J. K. Rowling", 1997);
        book.DisplayInfo();
        Console.WriteLine();

        // Exercise 3 & 4
        Student student = new Student();
        student.Name = "Harsimran Singh";
        student.Grade = 99;
        Console.WriteLine($"{student.Name} is passing: {student.IsPassing()}");
        Console.WriteLine();

        // Exercise 5
        Engine engine = new Engine { HorsePower = 550 };
        Car car = new Car { Model = "Scorpio", Engine = engine };
        car.Describe();
        Console.WriteLine();

        // Exercise 6
        Console.WriteLine($"Vowels in 'Hello World': {StringUtilities.CountVowels("Hello World")}");
        Console.WriteLine($"Vowels in 'Apples ARE awesome': {StringUtilities.CountVowels("Apples ARE awesome")}");
    }
}
