using SoftUI.DataModel;
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
using SoftUI.MVVM.View;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Globalization;

namespace SoftUI.MVVM.View
{
    /// <summary>
    /// Interaction logic for Act_Producto.xaml
    /// </summary>
    public partial class Act_Producto : Window
    {
        public event Action RefreshGrid;
        private bool hasChanges = false;
        private Productos _data;

        public Act_Producto(Productos data)
        {
            InitializeComponent();
            _data = data;

            textIdProductos.Text = _data.IdProducto.ToString();
            textNombF.Text = _data.Nombre;
            textFechIngF.Text = _data.FechaIngreso;
            textCantF.Text = _data.Cantidad;
            textValXuF.Text = _data.ValorPorUnidad;
            textValTotF.Text = _data.ValorTotal;

        }






        private void butIng_Click(object sender, RoutedEventArgs e)
        {

            if (!int.TryParse(textIdProductos.Text, out int id))
            {
                MessageBox.Show("El ID debe ser válido.", "Error", MessageBoxButton.OK);
                return;
            }


            string Nombre = textNombF.Text;
            string FechaIngreso = textFechIngF.Text;
            string ValorPorUnidad = textValXuF.Text;
            string ValorTotal = textValTotF.Text;
            string Cantidad = textCantF.Text;


            string connectionString = "server=localhost\\SQLEXPRESS;integrated security=true;database=GESTPLUS";
            string query = "UPDATE Producto SET Nombre = @Nombre, FechaIngreso = @FechaIngreso, ValorPorUnidad = @ValorPorUnidad, ValorTotal = @ValorTotal, Cantidad = @Cantidad  WHERE IdProducto = @IdProducto";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdProducto", id);
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
                    command.Parameters.AddWithValue("@ValorPorUnidad", ValorPorUnidad);
                    command.Parameters.AddWithValue("@ValorTotal", ValorTotal);
                    command.Parameters.AddWithValue("@Cantidad", Cantidad);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                
                RefreshGrid?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error", MessageBoxButton.OK);
            }

            // Cerrar la ventana
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
        private bool IsTextAllowed(string text)
        {
            // Verifica que solo se ingrese dígitos numéricos o un solo punto decimal
            return Regex.IsMatch(text, @"^[0-9]*\.?[0-9]*$");
        }

        private void butCan_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButLim_Click(object sender, RoutedEventArgs e)
        {
            textCantF.Clear();
            textNombF.Clear();
            textFechIngF.Clear();
            textValTotF.Clear();
            textValXuF.Clear();

        }

        private void textCantF_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Verificar si el texto ingresado es un número o un punto decimal
            e.Handled = !IsTextAllowed(e.Text);
        }

        private void textValXuF_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Verificar si el texto ingresado es un número o un punto decimal
            e.Handled = !IsTextAllowed(e.Text);
        }
    }
}
