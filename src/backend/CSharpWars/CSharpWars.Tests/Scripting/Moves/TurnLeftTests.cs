using System;
using CSharpWars.Enums;
using Xunit;

namespace CSharpWars.Tests.Scripting.Moves
{
    public class TurnLeftTests
    {
        [Fact]
        public void Building_A_Move_From_TurningLeft_Move_Should_Create_An_Instance_Of_TurnLeft()
        {
            throw new NotImplementedException();
        }

        [Theory]
        [ClassData(typeof(TurningLeftTheoryData))]
        public void Turning_Left_Should_Work(PossibleOrientations originOrientation, PossibleOrientations destinationOrientation)
        {
            throw new NotImplementedException();
        }

        private class TurningLeftTheoryData : TheoryData<PossibleOrientations, PossibleOrientations>
        {
            public TurningLeftTheoryData()
            {
                Add(PossibleOrientations.North, PossibleOrientations.West);
                Add(PossibleOrientations.East, PossibleOrientations.North);
                Add(PossibleOrientations.South, PossibleOrientations.East);
                Add(PossibleOrientations.West, PossibleOrientations.South);
            }
        }
    }
}