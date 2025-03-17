using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
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
using System.Windows.Shapes;

namespace SoftUI.MVVM.View
{
    /// <summary>
    /// Interaction logic for Ing_Producto.xaml
    /// </summary>
    public partial class Ing_Producto : Window
    {

        public event Action RefreshGrid;

        public Ing_Producto()
        {
            InitializeComponent();
        }

        private void butIng_Click(object sender, RoutedEventArgs e)
        {
            string Nombre = textNombF.Text;
            string FechaIngreso = textFechIngF.Text;
            string ValorPorUnidad = textValXuF.Text;
            string ValorTotal = textValTotF.Text;
            string Cantidad = textCantF.Text;

            // Validar que los campos obligatorios no estén vacíos
            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(FechaIngreso) || string.IsNullOrEmpty(ValorPorUnidad) ||
                string.IsNullOrEmpty(ValorTotal) || string.IsNullOrEmpty(Cantidad))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Error", MessageBoxButton.OK);
                return;
            }

            string connectionString = "server=localhost\\SQLEXPRESS;integrated security=true;database=GESTPLUS";
            string query = "INSERT INTO Producto (Nombre, FechaIngreso, ValorPorUnidad, ValorTotal, Cantidad) " +
                           "VALUES (@Nombre, @FechaIngreso, @ValorPorUnidad, @ValorTotal, @Cantidad)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
                    command.Parameters.AddWithValue("@ValorPorUnidad", ValorPorUnidad);
                    command.Parameters.AddWithValue("@ValorTotal", ValorTotal);
                    command.Parameters.AddWithValue("@Cantidad", Cantidad);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                

                // Aquí puedes llamar a una función que refresque el DataGrid, si es necesario
                RefreshGrid?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Ingresado", MessageBoxButton.OK);
            }

            // Cerrar la ventana después de agregar el producto
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var fadeInAnimation = new System.Windows.Media.Animation.DoubleAnimation
            {
                From = 0.0, // Comienza completamente transparente
                To = 1.0,   // Termina completamente opaca
                Duration = TimeSpan.FromSeconds(0.3) // Duración de 0.5 segundos
            };

            this.BeginAnimation(Window.OpacityProperty, fadeInAnimation);
        }


        private void butCan_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OnValueChanged(object sender, TextChangedEventArgs e)
        {
            // Validar si los valores son números válidos
            if (double.TryParse(textCantF.Text, out double cantidad) &&
                double.TryParse(textValXuF.Text, out double valorPorUnidad))
            {
                // Calcular el total
                double total = cantidad * valorPorUnidad;

                // Formatear el total en CLP
                textValTotF.Text = total.ToString("C0", new CultureInfo("es-CL"));
            }
            else
            {
                // Limpiar el total si la entrada no es válida
                textValTotF.Clear();
            }
        }


        private void ButLim_Click(object sender, RoutedEventArgs e)
        {
            textCantF.Clear();
            textNombF.Clear();
            textFechIngF.Clear();
            textValTotF.Clear();
            textValXuF.Clear();

        }
    }
}
