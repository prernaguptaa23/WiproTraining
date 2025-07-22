using System;
using System.Text;

class Program
{
    static void Main()
    {
        // STRING (Immutable)
        string s = "Hello";
        s += " World"; // A new string object is created
        Console.WriteLine("String: " + s);

        // STRINGBUILDER (Mutable)
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < 10; i++)
        {
            sb.Append(i); // Adds number to the same object
        }

        string result = sb.ToString(); // Convert StringBuilder to string
        Console.WriteLine("StringBuilder: " + result);
    }
}
