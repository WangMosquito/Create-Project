using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
