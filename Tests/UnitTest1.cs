using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CianTivnan_S00198481;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            Game game1 = new Game(50);
            decimal change = 10;
            decimal expected = 40;

            //act
            game1.DecreasePrice(change);

            //assert
            Assert.AreEqual(expected, game1.Price);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //arrange
            Game game2 = new Game(40);
            decimal change = 30;
            decimal expected = 10;

            //act
            game2.DecreasePrice(change);

            //assert
            Assert.AreEqual(expected, game2.Price);
        }
    }
}
