using System;
using CSharpWars.Enums;
using Xunit;

namespace CSharpWars.Tests.Scripting.Moves
{
    public class MeleeAttackTests
    {
        [Fact]
        public void Building_A_Move_From_MeleeAttack_Move_Should_Create_An_Instance_Of_MeleeAttack()
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
        public void Executing_A_MeleeAttack_Into_Thin_Air_Should_Not_Inflict_Damage(Int32 victimX, Int32 victimY)
        {
            throw new NotImplementedException();
        }

        [Theory]
        [InlineData(PossibleOrientations.East)]
        [InlineData(PossibleOrientations.South)]
        [InlineData(PossibleOrientations.West)]
        public void Executing_A_MeleeAttack_To_A_Victim_Should_Inflict_Normal_Damage(PossibleOrientations victimOrientation)
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Executing_A_MeleeAttack_To_A_Victim_That_Has_His_Back_To_Us_Should_Inflict_Extra_Damage()
        {
            throw new NotImplementedException();
        }

        [Theory]
        [InlineData(1, 0, PossibleOrientations.North)]
        [InlineData(2, 1, PossibleOrientations.East)]
        [InlineData(1, 2, PossibleOrientations.South)]
        [InlineData(0, 1, PossibleOrientations.West)]
        public void Executing_A_MeleeAttack_Should_Work_In_The_Four_Possible_Orientations(Int32 victimX, Int32 victimY, PossibleOrientations orientation)
        {
            throw new NotImplementedException();
        }
    }
}