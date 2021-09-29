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
        [Theory]
        [InlineData(8,4,2)]
        public void Divide_SimpleValueShouldCalculate(double x, double y, double expected)
        {
            //arrange

            //act
            double actual = Calculator.Divide(x, y);

            //assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Divide_DivideByZero()
        {
            //arrange
            double expected = 0;

            //act
            double actual = Calculator.Divide(3, 0);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
