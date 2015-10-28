using System.Collections.Generic;
using System.Linq;

namespace ShoppingCartTest
{
    internal class ShoppingCart
    {
        private List<Book> _book;

        public ShoppingCart()
        {
            _book = new List<Book>();
        }
        
        internal void AddBook(Book book) {
            _book.Add(book);
        }

        internal void AddBookList(IEnumerable<Book> book)
        {            
            _book.AddRange(book);
        }

        internal int GetPrice()
        {
            var bookCount = _book.Count;
            switch (bookCount)
            {
                case 1:
                    return _book.Sum(s => s.Price);
                case 2:
                    return (int)(_book.Sum(s => s.Price) * 0.95);
                case 3:
                    return (int)(_book.Sum(s => s.Price) * 0.9);
                default:
                    return 0;
            }
        }
    }
}
