using System;
class Person
{
    public void Eat()
    {
        Console.WriteLine("The person is eating.");
    }
}

class Student : Person
{
    public void Study()
    {
        Console.WriteLine("The student is studying.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.Eat();
        student.Study();
    }
}
