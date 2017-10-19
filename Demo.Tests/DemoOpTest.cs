using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Tests
{
    [TestClass]
    public class DemoOpTest
    {
        [TestMethod]

        public void ShouldAddReturnNineWhenPassFiveandFour()
        { 
             //Arrange
            DemoOp sut = new DemoOp();
             //Act
            int result = sut.Add(5, 4);
             //Assert
            Assert.AreEqual(9, result);
        }
        [TestMethod]

        public void ShouldMulReturnNineWhenPassFiveandFour()
        {
            //Arrange
            DemoOp sut = new DemoOp();
            //Act
            int result = sut.Mul(5, 4);
            //Assert
            Assert.AreEqual(20, result);
        }
    }
}
