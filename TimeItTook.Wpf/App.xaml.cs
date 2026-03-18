using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using TimeItTook.Core.Model;
using TimeItTook.View;
using TimeItTook.ViewModel;

namespace TimeItTook.Wpf
{
    public partial class App : Application
    {
        // TODO: https://medium.com/@shanto462/dependency-injection-in-wpf-a-complete-implementation-guide-468abcf95337

        private IServiceProvider serviceProvider;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ConfigureServiceProvider();

            using var context = serviceProvider.GetRequiredService<DatabaseContext>();
            context.Database.EnsureCreated();

            var mainWindow = serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

        private void ConfigureServiceProvider()
        {
            var services = new ServiceCollection();
            services.AddLogging();
            services.AddDbContext<DatabaseContext>();

            services.AddSingleton<MainWindowViewModel>(); // TODO - use an interface
            services.AddSingleton<MainWindow>();

            serviceProvider = services.BuildServiceProvider();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            if(serviceProvider is IDisposable disposable)
            {
                disposable.Dispose();
            }
            base.OnExit(e);
        }
    }
}
