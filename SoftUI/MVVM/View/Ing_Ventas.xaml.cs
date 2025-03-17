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
    /// Interaction logic for Ing_Ventas.xaml
    /// </summary>
    public partial class Ing_Ventas : Window
    {

        public event Action RefreshGrid;

        public Ing_Ventas()
        {
            InitializeComponent();
        }

        private void butCan_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void butIng_Click(object sender, RoutedEventArgs e)
        {
            string Nombre = textNombF.Text;
            string CantidadVenta = textCantF1.Text;
            string PrecioProducto = textValXuF.Text;
            string TotalVenta = TexTotVent.Text;
            string PrecioCompra = textCantF.Text;  // Campo para el precio de compra
            string PrecioTotCom = TexTotVent.Text;  // Campo para el precio total de la compra

            // Validar que los campos obligatorios no estén vacíos
            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(CantidadVenta) || string.IsNullOrEmpty(PrecioProducto) ||
                string.IsNullOrEmpty(TotalVenta) || string.IsNullOrEmpty(PrecioCompra) || string.IsNullOrEmpty(PrecioTotCom))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Error", MessageBoxButton.OK);
                return;
            }

            string connectionString = "server=localhost\\SQLEXPRESS;integrated security=true;database=GESTPLUS";
            string query = "INSERT INTO Ventas (Nombre, CantidadVenta, PrecioProducto, TotalVenta, precio_compra, PrecioTotCom) " +
                           "VALUES (@Nombre, @CantidadVenta, @PrecioProducto, @TotalVenta, @PrecioCompra, @PrecioTotCom)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@CantidadVenta", CantidadVenta);
                    command.Parameters.AddWithValue("@PrecioProducto", PrecioProducto);
                    command.Parameters.AddWithValue("@TotalVenta", TotalVenta);
                    command.Parameters.AddWithValue("@PrecioCompra", PrecioCompra);
                    command.Parameters.AddWithValue("@PrecioTotCom", PrecioTotCom);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                // Aquí puedes llamar a una función que refresque el DataGrid, si es necesario
                RefreshGrid?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error", MessageBoxButton.OK);
            }

            // Cerrar la ventana después de agregar la venta
            this.Close();
        }

        private void ButLim_Click(object sender, RoutedEventArgs e)
        {
            textCantF.Clear();
            textNombF.Clear();
            textCantF1.Clear();
            TexTotVent.Clear();
            textValTotF.Clear();
            textValXuF.Clear();

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
            if (double.TryParse(textValTotF.Text, out double PrecioTotCom) &&
                double.TryParse(textValXuF.Text, out double PrecioProducto))
            {
                // Calcular el total
                double TotalVenta = PrecioTotCom * PrecioProducto;

                // Formatear el total en CLP
                TexTotVent.Text = TotalVenta.ToString("C0", new CultureInfo("es-CL"));
            }
            else
            {
                // Limpiar el total si la entrada no es válida
                TexTotVent.Clear();
            }
        }

    }
}
