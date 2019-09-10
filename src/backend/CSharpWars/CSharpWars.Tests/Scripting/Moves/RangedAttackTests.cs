using System;
using Xunit;

namespace CSharpWars.Tests.Scripting.Moves
{
    public class RangedAttackTests
    {
        [Fact]
        public void Building_A_Move_From_RangedAttack_Move_Should_Create_An_Instance_Of_RangedAttack()
        {
            throw new NotImplementedException();
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(2, 0)]
        [InlineData(0, 1)]
        [InlineData(2, 1)]
        [InlineData(0, 2)]
        [InlineData(1, 2)]
        [InlineData(2, 2)]
        public void Executing_A_RangedAttack_Into_Thin_Air_Should_Not_Inflict_Damage(Int32 moveDestinationX, Int32 moveDestinationY)
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Executing_A_RangedAttack_To_A_Victim_Should_Inflict_Damage()
        {
            throw new NotImplementedException();
        }
    }
}