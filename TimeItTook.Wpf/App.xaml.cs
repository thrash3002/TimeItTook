using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using TimeItTook.Core.Model;
using TimeItTook.Core.Service;
using TimeItTook.Core.Util;
using TimeItTook.View;
using TimeItTook.ViewModel;
using TimeItTook.Wpf.Service;

namespace TimeItTook.Wpf
{
    public partial class App : Application
    {
        private IServiceProvider? serviceProvider;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ConfigureServiceProvider();

            using var context = serviceProvider!.GetRequiredService<DatabaseContext>();
            context.Database.EnsureCreated();

            var mainWindow = serviceProvider!.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

        private void ConfigureServiceProvider()
        {
            var services = new ServiceCollection();
            services.AddLogging();
            services.AddDbContext<DatabaseContext>();

            services.AddSingleton<IUserInteractionService, UserInteractionService>();

            services.AddSingleton<MainWindowViewModel>();
            services.AddSingleton<MainWindow>();

            services.AddFactory<AddNewTaskWindowViewModel>();
            services.AddFactory<AddNewTaskWindow>();

            services.AddFactory<AddNewGoalWindowViewModel>();
            services.AddFactory<AddNewGoalWindow>();

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
