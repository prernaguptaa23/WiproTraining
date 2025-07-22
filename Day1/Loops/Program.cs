using System;

class LoopProgram
{
    static void Main()
    {
        // For loop
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine("The value of i is :" + i);
        }

        // While loop
        int x = 0;
        while (x < 5)
        {
            Console.WriteLine("The value of x is :" + x);
            x++;
        }

        // Do-while loop
        int y = 5;
        do
        {
            Console.WriteLine("Even if condition is fail the program will execute once");
            y++;
        }
        while (y < 1);

        // Foreach loop with array
        string[] names = { "Niti", "Jatin", "Preeti" };
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
