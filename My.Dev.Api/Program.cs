using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace My.Dev.Api
{
    public class MyApi
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write(typeof(string).Assembly.ImageRuntimeVersion);
            Console.Read();

            WebHost
                .CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build()
                .Run();
        }
    }
}