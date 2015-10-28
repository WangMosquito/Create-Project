using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ShoppingCartTest
{
    [TestClass]
    public class ShoppingCartTest
    {
        [TestMethod]
        public void GetPrice_第一集買了一本_其他都沒買_價格應為100_乘_1_等於_100元()
        {
            //arrange
            var target = new ShoppingCart();
            var potterBook = new Book { Name = "Potter第一集", Price = 100 };
            var expected = 100;

            target.AddBook(potterBook);

            //act
            var actual = target.GetPrice();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPrice_第一集買了一本_第二集也買了一本_價格應為100_乘_2_乘_0點95_等於_190元()
        {
            //arrange
            var target = new ShoppingCart();
            var potterBook = new List<Book> {
                new Book { Name = "Potter第一集", Price = 100 },
                new Book { Name = "Potter第二集", Price = 100 }
            };
            var expected = 190;

            target.AddBookList(potterBook);

            //act
            var actual = target.GetPrice();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPrice_一二三集各買了一本_價格應為100_乘_3_乘_0點9_等於_270元()
        {

            //arrange
            var target = new ShoppingCart();
            var potterBook = new List<Book> {
                new Book { Name = "Potter第一集", Price = 100 },
                new Book { Name = "Potter第二集", Price = 100 },
                new Book { Name = "Potter第三集", Price = 100 }
            };
            var expected = 270;

            target.AddBookList(potterBook);

            //act
            var actual = target.GetPrice();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
