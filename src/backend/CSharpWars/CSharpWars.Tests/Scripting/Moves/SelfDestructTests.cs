using System;
using Xunit;

namespace CSharpWars.Tests.Scripting.Moves
{
    public class SelfDestructTests
    {
        [Fact]
        public void Building_A_Move_From_SelfDestruct_Move_Should_Create_An_Instance_Of_SelfDestruct()
        {
            throw new NotImplementedException();
        }


        [Fact]
        public void Executing_A_SelfDestruct_Should_Kill_The_Bot()
        {
            throw new NotImplementedException();
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 0)]
        [InlineData(2, 0)]
        [InlineData(3, 0)]
        [InlineData(4, 0)]
        [InlineData(5, 0)]
        [InlineData(6, 0)]
        [InlineData(0, 1)]
        [InlineData(6, 1)]
        [InlineData(0, 2)]
        [InlineData(6, 2)]
        [InlineData(0, 3)]
        [InlineData(6, 3)]
        [InlineData(0, 4)]
        [InlineData(6, 4)]
        [InlineData(0, 5)]
        [InlineData(6, 5)]
        [InlineData(0, 6)]
        [InlineData(1, 6)]
        [InlineData(2, 6)]
        [InlineData(3, 6)]
        [InlineData(4, 6)]
        [InlineData(5, 6)]
        [InlineData(6, 6)]
        public void Executing_A_SelfDestruct_Should_Damage_Minimum_Vicinity_Bots_With_Minimum_Damage(Int32 victimX, Int32 victimY)
        {
            throw new NotImplementedException();
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 0)]
        [InlineData(2, 0)]
        [InlineData(3, 0)]
        [InlineData(4, 0)]
        [InlineData(0, 1)]
        [InlineData(4, 1)]
        [InlineData(0, 2)]
        [InlineData(4, 2)]
        [InlineData(0, 3)]
        [InlineData(4, 3)]
        [InlineData(0, 4)]
        [InlineData(1, 4)]
        [InlineData(2, 4)]
        [InlineData(3, 4)]
        [InlineData(4, 4)]
        public void Executing_A_SelfDestruct_Should_Damage_Medium_Vicinity_Bots_With_Medium_Damage(Int32 victimX, Int32 victimY)
        {
            throw new NotImplementedException();
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 0)]
        [InlineData(2, 0)]
        [InlineData(0, 1)]
        [InlineData(2, 1)]
        [InlineData(0, 2)]
        [InlineData(1, 2)]
        [InlineData(2, 2)]
        public void Executing_A_SelfDestruct_Should_Damage_Maximum_Vicinity_Bots_With_Maximum_Damage(Int32 victimX, Int32 victimY)
        {
            throw new NotImplementedException();
        }
    }
}