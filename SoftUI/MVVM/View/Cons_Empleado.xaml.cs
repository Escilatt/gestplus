
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
    /// Interaction logic for Cons_Empleado.xaml
    /// </summary>
    public partial class Cons_Empleado : UserControl
    {

        private int selectedEmployeeId;
        public event Action RefreshGrid;

        public Cons_Empleado()
        {
            InitializeComponent();
            LoadEmpleados();
        }


        private void LoadEmpleados()
        {
            string connectionString = "server=localhost\\SQLEXPRESS;integrated security=true;database=GESTPLUS";
            string query = "EXEC dbo.JoinComuna";  

            List<Trabajador> trabajadores = new List<Trabajador>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                trabajadores.Add(new Trabajador
                                {
                                    IdTra = reader.GetInt32(0),
                                    Nombre = reader.GetString(1),
                                    Apellido = reader.GetString(2),
                                    Rut = reader.GetString(3),
                                    Direccion = reader.GetString(4),
                                    FechNa = reader.GetString(5),
                                    IdCom = reader.GetInt32(6),
                                    NombreComuna = reader.GetString(7),  
                                    Correo = reader.GetString(8),
                                    Tel = reader.GetString(9),
                                    Contratacion = reader.GetString(10),
                                    Cargo = reader.GetString(11),
                                    VaHo = reader.GetString(12),
                                    VaHoEx = reader.GetString(13)
                                });
                            }
                        }
                    }
                }

                GridEmp.ItemsSource = trabajadores;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los empleados: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }






        private void ButEdEmp_Click(object sender, RoutedEventArgs e)
        {
            if (GridEmp.SelectedItem is Trabajador selectedRow)
            {

                var editWindow = new Act_Empleado(selectedRow);
                editWindow.RefreshGrid += LoadEmpleados;
                editWindow.ShowDialog();
            }
        }

        private void ButNueEmp_Click(object sender, RoutedEventArgs e)
        {
            var editWindow = new Ing_Empleado();
            editWindow.RefreshGrid += LoadEmpleados;
            editWindow.ShowDialog();
        }

        private void ButEli_Click(object sender, RoutedEventArgs e)
        {
            if (selectedEmployeeId > 0) 
            {
                string connectionString = "server=localhost\\SQLEXPRESS;integrated security=true;database=GESTPLUS";
                string query = "DELETE FROM Trabajador WHERE IdTra = @IdTra";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@IdTra", selectedEmployeeId);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            

                            ResetView(); 
                        }
                        else
                        {
                            MessageBox.Show("No se encontró un empleado con ese ID.", "Error", MessageBoxButton.OK);
                        }

                       
                        selectedEmployeeId = 0;
                        ButEli.IsEnabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el empleado: {ex.Message}", "Error", MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un empleado para eliminar.", "Error", MessageBoxButton.OK);
            }
        }

        private void ButRegre_Click(object sender, RoutedEventArgs e)
        {
            Main.Visibility = Visibility.Collapsed;

            ConsEmp.Content = new HomeView();
        }

        private void GridEmp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ButEdEmp.IsEnabled = GridEmp.SelectedItem != null;

            if (GridEmp.SelectedItem != null)
            {
                var selectedProduct = GridEmp.SelectedItem as Trabajador;

                if (selectedProduct != null)
                {
                    selectedEmployeeId = selectedProduct.IdTra;
                    ButEli.IsEnabled = true; 
                }
            }
            else
            {
                selectedEmployeeId = 0; 
                ButEli.IsEnabled = false;
            }
        }

        private void ResetView()
        {
            string connectionString = "server=localhost\\SQLEXPRESS;integrated security=true;database=GESTPLUS";
            string query = "SELECT * FROM Trabajador";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var empleados = new List<Trabajador>();
                        while (reader.Read())
                        {
                            empleados.Add(new Trabajador
                            {
                                IdTra = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Apellido = reader.GetString(2),
                                Rut = reader.GetString(3),
                                Direccion = reader.GetString(4),
                                IdCom = reader.GetInt32(5),
                                FechNa = reader.GetString(6),
                                Correo = reader.GetString(7),
                                Tel = reader.GetString(8),
                                Contratacion = reader.GetString(9),
                                Cargo = reader.GetString(10),
                                VaHo = reader.GetString(11),
                                VaHoEx = reader.GetString(12)
                            });
                        }

                        GridEmp.ItemsSource = empleados; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButton.OK);
            }
        }



    }
}
