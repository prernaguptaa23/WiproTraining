using System;

class Program
{
    static void Main()
    {
        int noOfStudents = 3;

        string[] studentNames = new string[noOfStudents];

        string[][] studentSubjects = new string[noOfStudents][];

        for (int i = 0; i < noOfStudents; i++)
        {
            Console.Write("Enter name of student {0}: ", i + 1);
            studentNames[i] = Console.ReadLine();

            Console.Write("Enter number of subjects for {0}: ", studentNames[i]);
            int subjectCount = Convert.ToInt32(Console.ReadLine());

            studentSubjects[i] = new string[subjectCount];

            for (int j = 0; j < subjectCount; j++)
            {
                Console.Write("Enter subject {0} for {1}: ", j + 1, studentNames[i]);
                studentSubjects[i][j] = Console.ReadLine();
            }

            Console.WriteLine();
        }


        //Display data
        Console.WriteLine("Student Subject Details:\n");

        for (int i = 0; i < noOfStudents; i++)
        {
            Console.WriteLine("Student {0}: {1}", i + 1, studentNames[i]);

            if (studentSubjects[i].Length == 0)
            {
                Console.WriteLine("  No subjects taken.");
            }
            else
            {
                for (int j = 0; j < studentSubjects[i].Length; j++)
                {
                    Console.WriteLine("  Subject {0}: {1}", j + 1, studentSubjects[i][j]);
                }
            }

            Console.WriteLine();
        }
    }
}
