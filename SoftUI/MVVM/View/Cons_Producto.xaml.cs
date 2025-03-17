using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SoftUI.DataModel;
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
using SoftUI.MVVM.View;

namespace SoftUI.MVVM.View
{
  
    public partial class Cons_Producto : UserControl
    {

        private int selectedProductId;
        public event Action RefreshGrid;


        public Cons_Producto()
        {
            InitializeComponent();
            LoadProductos();
            

        }

        private void LoadProductos()
        {
            string connectionString = "server=localhost\\SQLEXPRESS;integrated security=true;database=GESTPLUS";
            string query = "SELECT IdProducto, Nombre, FechaIngreso, ValorPorUnidad, ValorTotal, Cantidad FROM Producto";
            List<Productos> productos = new List<Productos>();

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
                                
                                productos.Add(new Productos
                                {
                                    IdProducto = reader.GetInt32(0),
                                    Nombre = reader.GetString(1),
                                    FechaIngreso = reader.GetString(2),
                                    ValorPorUnidad = reader.GetString(3),
                                    ValorTotal = reader.GetString(4),
                                    Cantidad = reader.GetString(5)
                                });
                            }
                        }
                    }
                }

                
                GridInv.ItemsSource = productos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    

    public void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {

            e.Column.Width = new DataGridLength(92);

            if (e.PropertyName == "IdProducto")
            {
                e.Column.Visibility = Visibility.Collapsed;
            }
        }


        public void ButRegre_Click(object sender, RoutedEventArgs e)
        {
            Main.Visibility = Visibility.Collapsed;
            
            ConsProd.Content = new HomeView();
        }

        public void ButEdProd_Click(object sender, RoutedEventArgs e)
        {
            if (GridInv.SelectedItem is Productos selectedRow)
            {
              
                var editWindow = new Act_Producto(selectedRow);
                editWindow.RefreshGrid += LoadProductos;
                editWindow.ShowDialog(); 
            }
        }


            private void ButNueProd_Click(object sender, RoutedEventArgs e)
        {
            var editWindow = new Ing_Producto();
            editWindow.RefreshGrid += LoadProductos;
            editWindow.ShowDialog(); 
        }

        private void ButEli_Click(object sender, RoutedEventArgs e)
        {
            if (selectedProductId > 0) // Asegurarse de que hay un ID seleccionado
            {
                string connectionString = "server=localhost\\SQLEXPRESS;integrated security=true;database=GESTPLUS";
                string query = "DELETE FROM Producto WHERE IdProducto = @IdProducto";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parámetro para el ID del producto seleccionado
                        command.Parameters.AddWithValue("@IdProducto", selectedProductId);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                           
                            ResetView(); // Llamar al método para resetear la vista
                        }
                        else
                        {
                            MessageBox.Show("No se encontró un producto con ese ID.", "Error", MessageBoxButton.OK);
                        }

                        // Restablecer el ID seleccionado y desactivar botones
                        selectedProductId = 0;
                        ButEli.IsEnabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el producto: {ex.Message}", "Error", MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un producto para eliminar.", "Error", MessageBoxButton.OK);
            }
        }

        private void ResetView()
        {
            string connectionString = "server=localhost\\SQLEXPRESS;integrated security=true;database=GESTPLUS";
            string query = "SELECT * FROM Producto";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var productos = new List<Productos>();
                        while (reader.Read())
                        {
                            productos.Add(new Productos
                            {
                                IdProducto = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                FechaIngreso = reader.GetString(2),
                                ValorPorUnidad = reader.GetString(3),
                                ValorTotal = reader.GetString(4),
                                Cantidad = reader.GetString(5)
                            });
                        }

                        GridInv.ItemsSource = productos; // Actualizar la fuente de datos del DataGrid
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButton.OK);
            }
        }

        private void GridInv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ButEdProd.IsEnabled = GridInv.SelectedItem != null;

            if (GridInv.SelectedItem != null)
            {
                var selectedProduct = GridInv.SelectedItem as Productos;

                if (selectedProduct != null)
                {
                    selectedProductId = selectedProduct.IdProducto;
                    ButEli.IsEnabled = true; // Habilitar botón eliminar
                }
            }
            else
            {
                selectedProductId = 0; // Reiniciar si no hay selección
                ButEli.IsEnabled = false; // Deshabilitar botón eliminar
            }
        }
    }
}
