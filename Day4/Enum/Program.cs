using System;

namespace StructExample
{
public struct Book
    {
        public string Title;
        public string Author;
        public decimal Price;
        public short Year;


    }
    // It is non-primitive
    enum DaysOfWeek
    {
        Monday,      //0
        Tuesday,     //1
        Wednesday    //2

    }

    enum Status
    {

        Pending,    //0
        Approved,   //1
        Rejected    //2
    }



    class BookStructure
    {

        static void Main(string[] arfs)
        {
            DaysOfWeek t1 = DaysOfWeek.Tuesday;
            Console.WriteLine("Structure Example");

            Book myBook = new Book();

            myBook.Title = "CSharp";
            myBook.Author = "ABC";
            myBook.Price = 4545.00M;
            myBook.Year = 2017;

            Console.WriteLine(myBook.Title + myBook.Author + myBook.Price + myBook.Year);

            if (t1 == DaysOfWeek.Monday || t1 == DaysOfWeek.Tuesday)
            {
                Console.WriteLine("either it is monday or tuesday");
            }

            else { Console.WriteLine("either it is monday or tuesday"); }

            switch (t1)
            {
                case DaysOfWeek.Monday:
                    Console.WriteLine("It's Monday");
                    break;
                case DaysOfWeek.Tuesday:
                    Console.WriteLine("It's Tuesday");
                    break;
                case DaysOfWeek.Wednesday:
                    Console.WriteLine("It's Wednesday");
                    break;
                default:
                    Console.WriteLine("It's Weekend");
                    break;
            }

            Status s = Status.Pending;
            string statusstring = s.ToString();
            Console.WriteLine("Selected Status: " + statusstring);

            Console.WriteLine("\nAll Status values:");
            
            foreach (Status st in Enum.GetValues(typeof(Status)))
            {
                Console.WriteLine(st);
            }
        }

    }   
    
    




}