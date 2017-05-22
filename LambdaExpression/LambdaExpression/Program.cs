using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            //number => number * number;
            Func<int, int> square = number => number * number;
            Console.WriteLine(square(5));

            Func<int, int> add = number => number + 10;
            Console.WriteLine(add(1));

            //example with books
            var books = new BookRepository().GetBooks();;
            books.FindAll(b => b.Price < 20);
        }
    }
}
