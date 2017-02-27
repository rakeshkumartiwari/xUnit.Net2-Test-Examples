using DemoCode;
using Xunit;
namespace DemoCodeTests
{
    public class AssertingCollections
    {
        [Fact]
        public void ShouldHaveNoEmptyDefaultWeapons()
        {
            var playeCharacter = new PlayerCharacter();

            Assert.All(playeCharacter.Weapons, weapon => Assert.False(string.IsNullOrWhiteSpace(weapon)));
        }
        [Fact]
        public void ShouldHaveALongBow()
        {
            var playeCharacter = new PlayerCharacter();

            Assert.Contains("Long Bow", playeCharacter.Weapons);
        }

        [Fact]
        public void ShouldNotHaveStaffOfWonder()
        {
            var playeCharacter = new PlayerCharacter();

            Assert.DoesNotContain("Staff of Wonder", playeCharacter.Weapons);
        }

        [Fact]
        public void ShouldHaveAtleastOneKindOfSword()
        {
            var playeCharacter = new PlayerCharacter();

            Assert.Contains(playeCharacter.Weapons, weapon => weapon.Contains("Sword"));
        }
        public void ShouldHaveAllExpectedWeapons()
        {
            var playeCharacter = new PlayerCharacter();
            var expectedWeapons = new[]
            {
                "Long Bow",
               "Short Bow",
               "Short Sword"
            };
            Assert.Equal(expectedWeapons, playeCharacter.Weapons);
        }

    }
}
