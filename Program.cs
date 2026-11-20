namespace Assignments__1
{

    #region Question 1
    // 1- Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object. Print it.
    internal class Book
    {
        public string Title;
        public int pages;
    }
    class prggram

    {
        static void Main(string[] args)
        {
            //Book book = new Book();
            //book.Title = "C# programing";
            //book.pages = 463;
            //object obj = book;
            //Console.WriteLine(obj);
#endregion

            #region Question 2
            // 2- Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book.

            //Console.WriteLine(book.ToString());
            //Console.WriteLine(book.Equals(book));
            //Console.WriteLine(book.GetHashCode());
            //Console.WriteLine(book.GetType());
            #endregion

            #region Question 3

            // 3- Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.

            //int pages = "464";  //invalid
            int pages = 464;  // valid
          

            #endregion

        }
    }
}
