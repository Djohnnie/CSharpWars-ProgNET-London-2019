using System;
using System.Threading.Tasks;
using CSharpWars.DtoModel;
using CSharpWars.Logging.Interfaces;
using CSharpWars.Logic.Interfaces;
using CSharpWars.ScriptProcessor.Interfaces;
using CSharpWars.ScriptProcessor.Middleware.Interfaces;

namespace CSharpWars.ScriptProcessor.Middleware
{
    public class BotProcessingFactory : IBotProcessingFactory
    {
        private readonly IBotLogic _botLogic;
        private readonly IBotScriptCompiler _botScriptCompiler;
        private readonly IBotScriptCache _botScriptCache;
        private readonly ILogger _logger;

        public BotProcessingFactory(
            IBotLogic botLogic,
            IBotScriptCompiler botScriptCompiler,
            IBotScriptCache botScriptCache, ILogger logger)
        {
            _botLogic = botLogic;
            _botScriptCompiler = botScriptCompiler;
            _botScriptCache = botScriptCache;
            _logger = logger;
        }

        public async Task Process(BotDto bot, ProcessingContext context)
        {
            throw new NotImplementedException();
        }
    }
}