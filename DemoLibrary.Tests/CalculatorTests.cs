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
        [Fact]
        public void Add_SimpleValueShouldCalculate()
        {
            //arrange
            double expected = 5;

            //act
            double actual = Calculator.Add(3, 2);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
