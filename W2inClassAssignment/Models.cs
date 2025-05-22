
namespace W2inClassAssignment;
using System;

public class Book
{
    public string Title;
    public string Author;
    public int YearPublished;

    public Book(string title, string author, int yearPublished)
    {
        Title = title;
        Author = author;
        YearPublished = yearPublished;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Year Published: {YearPublished}");
    }
}

public class Student
{
    private string name;
    private int grade;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Grade
    {
        get { return grade; }
        set
        {
            if (value >= 0 && value <= 100)
                grade = value;
        }
    }

    public bool IsPassing()
    {
        return grade >= 50;
    }
}

public class Engine
{
    public int HorsePower { get; set; }
}

public class Car
{
    public string Model { get; set; }
    public Engine Engine { get; set; }

    public void Describe()
    {
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Engine Horsepower: {Engine.HorsePower}");
    }
}

public static class StringUtilities
{
    public static int CountVowels(string input)
    {
        int count = 0;
        string vowels = "aeiou";
        foreach (char c in input.ToLower())
        {
            if (vowels.Contains(c))
                count++;
        }
        return count;
    }
}