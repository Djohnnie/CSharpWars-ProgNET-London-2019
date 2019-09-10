using System;
using CSharpWars.Enums;
using Xunit;

namespace CSharpWars.Tests.Scripting.Moves
{
    public class EmptyMoveTests
    {
        [Theory]
        [InlineData(PossibleMoves.Idling)]
        [InlineData(PossibleMoves.ScriptError)]
        public void Building_A_Move_From_Unsupported_Move_Should_Create_An_Instance_Of_EmptyMove(PossibleMoves unsupportedMove)
        {
            throw new NotImplementedException();
        }

        [Theory]
        [InlineData(PossibleMoves.Idling)]
        [InlineData(PossibleMoves.ScriptError)]
        public void Executing_An_Unsupported_Move_Should_Do_Nothing(PossibleMoves unsupportedMove)
        {
            throw new NotImplementedException();
        }
    }
}