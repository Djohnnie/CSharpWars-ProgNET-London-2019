using System;
using CSharpWars.Enums;
using Xunit;

namespace CSharpWars.Tests.Scripting.Moves
{
    public class TurnAroundTests
    {
        [Fact]
        public void Building_A_Move_From_TurningAround_Move_Should_Create_An_Instance_Of_TurnAround()
        {
            throw new NotImplementedException();
        }

        [Theory]
        [ClassData(typeof(TurningAroundTheoryData))]
        public void Turning_Around_Should_Work(PossibleOrientations originOrientation, PossibleOrientations destinationOrientation)
        {
            throw new NotImplementedException();
        }

        private class TurningAroundTheoryData : TheoryData<PossibleOrientations, PossibleOrientations>
        {
            public TurningAroundTheoryData()
            {
                Add(PossibleOrientations.North, PossibleOrientations.South);
                Add(PossibleOrientations.East, PossibleOrientations.West);
                Add(PossibleOrientations.South, PossibleOrientations.North);
                Add(PossibleOrientations.West, PossibleOrientations.East);
            }
        }
    }
}