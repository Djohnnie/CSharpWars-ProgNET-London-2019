using System;
using System.Collections.Generic;
using CSharpWars.Common.Helpers.Interfaces;
using CSharpWars.DtoModel;
using CSharpWars.Enums;
using CSharpWars.Scripting;
using CSharpWars.Scripting.Model;
using CSharpWars.ScriptProcessor.Moves;
using FluentAssertions;
using Moq;
using Xunit;

namespace CSharpWars.Tests.Scripting.Moves
{
    public class WalkForwardTests
    {
        [Fact]
        public void Building_A_Move_From_WalkForward_Move_Should_Create_An_Instance_Of_WalkForward()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Walking_Forward_Without_Stamina_Should_Be_Ignored()
        {
            throw new NotImplementedException();
        }

        [Theory]
        [ClassData(typeof(WalkForwardOrientationTheoryData))]
        public void Walking_Forward_Against_Edge_Should_Be_Ignored(PossibleOrientations orientation)
        {
            throw new NotImplementedException();
        }

        private class WalkForwardOrientationTheoryData : TheoryData<PossibleOrientations>
        {
            public WalkForwardOrientationTheoryData()
            {
                Add(PossibleOrientations.North);
                Add(PossibleOrientations.East);
                Add(PossibleOrientations.South);
                Add(PossibleOrientations.West);
            }
        }

        [Theory]
        [ClassData(typeof(WalkForwardTheoryData))]
        private void Walking_Forward_Should_Work(PossibleOrientations orientation, Int32 destinationX, Int32 destinationY)
        {
            throw new NotImplementedException();
        }

        private class WalkForwardTheoryData : TheoryData<PossibleOrientations, Int32, Int32>
        {
            public WalkForwardTheoryData()
            {
                Add(PossibleOrientations.North, 1, 0);
                Add(PossibleOrientations.East, 2, 1);
                Add(PossibleOrientations.South, 1, 2);
                Add(PossibleOrientations.West, 0, 1);
            }
        }
    }
}