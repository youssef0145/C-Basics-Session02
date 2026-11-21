namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            // Create a Book class with a Title(string) and Pages(int).
            //Create a Book object and store it in a variable of type object.Print it.
            Book firstbook = new Book {title = "formula one" , pages = 150};
            object obj = firstbook;
            Console.WriteLine(obj);
            #endregion
        }
    }
}
