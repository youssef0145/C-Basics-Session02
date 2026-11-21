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
            int pages = 300;
            double var = pages;
            Console.WriteLine(var);
            #endregion
        }
    }
}
