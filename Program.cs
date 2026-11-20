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

            #region Question 4
            // 4- Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.

            try
            {
                int result1 = 0/10;
            }
            catch(DataMisalignedException)
            {
                Console.WriteLine("CannotUnloadAppDomainException divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }

            #endregion
            #region Questin 5
            // 1-Declare an int pages = 300; then store it in a double variable without using a cast.
            int pages1 = 300;
            double result = pages;
            Console.WriteLine(result);
            #endregion

            #region Questin 6
            // 2-Declare a double price = 49.99; then convert it into an int using a cast.
            double price = 49.99;
            int intPrice = (int)price;
            Console.WriteLine(intPrice);

            #endregion

            #region Questin 7
            // 3-Given string pages Text = "464";, convert it into an int using the Convert class.
            string pagesText = "464";
            int pagesInt = Convert.ToInt32(pagesText);
            Console.WriteLine(pagesInt);
            #endregion

            #region Questin 8
            // 4-Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";, use int. TryParse() to safely try converting it, and print "Invalid number" if it fails.

            string yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine(year);

            string badText = "abc";
            if (int.TryParse(badText, out int badNumber))
            {
                Console.WriteLine(badNumber);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
            #endregion

            #region Questin 9
            // 5- Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.
            int pages2 = 464;
            string pagesString = pages2.ToString();
            Console.WriteLine(pagesString);
            Console.WriteLine(pagesString.GetType());
            #endregion

            #region Questin 10
            // 6-Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.
            int copies = 100;
            object obj = copies;
            int newCopies = (int)obj;
            Console.WriteLine(copies);
            Console.WriteLine(newCopies);
            #endregion

            #region Questin 11
            //7-Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its value.
            int? nullableYear = null;
            Console.WriteLine(nullableYear.HasValue);
            nullableYear = 2023;
            Console.WriteLine(nullableYear);

            #endregion

            #region Questin 12
            // 8-Declare a Book? book = null;. Use ?. to safely read book. Title without crashing the program, and print the result.

            string? reviewer = null;
            Console.WriteLine(reviewer == null);


            #endregion

            #region Questin 13
            // 9- Using title from the previous question, use ?? to print "Untitled" if title is null. Then use ??= to assign title the value "Untitled" only if it's still null.
            string? title = null;
            Console.WriteLine(title ??= "Untitle");
            title ??= "Untitle";
            Console.WriteLine(title);





            #endregion

            #region Questin 14
            // 10-Given string? name = "Ahmed"; (you are sure it's not null here), assign it to a non-nullable string confirmedName using the! operator.
            string? name = "Ahmed";
            string confirmedName = name!;
            Console.WriteLine(confirmedName);


        }




            #endregion




    
}
}
