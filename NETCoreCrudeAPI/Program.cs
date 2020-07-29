using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace NETCoreCrudeAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var varWebHostBuilder = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            varWebHostBuilder.Run();
        }
    }
}