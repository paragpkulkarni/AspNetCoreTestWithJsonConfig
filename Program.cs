    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using System.IO;
    
    namespace NewTest
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                BuildWebHost(args).Run();
            }             
    
            public static IWebHost BuildWebHost(string[] args)
            {
                var config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("hosting.json", optional: true)
                    .AddCommandLine(args)
                    .Build();                                    
    
                return WebHost.CreateDefaultBuilder(args)
                    .UseUrls("http://*:5000")
                    .UseConfiguration(config)
                    .Configure(app =>
                    {
                        //This is required otherwise application will throw the exception.                                      
                    })
                    .Build();
            }
        }
}
