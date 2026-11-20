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
            Book book = new Book();
            book.Title = "C# programing";
            book.pages = 463;
            object obj = book;
            Console.WriteLine(obj); 
    #endregion


        }
    }
}
