using System;
using CSharpWars.Enums;
using Xunit;

namespace CSharpWars.Tests.Scripting.Moves
{
    public class TurnRightTests
    {
        [Fact]
        public void Building_A_Move_From_TurningRight_Move_Should_Create_An_Instance_Of_TurnRight()
        {
            throw new NotImplementedException();
        }

        [Theory]
        [ClassData(typeof(TurningRightTheoryData))]
        public void Turning_Right_Should_Work(PossibleOrientations originOrientation, PossibleOrientations destinationOrientation)
        {
            throw new NotImplementedException();
        }

        private class TurningRightTheoryData : TheoryData<PossibleOrientations, PossibleOrientations>
        {
            public TurningRightTheoryData()
            {
                Add(PossibleOrientations.North, PossibleOrientations.East);
                Add(PossibleOrientations.East, PossibleOrientations.South);
                Add(PossibleOrientations.South, PossibleOrientations.West);
                Add(PossibleOrientations.West, PossibleOrientations.North);
            }
        }
    }
}