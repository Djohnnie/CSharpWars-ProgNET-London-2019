using System;
using CSharpWars.Scripting.Model;
using CSharpWars.ScriptProcessor.Middleware;

namespace CSharpWars.ScriptProcessor.Moves
{
    public class SelfDestruct : Move
    {
        public SelfDestruct(BotProperties botProperties) : base(botProperties)
        {
        }

        public override BotResult Go()
        {
            throw new NotImplementedException();
        }
    }
}