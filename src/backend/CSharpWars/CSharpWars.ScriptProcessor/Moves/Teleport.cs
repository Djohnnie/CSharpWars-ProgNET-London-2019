using System;
using CSharpWars.Common.Helpers.Interfaces;
using CSharpWars.Scripting.Model;
using CSharpWars.ScriptProcessor.Middleware;

namespace CSharpWars.ScriptProcessor.Moves
{
    public class Teleport : Move
    {
        private readonly IRandomHelper _randomHelper;

        public Teleport(BotProperties botProperties, IRandomHelper randomHelper) : base(botProperties)
        {
            _randomHelper = randomHelper;
        }

        public override BotResult Go()
        {
            throw new NotImplementedException();
        }
    }
}