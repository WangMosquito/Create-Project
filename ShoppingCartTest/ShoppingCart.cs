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

        internal int GetPrice() {
            return _book.Sum(s => s.Price);
        }
    }
}
