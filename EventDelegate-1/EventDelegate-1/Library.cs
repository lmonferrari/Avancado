namespace EventDelegate_1
{
    internal class Library
    {
        public Library()
        {
        }
        public void OnBookRent(object source, BookEventArgs e)
        {
            System.Console.WriteLine("Ok! Confirmed! the book {0} was rent", e.Book.Title);
        }
    }

}