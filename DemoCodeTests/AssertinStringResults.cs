using DemoCode;
using Xunit;
namespace DemoCodeTests
{
  public  class AssertinStringResults
    {
      [Fact]
      public void ShouldJoinName()
      {
          var namejoiner = new NameJoiner();
          var fullName = namejoiner.Join("Rakesh", "Tiwari");

          Assert.Equal("Rakesh Tiwari", fullName);
          
      }

      [Fact]
      public void ShouldJoinName_CaseInsensitive()
      {
          var namejoiner = new NameJoiner();
          var fullName = namejoiner.Join("Rakesh", "Tiwari");

          Assert.Equal("RAKESH TIWARI", fullName,ignoreCase:true);

      }
      [Fact]
      public void ShouldJoinName_SubStringContent()
      {
          var namejoiner = new NameJoiner();
          var fullName = namejoiner.Join("Rakesh", "Tiwari");

          Assert.Contains("Tiwari", fullName);

      }

      [Fact]
      public void ShouldJoinName_StartsWith()
      {
          var namejoiner = new NameJoiner();
          var fullName = namejoiner.Join("Rakesh", "Tiwari");

          Assert.StartsWith("Rakesh", fullName);

      }
      [Fact]
      public void ShouldJoinName_EndsWith()
      {
          var namejoiner = new NameJoiner();
          var fullName = namejoiner.Join("Rakesh", "Tiwari");

          Assert.EndsWith("ri", fullName);

      }
      [Fact]
      public void ShouldJoinName_Regex()
      {
          var namejoiner = new NameJoiner();
          var fullName = namejoiner.Join("Rakesh", "Tiwari");

          Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", fullName);

      }
    }
}
