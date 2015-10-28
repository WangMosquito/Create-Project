using System.Collections.Generic;
using System.Linq;

namespace ShoppingCartTest
{
    internal class ShoppingCart
    {
        private List<List<Book>> groupBookList;

        public ShoppingCart()
        {         
            groupBookList = new List<List<Book>>();
        }

        internal void AddBook(Book book)
        {
            var bookList = (from s in groupBookList
                            where s.Any(b => b.Name == book.Name) == false
                            select s).FirstOrDefault();

            if (bookList != null)
            {
                bookList.Add(book);
            }
            else
            {
                groupBookList.Add(new List<Book>() { book });
            }
        }

        internal void AddBookList(IEnumerable<Book> books)
        {
            foreach (var book in books)
            {
                AddBook(book);
            }
        }

        internal int GetPrice()
        {
            return groupBookList.Select(bookList =>
            {
                var bookCount = bookList.Count;
                switch (bookCount)
                {
                    case 1:
                        return bookList.Sum(s => s.Price);
                    case 2:
                        return (int)(bookList.Sum(s => s.Price) * 0.95);
                    case 3:
                        return (int)(bookList.Sum(s => s.Price) * 0.9);
                    case 4:
                        return (int)(bookList.Sum(s => s.Price) * 0.8);
                    case 5:
                        return (int)(bookList.Sum(s => s.Price) * 0.75);
                    default:
                        return 0;
                }

            }).Sum();
        }
    }
}
