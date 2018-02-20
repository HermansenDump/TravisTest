using System;
using TravisTestSolution;
using Xunit;

namespace TravisTestSolutionUnitTest
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_Add2Plus3_Returns5()
        {
            var uut = new Calculator();

            Assert.Equal(5, uut.Add(2,3));
        }

        [Fact]
        public void Add_Add3Plus3_Returns5()
        {
            var uut = new Calculator();

            Assert.Equal(3, uut.Add(2, 3));
        }
    }
}
