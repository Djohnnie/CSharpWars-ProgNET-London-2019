using System;
using Xunit;

namespace CSharpWars.Tests.Scripting.Moves
{
    public class TeleportTests
    {
        [Fact]
        public void Building_A_Move_From_Teleport_Move_Should_Create_An_Instance_Of_Teleport()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Executing_A_Teleport_Into_An_Empty_Spot_Should_Work()
        {
            throw new NotImplementedException();
        }

        [Theory]
        [InlineData(4, -1)]
        [InlineData(5, 0)]
        [InlineData(4, 1)]
        [InlineData(-1, 0)]
        public void Executing_A_Teleport_Into_An_Invalid_Spot_Should_Randomly_Teleport(Int32 destinationX, Int32 destinationY)
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Executing_A_Teleport_Into_An_Enemy_Should_Switch_Places()
        {
            throw new NotImplementedException();
        }
    }
}