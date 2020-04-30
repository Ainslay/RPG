using Moq;
using RPG.Actions;
using RPG.Character.Player;
using RPG.Character.Proffesions;
using System;
using Xunit;

namespace RPG.Tests.ActionsTests
{
    public class BasicAttackTest
    {
        [Fact]
        public void Given_NullAttacker_When_ConstructingBasicAttack_Then_ThrowsArgumentNullException()
        {
            var mockedCharacter = new Mock<PlayerCharacter>(new object[] { "John", new Mage() });

            Assert.Throws<ArgumentNullException>(() => new BasicAttack(null, mockedCharacter.Object));
        }

        [Fact]
        public void Given_NullTarget_When_ConstructingBasicAttack_Then_ThrowsArgumentNullException()
        {
            var mockedCharacter = new Mock<PlayerCharacter>(new object[] { "John", new Mage() });

            Assert.Throws<ArgumentNullException>(() => new BasicAttack(mockedCharacter.Object, null));
        }

        [Fact]
        public void Given_NoParameters_When_CallingExecuteMultipleTimes_Then_ThrowsActionAlreadyExecutedException()
        {
            var mockedCharacter = new Mock<PlayerCharacter>(new object[] { "John", new Mage() });

            var basicAttack = new BasicAttack(mockedCharacter.Object, mockedCharacter.Object);
            basicAttack.Execute();

            Assert.Throws<ActionAlreadyExecutedException>(() => basicAttack.Execute());
        }

        // Tu mam problem z przekazaniem do testu parametrów
        //[Theory]
        //[BasicAttackConstructionData]
        //public void Given_NullParameter_When_ConstructingBasicAttack_Then_ThrowsArgumentNullException(BaseCharacter attacker, BaseCharacter target)
        //{

        //}

        //private class BasicAttackConstructionData : DataAttribute
        //{
        //    public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        //    {
        //        yield return new object[] { null, null };
        //        yield return new object[] { PlayerFactory.Create("John", PlayerProffesions.Mage), null };
        //        yield return new object[] { null, PlayerFactory.Create("John", PlayerProffesions.Mage) };
        //    }   
        //}
    }
}
