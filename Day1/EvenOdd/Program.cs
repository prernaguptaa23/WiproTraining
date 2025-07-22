using System;

class Program2
{
    public static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Enter a number to check if it is odd or even:");
        number = Convert.ToInt32(Console.ReadLine());

        if (number%2==0)
        {
            Console.WriteLine($"{number} is Even.");
        }
        else
        {
            Console.WriteLine($"{number} is Odd.");
        }

        Console.ReadKey();
    }
}
