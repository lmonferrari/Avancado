namespace EventDelegate_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book() { Title = "Book 1"};
            var bookRent = new BookRent();
            var library = new Library();

            bookRent.BookRented += library.OnBookRent;

            bookRent.RentBook(book);
        }
    }
}
