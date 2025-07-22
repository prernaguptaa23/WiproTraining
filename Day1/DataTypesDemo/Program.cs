using System; 

class Program
{
    public static void Main(string[] args)
    {
        // Data types with size:
        // int - 4 bytes, long - 8 bytes, float - 4 bytes
        // double - 8 bytes, bool - 1 byte, char - 2 bytes, string - 2 bytes per character

        int number = 456;
        int a;
        int b;
        string s = "Hello";
        char ch = 'B';
        short num1 = 234;
        long num = 5767;
        double price = 45.00;
        Decimal marks = 45.7M;

        Console.WriteLine($"Value1: {number} second number : {num1}");
        Console.WriteLine("Char : " + ch);
        Console.WriteLine("Equivalent Number : " + (byte)ch); 
        Console.WriteLine("The minimum and maximum value size : " + char.MinValue + " " + char.MaxValue);
        Console.WriteLine("The char size : " + sizeof(char));

        // Taking input
        Console.WriteLine("Enter first number");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sum of 2 numbers : " + (a + b));
        Console.ReadKey();
    }
}
