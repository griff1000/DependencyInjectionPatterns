namespace DependencyInjectionPatterns
{
    using System;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.DependencyInjection;
    using DependencyInjectionPatterns.Scoped;
    using DependencyInjectionPatterns.Capability;
    using DependencyInjectionPatterns.Unscoped;

    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection()
                .AddLogging();

            #region unscoped DI

            //Console.WriteLine("********** Unscoped DI **********");

            //#region Standard inheritance DI

            //serviceCollection.AddSingleton<IDoStuff, AdvancedStuffDoer>();

            //#endregion

            //#region Chained DI

            ////serviceCollection.AddSingleton<IDoStuff>(sp =>
            ////{
            ////    var baseStuffDoer = new BasicStuffDoer();
            ////    var logger = sp.GetRequiredService<ILogger<ChainedStuffDoer>>();
            ////    var chainedStuffDoer = new ChainedStuffDoer(baseStuffDoer, logger);
            ////    return chainedStuffDoer;
            ////});


            //#endregion

            //#region use whatever IDoStuff I've registered

            //var serviceProvider = serviceCollection.BuildServiceProvider();
            //var stuffDoer = serviceProvider.GetService<IDoStuff>();
            //Console.WriteLine(stuffDoer.DoSomethingWithNumber(5));
            //Console.ReadKey();

            //#endregion

            #endregion

            #region Scoped DI

            //Console.WriteLine();
            //Console.WriteLine("********** Scoped DI **********");

            //serviceCollection.AddSingleton<IDoStuffScoped<Basic>, AStuffDoerScoped<Basic>>();
            //serviceCollection.AddSingleton<IDoStuffScoped<Advanced>, AnotherStuffDoerScoped<Advanced>>();

            //var serviceProvider = serviceCollection.BuildServiceProvider();

            //var basicStuffDoer = serviceProvider.GetService<IDoStuffScoped<Basic>>();
            //var advancedStuffDoer = serviceProvider.GetService<IDoStuffScoped<Advanced>>();

            //Console.WriteLine($"Basic one says {basicStuffDoer.DoSomethingWithNumber(5)}");
            //Console.WriteLine($"Advanced one says {advancedStuffDoer.DoSomethingWithNumber(5)}");

            #endregion

            #region Capability DI

            Console.WriteLine();
            Console.WriteLine("********** Capability DI **********");

            serviceCollection.AddSingleton<IDoStuffWithCapability>(new AStuffDoerWithCapability(num => num < 10));
            serviceCollection.AddSingleton<IDoStuffWithCapability>(new AnotherStuffDoerWithCapability(num => num >= 10));
            serviceCollection.AddSingleton<IUseDoStuff, SomethingThatUsesStuffDoers>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var stuffDoerUser = serviceProvider.GetService<IUseDoStuff>();

            stuffDoerUser.UseDoStuff(5);
            stuffDoerUser.UseDoStuff(15);

            #endregion
        }
    }
}
