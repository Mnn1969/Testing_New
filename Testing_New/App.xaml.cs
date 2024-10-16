using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;
using Testing_New.Data;
using Testing_New.Services;
using Testing_New.ViewModels;

namespace Testing_New
{
    public partial class App
    {
        public static object? FocusedWindow => Current.Windows.Cast<Window>().FirstOrDefault(w => w.IsFocused);
        public static object? ActivedWindow => Current.Windows.Cast<Window>().FirstOrDefault(w => w.IsActive);

        private static IHost? __Host;

        public static IHost Host => __Host ??= Program.CreateHostBuilder(Environment.GetCommandLineArgs()).Build();


        internal static void ConfigureServices(HostBuilderContext host, IServiceCollection service) => service
            .AddDatabase(host.Configuration.GetSection("Database"))
            .AddServices()
            .AddViewModels();
       
        public static IServiceProvider Services => Host.Services;

        protected override async void OnStartup(StartupEventArgs e)
        {
            var host = Host;
            base.OnStartup(e);
            await host.StartAsync();
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            using var host = Host;
            await host.StopAsync();
        }
    }

}
