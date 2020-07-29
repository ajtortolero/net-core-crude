using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NETCoreCrude.Base.Settting;
using NETCoreCrude.DAL.Repositories;

namespace NETCoreCrudeAPI
{
    /// <summary>
    ///
    /// </summary>
    public class Startup
    {
        /// <summary>
        ///
        /// </summary>
        private IServiceCollection ServiceCollection;

        /// <summary>
        ///
        /// </summary>
        private IConfiguration Configuration { get; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="pIHostingEnvironment"></param>
        public Startup(IHostingEnvironment pIHostingEnvironment)
        {
#if !DEBUG
                var varConfigurationBuilder = new ConfigurationBuilder()
                    .SetBasePath(pIHostingEnvironment.ContentRootPath)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .AddEnvironmentVariables();

                Configuration = varConfigurationBuilder.Build();
#else
            var varConfigurationBuilder = new ConfigurationBuilder()
                .SetBasePath(pIHostingEnvironment.ContentRootPath)
                .AddJsonFile($"appsettings.{pIHostingEnvironment.EnvironmentName}.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            Configuration = varConfigurationBuilder.Build();
#endif
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="pIServiceCollection"></param>
        public void ConfigureServices(IServiceCollection pIServiceCollection)
        {
            // Configuration
            pIServiceCollection.Configure<AppConnectionStrings>(Configuration.GetSection("ConnectionStrings"));

            // Repositories
            pIServiceCollection.AddScoped<IEmployeeRepository, EmployeeRepository>();
            pIServiceCollection.AddScoped<IContractTypeRepository, ContractTypeRepository>();

            // Logger
            pIServiceCollection.AddLogging(LoggingBuilder =>
            {
                LoggingBuilder.AddConfiguration(Configuration.GetSection("Logging"));
                LoggingBuilder.AddConsole();
                LoggingBuilder.AddDebug();
            });

            pIServiceCollection.AddCors();
            pIServiceCollection.AddMvcCore().AddAuthorization().AddJsonFormatters();

            ServiceCollection = pIServiceCollection;
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="pIApplicationBuilder"></param>
        /// <param name="pIHostingEnvironment"></param>
        /// <param name="pILoggerFactory"></param>
        public void Configure(IApplicationBuilder pIApplicationBuilder, IHostingEnvironment pIHostingEnvironment, ILoggerFactory pILoggerFactory)
        {
            // Add MVC to the request pipeline.
            pIApplicationBuilder.UseCors(Builder =>
                Builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()
            );

            pIApplicationBuilder.UseRequestLocalization();
            pIApplicationBuilder.UseAuthentication();
            pIApplicationBuilder.UseMvc(Routes =>
            {
                Routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
                Routes.MapRoute(name: "ApiClientsByName", template: "{controller=Home}/{action=Index}/{name?}");
            });
        }
    }
}