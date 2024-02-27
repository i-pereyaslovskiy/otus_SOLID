using Microsoft.Extensions.DependencyInjection;
using otus_Solid.Interfaces;
using otus_Solid.Services;
using otus_Solid.Game;
using otus_Solid.Services.Conseole;

namespace otus_Solid.Settings
{
    internal class DIConfiguration
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<Random>();
            services.AddScoped<ITimeDelay, TimeDelay>();
            services.AddScoped<IRandomaizer, Randomizer>();
            services.AddScoped<IGameProcess, GameProcess>();
            services.AddTransient<IGameLogic, GameLogic>();
            services.AddScoped<IMessage, Message>();
            services.AddScoped<IUserInput, UserInput>();

        }
    }
}
