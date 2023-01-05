using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Windows;
using WpfOJT.App.Views.Account;
using WpfOJT.Entities.Data;
using WpfOJT.Services.IOC;

namespace WpfOJT.App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Define the _serviceProvider
        /// </summary>
        private ServiceProvider _serviceProvider;
        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureService(services);
            _serviceProvider = services.BuildServiceProvider();
        }

        /// <summary>
        /// Configure services
        /// </summary>
        /// <param name="services"></param>
        private void ConfigureService(ServiceCollection services)
        {
            string connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            services.AddDbContext<BulltetinboardContext>(options =>
            {
                options.UseSqlServer(connString);
            });
            services.InjectDependencies(connString);
            services.AddSingleton<Login>();
        }     

        /// <summary>
        /// Resolve login service from dependency injection and show login window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnStartUp(object sender,StartupEventArgs e)
        {
            var loginWindow = _serviceProvider.GetService<Login>();
            loginWindow.Show();
        }
    }
}
