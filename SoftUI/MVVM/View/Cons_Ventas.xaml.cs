using SoftUI.DataModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace SoftUI.MVVM.View
{
    /// <summary>
    /// Interaction logic for Cons_Ventas.xaml
    /// </summary>
    public partial class Cons_Ventas : UserControl
    {
        public Cons_Ventas()
        {
            InitializeComponent();
            LoadProductos();
        }

        private void ButRegre_Click(object sender, RoutedEventArgs e)
        {
            Main.Visibility = Visibility.Collapsed;

            ConsProd.Content = new HomeView();
        }

        private void LoadProductos()
        {
            string connectionString = "server=localhost\\SQLEXPRESS;integrated security=true;database=GESTPLUS";
            string query = "SELECT IdVenta, Nombre, CantidadVenta, TotalVenta, PrecioProducto, precio_compra, PrecioTotCom FROM Ventas";
            List<Ventas> productos = new List<Ventas>();

            try
            {
                // Establecer la conexión con la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                productos.Add(new Ventas
                                {
                                    IdVenta = reader.GetInt32(0),
                                    Nombre = reader.GetString(1),
                                    CantidadVenta = reader.GetString(2),
                                    TotalVenta = reader.GetString(3),
                                    PrecioProducto = reader.GetString(4),
                                    precio_compra = reader.GetString(5),
                                    PrecioTotCom = reader.GetString(6)
                                });
                            }
                        }
                    }
                }


                GridVent.ItemsSource = productos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }



        private void ButNueProd_Click(object sender, RoutedEventArgs e)
        {
            var editWindow = new Ing_Ventas();
            editWindow.RefreshGrid += LoadProductos;
            editWindow.ShowDialog();
        }

        private void ButEdProd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButEli_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GridInv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Verifica si hay una fila seleccionada
            if (GridVent.SelectedItem is Ventas venta)
            {
                // Asumiendo que la clase 'Venta' tiene propiedades 'PrecioProducto' y 'PrecioCompra'
                ValCom.Content = $": {venta.precio_compra:C}";
                ValVent.Content = $": {venta.PrecioProducto:C}";
            }
        }

        private void TexCompra_TextChanged(object sender, TextChangedEventArgs e)
        {
            CalcularGananciaYPerdida();
        }

        private void TexVenta_TextChanged(object sender, TextChangedEventArgs e)
        {
            CalcularGananciaYPerdida();
        }


        private void CalcularGananciaYPerdida()
        {
            // Intentar obtener los valores de los TextBox
            if (double.TryParse(TexVenta.Text, out double precioVenta) &&
                double.TryParse(TexCompra.Text, out double precioCompra))
            {
                // Calcular ganancia y pérdida
                double ganancia = precioVenta - precioCompra;
                double perdida = precioCompra - precioVenta;

                // Actualizar las labels
                if (ganancia > 0)
                {
                    LabGan.Content = $"{ganancia:C}";
                    LabPer.Content = "$0";
                }
                else if (perdida > 0)
                {
                    LabGan.Content = "$0";
                    LabPer.Content = $"{perdida:C}";
                }
                else
                {
                    LabGan.Content = "$0";
                    LabPer.Content = "$0";
                }
            }
            else
            {
                // Si no se puede convertir a número, restablecer los labels
                LabGan.Content = "$0";
                LabPer.Content = "$0";
            }
        }
    }
}
