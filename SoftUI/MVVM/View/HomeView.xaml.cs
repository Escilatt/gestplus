using System;
using SoftUI;
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
using SoftUI.MVVM.ViewModel;

namespace SoftUI.MVVM.View
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();

        }

        private void ButProd_Click(object sender, RoutedEventArgs e)
        {
            Main.Visibility = Visibility.Collapsed;

            MainContent.Content = new Cons_Ventas();
        }


        private void ButEmp_Click(object sender, RoutedEventArgs e)
        {
            Main.Visibility = Visibility.Collapsed;

            MainContent.Content = new Cons_Empleado();
        }

        private void ButSal_Click(object sender, RoutedEventArgs e)
        {
            Main.Visibility = Visibility.Collapsed;

            MainContent.Content = new Cal_Sueldo();
        }

        private void ButCerr_Click(object sender, RoutedEventArgs e)
        {
            // Obtener la ventana contenedora (la ventana principal que contiene el UserControl)
            Window parentWindow = Window.GetWindow(this);

            // Mostrar mensaje de confirmación
            var result = MessageBox.Show("¿Estás seguro de que deseas cerrar sesión?", "Cerrar Sesión", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    if (parentWindow != null)
                    {
                        // Cerrar la ventana actual
                        parentWindow.Close();

                        // Abrir la ventana de login
                        var LoginUsu = new LoginUsu();
                        LoginUsu.Show();
                    }
                }

                // Cerrar el menú contextual si está abierto (suponiendo que es un ContextMenu)
                if (sender is MenuItem menuItem && menuItem.Parent is ContextMenu contextMenu)
                {
                    contextMenu.IsOpen = false;
                }
            }

        private void ButInv_Click(object sender, RoutedEventArgs e)
        {
            Main.Visibility = Visibility.Collapsed;
            
            MainContent.Content = new Cons_Producto();
        }
    }
}
