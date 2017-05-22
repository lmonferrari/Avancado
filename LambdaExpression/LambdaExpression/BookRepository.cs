using System.Collections.Generic;

namespace LambdaExpression
{
    class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
           {
               new Book() {Title = "Title 1", Price = 5},
               new Book() {Title = "Title 2", Price = 10},
               new Book() {Title = "Title 3", Price = 50},
               new Book() {Title = "Title 4", Price = 599},
               new Book() {Title = "Title 5", Price = 7}
           };
        }
    }
}
