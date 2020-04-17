using RPG.Actions;
using RPG.Character;
using RPG.Character.Player;
using RPG.Character.Proffesions;
using System;
using System.Collections.Generic;
using System.Reflection;
using Xunit;
using Xunit.Sdk;

namespace RPG.Tests.ActionsTests
{
    public class BasicAttackTest
    {
        [Fact]
        public void Given_NullAttacker_When_ConstructingBasicAttack_Then_ThrowsArgumentNullException()
        {
            var character = PlayerFactory.Create("John", PlayerProffesions.Mage);

            Assert.Throws<ArgumentNullException>(() => new BasicAttack(null, character));
        }

        [Fact]
        public void Given_NullTarget_When_ConstructingBasicAttack_Then_ThrowsArgumentNullException()
        {
            var character = PlayerFactory.Create("John", PlayerProffesions.Mage);

            Assert.Throws<ArgumentNullException>(() => new BasicAttack(character, null));
        }

        [Fact]
        public void Given_NoParameters_When_CallingExecuteMultipleTimes_Then_ThrowsActionAlreadyExecutedException()
        {
            var attacker = PlayerFactory.Create("John", PlayerProffesions.Mage);
            var target = PlayerFactory.Create("Dummy", PlayerProffesions.Mage);
            var basicAttack = new BasicAttack(attacker, target);
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
