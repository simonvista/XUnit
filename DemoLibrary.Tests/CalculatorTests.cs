using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;
using Xunit;

namespace DemoLibrary.Tests
{
    public class CalculatorTests
    {
        //[Fact]
        [Theory]
        [InlineData(4,3,7)]
        [InlineData(21, 3.33, 24.33)]
        [InlineData(double.MaxValue,5,double.MaxValue)]
        public void Add_SimpleValueShouldCalculate(double x,double y,double expected)
        {
            //arrange
            

            //act
            double actual = Calculator.Add(x,y);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
