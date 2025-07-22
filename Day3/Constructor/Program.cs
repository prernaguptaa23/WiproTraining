using System;

class Employee
{

    public string Name { get; set; }
    public int Age { get; set; }

    public static int Count=0;
    public Employee()
    {
        Count++;
        Console.WriteLine("The value of count is : " + Count);
        Name = "niti";
        Age = 34;
    }
    public Employee(string name, int age)
    {

        Name = name;
        Age = age;

    }


   // static constructor will run only once , not as  per the object 
    // static Employee()
    // {

    //     Count++;
    //     Console.WriteLine("The value of count is : " + Count);
    // }

    public Employee(string name)
    {

        Name = name;


    }

    public void Display()
    {

        Console.WriteLine("Name : " + Name + " Age : " + Age);
    }
    
    }

class Program
{


    static void Main()
    {

        Employee e1 = new Employee();
        Employee e2 = new Employee("Jatin",20);
        Employee e3 = new Employee("Sakshi");

        e1.Display();
        e2.Display();
        e3.Display();
    }
}