using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpWars.DtoModel;
using CSharpWars.Logic.Interfaces;

namespace CSharpWars.Logic
{
    public class BotLogic : IBotLogic
    {
        public Task<IList<BotDto>> GetAllActiveBots()
        {
            throw new NotImplementedException();
        }

        public Task<IList<BotDto>> GetAllLiveBots()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetBotScript(Guid botId)
        {
            throw new NotImplementedException();
        }

        public Task<BotDto> CreateBot(BotToCreateDto bot)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBots(IList<BotDto> bots)
        {
            throw new NotImplementedException();
        }
    }
}