using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using BlazorPeliculas.Client.Repositories;
using Tewr.Blazor.FileReader;
using BlazorPeliculas.Client.Helpers;

namespace BlazorPeliculas.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            ConfigureServices(builder.Services);

            await builder.Build().RunAsync();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions(); //Sistema de autorización.
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IMostrarMensajes, MostrarMensajes>();
            services.AddFileReaderService(options => options.InitializeOnFirstCall = true);
        }
    }
}
