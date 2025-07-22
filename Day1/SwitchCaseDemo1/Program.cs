//Wap to take choice as an input from the user to add, delete, view and update the student details. 
using System;

class Program
{
    static void Main()
    {
       

            Console.WriteLine("\n1. Add  2. Delete  3. View  4. Update  5. Exit");

            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());


switch (choice)
{
    case 1:
        Console.Write("Enter name to add: ");
        string name=Console.ReadLine();
        Console.WriteLine("Student added.");
        break;

    case 2:
        Console.Write("Enter name to delete: ");
        
        break;

    case 3:
        
        break;

    case 4:
        
        break;

    case 5:
        break;

    default:
        Console.WriteLine("Invalid choice.");
        break;
}

        }
}