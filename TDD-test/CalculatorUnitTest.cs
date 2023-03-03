using TDD;

namespace TDD_test
{
    public class StringCalculatorUnitTest
    {
        private readonly StringCalculator calculator;
        
        public StringCalculatorUnitTest()
        {
            calculator = new();
        }

        [Fact]
        public void ShouldReturnZeroWhenEmptyStringPassed()
        {
            Assert.Equal(0, calculator.Add(""));
        }
    }
}

