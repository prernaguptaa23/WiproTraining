using System; 
class Program
{

    static void Main()
    {
        int noOfStudent = 5;
        string[] studentName = new string[noOfStudent];

        Console.WriteLine("Enter the names of 5 students:");

        for (int i = 0; i < noOfStudent; i++)
        {
            Console.WriteLine("Enter the name of student "+ (i+1) + " : ");
            studentName[i] = Console.ReadLine();
        }

        Console.WriteLine("Student Data:");
        
        for (int i = 0; i < noOfStudent; i++)
        {
            Console.WriteLine("The " + (i + 1) + " student name is :" + studentName[i]);

        }


    }


}