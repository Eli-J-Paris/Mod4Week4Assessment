using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

public class Person
{
    public string Name { get;  set; }
    public DateTime Birthday { get;  set; }

    public Person(string name, DateTime birthday)
    {
        Name = name;
        Birthday = birthday;
    }

    public string GetBirthday()
    {
        return $"{Name}'s birthday is on {Birthday:MMMM d, yyyy}";
    }

}


public class Student : Person
{
    //public string Name { get; private set; }
    public int Grade { get; private set; }

    //public DateTime Birthday { get; private set; }

    public Student(string name, int grade, DateTime birthday) : base (name, birthday)
    {
       // Name = name;
        Grade = grade;
       // Birthday = birthday;
    }

    public string GetGreeting()
    {
        return $"Hello, I'm {Name}, a student in grade {Grade}!";
    }

    //public string GetBirthday()
    //{
    //    return $"{Name}'s birthday is on {Birthday:MMMM d, yyyy}";
    //}
}

public class Teacher : Person
{
    //public string Name { get; private set; }
   // public DateTime Birthday { get; private set; }
    public string Subject { get; private set; }

    public Teacher(string name, string subject, DateTime birthday) : base(name, birthday)
    {
        Name = name;
        Birthday = birthday;
        Subject = subject;
    }

    public string GetGreeting()
    {
        return $"Hello, I'm {Name}, a {Subject} teacher!";
    }

    //public string GetBirthday()
    //{
    //    return $"{Name}'s birthday is on {Birthday:MMMM d, yyyy}";
    //}
}

// Create a school class that uses dependency injection by taking in a list of people.
public class School 
{ 
    public List<Person> People { get; set; }

    public School(List<Person> people)
    {
        People = people;
    }

    public void ListBirthdays(List<Person> schoolbody )
    {
        foreach(var person in schoolbody)
        {
            Console.WriteLine(person.GetBirthday());
        }
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        //// Your solution should make the following code run without errors!

        //// Step 1:
        //// Creating instances of Student and Teacher
        Student studentAlice = new Student("Alice", 10, new DateTime(2007, 1, 20));
        Student studentEthan = new Student("Ethan", 12, new DateTime(2005, 3, 10));
        Teacher teacherJohnson = new Teacher("Mrs. Johnson", "Math", new DateTime(1980, 12, 10));
       
        //// Creating a list of people
        List<Person> people = new List<Person> { studentAlice, studentEthan, teacherJohnson };

        

        //// Step 2:
        //// Using dependency injection to create a School instance
        School school = new School(people);

        //// List all birthdays
        school.ListBirthdays(people);
    }
}
