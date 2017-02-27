using DemoCode;
using Xunit;
namespace DemoCodeTests
{
   public class AssertingNullsBools
    {
       [Fact]
       public void ShouldHaveDefaultRandomGeneratedName()
       {
           var playerCharacter = new PlayerCharacter();
          
           Assert.False(string.IsNullOrWhiteSpace(playerCharacter.Name));
       }

       [Fact]
       public void ShouldNotHaveNickName()
       {
           var playerCharacter = new PlayerCharacter();

           Assert.Null(playerCharacter.NickName);
       }
    }
}
