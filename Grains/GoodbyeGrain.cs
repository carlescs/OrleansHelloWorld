using System.Threading.Tasks;
using GrainInterfaces;
using Microsoft.Extensions.Logging;

namespace Grains
{
    public class GoodbyeGrain:Orleans.Grain,IGoodbye
    {
        private ILogger _logger;

        public GoodbyeGrain(ILogger<GoodbyeGrain> logger)
        {
            _logger = logger;
        }

        public Task<string> SayGoodbye(string greeting)
        {
            _logger.LogInformation($"\n Goodbye message received: greeting = '{greeting}'");
            return Task.FromResult($"\n Client said: '{greeting}', so Goodbye says: Hello!");
        }
    }
}