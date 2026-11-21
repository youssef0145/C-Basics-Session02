using System.Drawing;
using System.Dynamic;

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


            #endregion
        }
    }
}
