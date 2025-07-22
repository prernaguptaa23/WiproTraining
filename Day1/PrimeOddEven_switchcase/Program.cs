//Wap to take a choice as input 1 for prime no to check, 2 for odd no to check and 3 for even no to check.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Check Prime");
        Console.WriteLine("2. Check Odd");
        Console.WriteLine("3. Check Even");
        
        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1: // Check Prime
                bool isPrime = true;
                if (num <= 1)
                    isPrime = false;
                else
                {
                    for (int i = 2; i <= num / 2; i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                Console.WriteLine(isPrime ? "It's a Prime Number." : "Not a Prime Number.");
                break;

            case 2: // Check Odd
                Console.WriteLine(num % 2 != 0 ? "It's Odd." : "It's not Odd.");
                break;

            case 3: // Check Even
                Console.WriteLine(num % 2 == 0 ? "It's Even." : "It's not Even.");
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        Console.ReadKey();
    }
}
