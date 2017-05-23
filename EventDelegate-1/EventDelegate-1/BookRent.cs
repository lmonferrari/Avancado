using System;
using System.Threading;

namespace EventDelegate_1
{
    internal class BookRent
    {
        // declarando o delegate e evento
        public event EventHandler<BookEventArgs> BookRented;

        public void RentBook(Book book)
        {
            System.Console.WriteLine("{0} was taken!", book.Title);
            Thread.Sleep(3000);
            OnBookRent(book);
        }

        public void OnBookRent(Book book)
        {
            if (BookRented != null)
                BookRented(this, new BookEventArgs() {Book = book});
        }
    }
}