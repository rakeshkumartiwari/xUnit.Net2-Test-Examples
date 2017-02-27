using DemoCode;
using Xunit;
namespace DemoCodeTests
{
   public class AssertingNumericResultd
    {
       [Fact]
       public void ShouldAddIntsValues()
       {
           var calculator = new Calculator();

         var result=  calculator.AddInts(10, 5);

           Assert.Equal(15,result);

       }
       [Fact]
       public void ShouldAddDoublesValues()
       {
           var calculator = new Calculator();
           double result = calculator.AddDoubles(1.2, 2.1);

           Assert.Equal(3.3,result);
       }
    }
}
