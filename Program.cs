using Microsoft.Extensions.DependencyInjection;
using otus_Solid.Interfaces;
using otus_Solid.Settings;



var serviceCollection = new ServiceCollection();
var diServiceConfig = new DIConfiguration();
diServiceConfig.ConfigureServices(serviceCollection);
var serviceProvider = serviceCollection.BuildServiceProvider();
var game = serviceProvider.GetRequiredService<IGameProcess>();


game.InitGame();
Console.WriteLine("---------------- THE END -----------------------");
Console.ReadKey();
