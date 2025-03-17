using Microsoft.Extensions.DependencyInjection;
using SoftUI.MVVM.View;
using SoftUI.MVVM.ViewModel;
using System.Globalization;
using System.Threading;
using System.Windows;

namespace SoftUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Establecer la cultura de la aplicación a es-CL (Chile)
            CultureInfo cultureInfo = new CultureInfo("es-CL");

            // Configurar la cultura global para la aplicación
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            // Aquí lanzamos la ventana principal
            var mainWindow = new LoginUsu();
            mainWindow.Show();
        }
    

    private ServiceProvider _serviceProvider;



        public App()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<MainWindow>();
            services.AddSingleton<HomeView>();
            services.AddSingleton<Ing_Producto>();
            services.AddSingleton<Cons_ProductoViewModel>();

            _serviceProvider = services.BuildServiceProvider();
        }


        private void Application_Exit(object sender, ExitEventArgs e)
        {
            // Perform tasks at application exit
        }

       




    }
}
