using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;
using Remotion.Linq.Parsing.Structure.IntermediateModel;

namespace My.Dev.Api
{
    public class MyApi
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("My Api is running!");
            Console.Write(typeof(string).Assembly.ImageRuntimeVersion);
            //Console.Read();

            WebHost
                .CreateDefaultBuilder(args)  // This returns IWebHost builder include Kestrel which is inbuilt lightweight web server
                                             // configurations setup also setup here unlike in .Core 1.0 done in startup method
                .UseStartup<Startup>()  // generic method to accept type parameter and load application related classes and request pipeline
                                        // we can do the same with Web-host extension methods but start-up is the re commanded way
                .Build()
                .Run();   // This will run the api app and block it's closing down and handle http request receive

            // Config setup
            // 1. Finding the env
            // 2. Find the appSettings.json for configuration and then check for second appsetting file which is assSettings.env.json where
            // you can use when the app runs locally or use different env settings for different env's. That overrides the appSettings.jason file
            // 3.Then check for any user secrets when run locally which you don't wont to check in
            // 4.Then load env variables whatever setup, if you run docker you can setup different env variables and load them here to the application
            // without checking to the source control
            // 5 Any commandline argument if any
            // 6. Logging (This used to be in startup class in .Core 1.0) This enable to get the startup logging to see if any issues there
            // 7. Have option to run behind the IIS server.
            // 8. DI framework will loaded for dependance injection

            // After all above it will back-out the builder with all above
        }
    }
}