using System.Numerics;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Basics_Session02
{
    internal class Program
    {
        class Book
        {
            public string Title { get; set; }
            public int Pages { get; set; }

            public override string ToString()
            {
                return $"Book: {Title}, Pages: {Pages}";
            }
            public override bool Equals(object? obj)
            {
                Book other = (Book)obj;
                return Title == other.Title && Pages == other.Pages ? true : false;
            }
        }
        static void Main(string[] args)
        {
            // q1
            //object obj01 = { Title = "C#", Pages = 464 };
            //Console.WriteLine(obj01);
            // /*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/
            // q2
            //Book b1 = new Book { Title = "C#", Pages = 464 };
            //Book b2 = new Book { Title = "Java", Pages = 300 };
            //Console.WriteLine(b1.ToString());
            //Console.WriteLine(b1.Equals(b1));
            //Console.WriteLine(b2.GetHashCode());
            //Console.WriteLine(b2.GetType());

            // /*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*

            //q3

            // int pages = "464";
            // Compile-time error
            //bool Flag = int.TryParse("464", out int pages);
            // or 
            //int pages = 464;

            // /*/*/*/*/*/*//*/*/*/*/*/*/*/*/*/*/*/*/*

            //q4
            //try
            //{
            //    int num = 10;
            //    int result = num / 0;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done.");
            //}

            // /*/*/*/*//*/*/*//*/*/*/*/*/*/*/*/*/*/*//*

            // Q5
            //int pages = 300;
            //double N;
            //N= pages ;
            // /*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/

            // Q6
            //double price = 49.99;
            //int N;
            //N = (int)price;

            // /*//*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/

            // q7
            //string pagesText = "464";
            //int n = Convert.ToInt32(pagesText);
            //Console.WriteLine(n);

            // /*/*/*//*/*/**/*/*/*/*/*//*/*/*/*/*/*

            // q8
            //string yearText = "2023";
            //string badText = "abc";
            //int yearTextParse = int.Parse(yearText);
            //bool badTextParse = int.TryParse(badText, out int badTextValue) ;
            //Console.WriteLine(yearTextParse);
            //Console.WriteLine( badTextParse ? badTextValue : "Invalid number");

            // /*/*/*/*/*/*//*/*/*/*/*/*

            // q9
            //int pages = 464;
            //string pagesText = pages.ToString();
            //Console.WriteLine(pagesText.GetType());

            // /*/*/*//*/*/*/*/*/*//*/*/*/*/*/*/*/*/*

            //// q10
            //int copies = 100;
            //object obj01 = copies; // boxing
            //Console.WriteLine(obj01);
            //int copiesValue = (int)obj01; // unboxingx
            //Console.WriteLine(copiesValue);
        }


    }
}   
