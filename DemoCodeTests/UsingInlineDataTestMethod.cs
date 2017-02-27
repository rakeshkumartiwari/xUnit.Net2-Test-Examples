using DemoCode;
using Xunit;
namespace DemoCodeTests
{
   public class UsingInlineDataTestMethod
    {
       [Theory]
       [InlineData(5,10,15)]
       [InlineData(-5, 10, 5)]
       [InlineData(5, -10, -5)]
       public void ShouldAddTwoNumbers(int firstNumber,int secondNumber,int expectedValue)
       {
           var calculator = new Calculator();

           var result = calculator.AddInts(firstNumber, secondNumber);
           Assert.Equal(expectedValue, result);

       }
    }
}
