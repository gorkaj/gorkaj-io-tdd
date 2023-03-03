using TDD;

namespace TDD_test
{
    public class StringCalculatorUnitTest
    {
        private readonly StringCalculator _calculator;
        
        public StringCalculatorUnitTest()
        {
            _calculator = new StringCalculator();
        }

        [Fact]
        public void ShouldReturnZeroWhenEmptyStringPassed()
        {
            Assert.Equal(0, _calculator.Add(""));
        }

        [Theory]
        [InlineData("4", 4)]
        [InlineData("0", 0)]
        [InlineData("11", 11)]
        public void ShouldReturnPassedNumberIfASingleNumberPassed(string numbers, int expected)
        {
            Assert.Equal(expected, _calculator.Add(numbers));
        }

        [Theory]
        [InlineData("2,0", 2)]
        [InlineData("1,7", 8)]
        [InlineData("2,4", 6)]
        public void ShouldReturnSumOfTwoNumbersDelimitedByComma(string numbers, int expected)
        {
            Assert.Equal(expected, _calculator.Add(numbers));
        }
        
        [Theory]
        [InlineData("2\n5", 7)]
        [InlineData("1\n7", 8)]
        [InlineData("2\n4", 6)]
        public void ShouldReturnSumOfTwoNumbersDelimitedByNewLine(string numbers, int expected)
        {
            Assert.Equal(expected, _calculator.Add(numbers));
        }
        
        [Theory]
        [InlineData("2\n0,2", 4)]
        [InlineData("1\n7\n3", 11)]
        [InlineData("2,4,1", 7)]
        public void ShouldReturnSumOfThreeNumbersDelimitedEitherWay(string numbers, int expected)
        {
            Assert.Equal(expected, _calculator.Add(numbers));
        }
        
        [Theory]
        [InlineData("2,-5")]
        [InlineData("1\n7,-1")]
        [InlineData("-2,-4,1")]
        public void ShouldThrowAnExceptionWhenPassedNegativeNumber(string numbers)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _calculator.Add(numbers));
        }
        
        [Theory]
        [InlineData("2\n1001,2", 4)]
        [InlineData("1\n7\n1000", 1008)]
        [InlineData("2300,4,1", 5)]
        public void ShouldIgnoreNumbersGreaterThanAThousand(string numbers, int expected)
        {
            Assert.Equal(expected, _calculator.Add(numbers));
        }
    }
}

