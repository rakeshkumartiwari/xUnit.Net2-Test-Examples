using System.Collections.Generic;
using DemoCode;
using Xunit;
namespace DemoCodeTests
{
    public class UsingMemberDataTestMethod
    {
        public static IEnumerable<object[]> TestData
        {
            get
            {
                yield return new object[] { 5, 10, 15 };
                yield return new object[] { -5, 10, 5 };
                yield return new object[] { 5, -10, -5 };
                yield return new object[] { -2, 10, 8 };

            }
        }

        [Theory]
        [MemberData("TestData")]
        public void ShouldAddTwoNumbers(int firstNumber, int secondNumber, int expectedValue)
        {
            var calculator = new Calculator();

            var result = calculator.AddInts(firstNumber, secondNumber);
            Assert.Equal(expectedValue, result);

        }
    }
}
