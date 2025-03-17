using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using SoftUI.MVVM.View;
using SoftUI.MVVM.ViewModel;
using static SoftUI.MVVM.View.LoginUsu;
using static SoftUI.MVVM.View.HomeView;
using System.Security.Cryptography;

namespace SoftUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer;
        public MainWindow()
        {
            InitializeComponent();
            Home.Content = new HomeView();
            usunomlabel.Content = $"{SessionData.username}";
            tipusulabel.Content = $"{SessionData.TipUsu}";
            StartClock();

        }

        private void StartClock()
        {
            // Crear un DispatcherTimer para actualizar la hora cada segundo
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1); // Actualizar cada segundo
            _timer.Tick += Timer_Tick; // Asociar el evento Tick
            _timer.Start(); // Iniciar el temporizador
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Actualizar el texto del Label con la fecha y hora actual
            DateTimeLabel.Content = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }
        private void butacer_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("GESTPLUS FREE\r\n\r\nVersión: 1.5\r\nDesarrollado por Lukas Miranda, Benjamin Avalos y Victor Guerra\r\nCopyright © 2024 GESTPLUS Team. Todos los derechos reservados.\r\n\r\nGESTPLUS es una herramienta de gestión que te permite organizar tareas, proyectos y clientes de manera eficiente. Con características como la gestión de inventarios, trabajadores y función de calculo de salarios, nuestro software te ayuda a optimizar tu flujo de trabajo de manera simple y cómoda.\r\n\r\nEmail soporte: lukasmir99@gmail.com\r\n", "Acerca de GESTPLUS");
        }
    }
}
