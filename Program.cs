using System.ComponentModel;
using System.Drawing;
using System.Dynamic;
using static System.Net.Mime.MediaTypeNames;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            // Create a Book class with a Title(string) and Pages(int).
            //Create a Book object and store it in a variable of type object.Print it.
            ///Book firstbook = new Book {title = "formula one" , pages = 150};
            ///object obj = firstbook;
            ///Console.WriteLine(obj);
            #endregion

            #region question 2
            //Using the Book class above, print the result of calling ToString(),
            //Equals() (compare book with itself), GetHashCode(), and GetType() on book.
            ///Book secondbook = new Book { title = "formula one", pages = 150 };
            ///Console.WriteLine(secondbook.ToString());
            ///Console.WriteLine(secondbook.Equals(secondbook));
            ///Console.WriteLine(secondbook.GetHashCode());
            ///Console.WriteLine(secondbook.GetType());
            #endregion

            #region question 3
            // Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
            //int pages = "464";
            ///it is a compile-time error
            ///int pages = 464;
            #endregion

            #region question 4
            //Write code that divides 10 by 0 inside a try block, catches the exception,
            //prints "Cannot divide by zero", and then prints "Done" in a finally block.
            ///try
            ///{
            ///    int x = 5;
            ///    int y = 0;
            ///   int test = (x / y);
            ///}
            ///catch (DivideByZeroException)
            ///{
            ///    Console.WriteLine("cannot divide by zero");
            ///}
            ///finally
            ///{
            ///    Console.WriteLine("done");
            ///}
            #endregion

            #region question 5
            //Declare an int pages = 300; then store it in a double variable without using a cast.
            ///int pages = 300;
            ///double var = pages;
            ///Console.WriteLine(var);
            #endregion

            #region question 6
            //  Declare a double price = 49.99; then convert it into an int using a cast.
            ///double price = 49.99;
            ///int castingValue = (int)price;
            ///Console.WriteLine(castingValue);
            #endregion

            #region question 7
            // Given string pagesText = "464";, convert it into an int using the Convert class.
            ///string pagesText = "464";
            ///int No = Convert.ToInt32(pagesText);
            ///Console.WriteLine(No);
            #endregion

            #region question 8
            /// Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";
            ///, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
            ///string yearText = "2023";
            ///int No1 = int.Parse(yearText);
            ///Console.WriteLine(No1);

            ///string badText = "abc";
            ///if (int.TryParse(badText, out int No2))
            ///    Console.WriteLine(No2);
            ///else
            ///    Console.WriteLine("invalid number");
            #endregion

            #region question 9
            //Given int pages = 464;, convert it into a string using ToString()
            //and print its type using GetType() to prove it's now a string.
            ///int pages = 464;
            ///string str = pages.ToString();
            ///Console.WriteLine(str.GetType());
            #endregion

            #region question 10
            // Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.
            ///int copies = 100;
            ///object boxed = copies;
            ///int unboxed = (int)boxed;
            ///Console.WriteLine(boxed);
            ///Console.WriteLine(unboxed);
            #endregion

            #region question 11
            //Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its
            ///int? year = null;
            ///Console.WriteLine(year.HasValue);
            ///year = 2023;
            ///Console.WriteLine(year.Value);
            #endregion

            #region question 12
            //Declare a string? reviewer = null;. Print whether it is null.
            string? reviewer = null;
            Console.WriteLine(reviewer==null);
            #endregion
        }
    }
}
