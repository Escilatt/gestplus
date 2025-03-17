using SoftUI.DataModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SoftUI.MVVM.View
{
   
    public partial class Ing_Empleado : Window
    {
        public event Action RefreshGrid;

        public Ing_Empleado()
        {
            InitializeComponent();
            LoadComboboxData();
            this.Loaded += (s, e) => LoadComboboxData();

        }


        private void LoadComboboxData()
        {
            string connectionString = "server=localhost\\SQLEXPRESS;integrated security=true;database=GESTPLUS";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Cargar Regiones
                    string queryReg = "SELECT IdReg, Nombre FROM LReg";
                    using (SqlCommand command = new SqlCommand(queryReg, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            var regiones = new List<Region>();
                            while (reader.Read())
                            {
                                regiones.Add(new Region
                                {
                                    IdReg = reader.GetInt32(0),
                                    Nombre = reader.GetString(1)
                                });
                            }
                            comboReg.ItemsSource = regiones;
                            comboReg.DisplayMemberPath = "Nombre";
                            comboReg.SelectedValuePath = "IdReg";
                        }
                    }

                    
                    comboPro.ItemsSource = null;
                    comboCom.ItemsSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las regiones: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void comboReg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboReg.SelectedValue is int selectedRegionId)
            {
                LoadProvinciasByRegion(selectedRegionId);
            }
        }

        private void LoadProvinciasByRegion(int regionId)
        {
            string connectionString = "server=localhost\\SQLEXPRESS;integrated security=true;database=GESTPLUS";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT IdPro, Nombre FROM LPro WHERE IdReg = @RegionId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RegionId", regionId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            var provincias = new List<Provincia>();
                            while (reader.Read())
                            {
                                provincias.Add(new Provincia
                                {
                                    IdPro = reader.GetInt32(0),
                                    Nombre = reader.GetString(1)
                                });
                            }
                            comboPro.ItemsSource = provincias;
                            comboPro.DisplayMemberPath = "Nombre";
                            comboPro.SelectedValuePath = "IdPro";
                        }
                    }
                }
               
                comboCom.ItemsSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar provincias: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void comboPro_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboPro.SelectedValue is int selectedProvinceId)
            {
                LoadComunasByProvince(selectedProvinceId);
            }
        }

        private bool EsRutValido(string rut)
        {
            if (string.IsNullOrEmpty(rut))
                return false;

            // Eliminar puntos y guión
            rut = rut.Replace(".", "").Replace("-", "");

            // Validar formato mínimo
            if (rut.Length < 8)
                return false;

            // Dividir en número y dígito verificador
            string numero = rut.Substring(0, rut.Length - 1);
            char digitoVerificador = rut[rut.Length - 1];

            // Validar que la parte numérica sea válida
            if (!int.TryParse(numero, out int rutNumerico))
                return false;

            // Calcular el dígito verificador esperado
            int suma = 0;
            int multiplicador = 2;

            for (int i = numero.Length - 1; i >= 0; i--)
            {
                suma += (numero[i] - '0') * multiplicador;
                multiplicador = multiplicador == 7 ? 2 : multiplicador + 1;
            }

            int residuo = 11 - (suma % 11);
            char digitoEsperado;

            if (residuo == 11)
                digitoEsperado = '0';
            else if (residuo == 10)
                digitoEsperado = 'K';
            else
                digitoEsperado = (char)('0' + residuo);

            // Comparar el dígito verificador
            return char.ToUpper(digitoVerificador) == digitoEsperado;
        }



        private void LoadComunasByProvince(int provinceId)
        {
            string connectionString = "server=localhost\\SQLEXPRESS;integrated security=true;database=GESTPLUS";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT IdCom, Nombre FROM LCom WHERE IdPro = @ProvinceId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProvinceId", provinceId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            var comunas = new List<Comuna>();
                            while (reader.Read())
                            {
                                comunas.Add(new Comuna
                                {
                                    IdCom = reader.GetInt32(0),
                                    Nombre = reader.GetString(1)
                                });
                            }
                            comboCom.ItemsSource = comunas;
                            comboCom.DisplayMemberPath = "Nombre";
                            comboCom.SelectedValuePath = "IdCom";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar comunas: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }




        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var fadeInAnimation = new System.Windows.Media.Animation.DoubleAnimation
            {
                From = 0.0, 
                To = 1.0,  
                Duration = TimeSpan.FromSeconds(0.3) 
            };

            this.BeginAnimation(Window.OpacityProperty, fadeInAnimation);
        }

        private void butCan_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButIng_Click(object sender, RoutedEventArgs e)
        {
            // Validar que todos los campos estén llenos
            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios antes de continuar.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Obtener valores de los campos
            string Nombre = textNombF.Text;
            string Apellido = textApellF.Text;
            string Rut = textRutF.Text;
            string Direccion = textDirecF.Text;
            string Fecha = textFchNF.Text;
            string Contratacion = textFchCF.Text;
            string Correo = textCorreoF.Text;
            string Telefono = textTel1F.Text;
            string Cargo = textCargF.Text;
            string ValorHora = textValHF.Text;
            string ValorHoraExtra = textValHXF.Text;

            // Obtener la ID de la comuna seleccionada
            int IdCom = (comboCom.SelectedItem as Comuna)?.IdCom ?? 0;

            // Verificar que una comuna haya sido seleccionada
            if (IdCom == 0)
            {
                MessageBox.Show("Debe seleccionar una comuna.", "Error", MessageBoxButton.OK);
                return;
            }

            // Cadena de conexión
            string connectionString = "server=localhost\\SQLEXPRESS;integrated security=true;database=GESTPLUS";

            // Consulta SQL para insertar un nuevo trabajador
            string query = @"
INSERT INTO Trabajador (Nombre, Apellido, Rut, Direccion, IdCom, FechNa, Correo, Tel, Contratacion, Cargo, VaHo, VaHoEx)
VALUES (@Nombre, @Apellido, @Rut, @Direccion, @IdCom, @FechNa, @Correo, @Telefono, @Contratacion, @Cargo, @ValorHora, @ValorHoraExtra)";

            try
            {
                // Ejecutar la consulta de inserción en la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar los parámetros
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Apellido", Apellido);
                    command.Parameters.AddWithValue("@Rut", Rut);
                    command.Parameters.AddWithValue("@Direccion", Direccion);
                    command.Parameters.AddWithValue("@IdCom", IdCom);
                    command.Parameters.AddWithValue("@FechNa", Fecha);
                    command.Parameters.AddWithValue("@Correo", Correo);
                    command.Parameters.AddWithValue("@Telefono", Telefono);
                    command.Parameters.AddWithValue("@Contratacion", Contratacion);
                    command.Parameters.AddWithValue("@Cargo", Cargo);
                    command.Parameters.AddWithValue("@ValorHora", ValorHora);
                    command.Parameters.AddWithValue("@ValorHoraExtra", ValorHoraExtra);

                    // Abrir la conexión y ejecutar el comando
                    connection.Open();
                    command.ExecuteNonQuery();
                }

                // Mostrar mensaje de éxito y actualizar la vista
                MessageBox.Show("Trabajador ingresado con éxito.", "Éxito", MessageBoxButton.OK);
                RefreshGrid?.Invoke();
            }
            catch (Exception ex)
            {
                // Manejar errores y mostrar mensaje
                MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error", MessageBoxButton.OK);
            }

            // Cerrar la ventana después de insertar los datos
            this.Close();
        }


        private void ButLim_Click(object sender, RoutedEventArgs e)
        {
            // Método auxiliar para limpiar todos los controles en la ventana
            ClearControls(this);
        }

        private void LimpiarFormulario()
        {
            // Método auxiliar para limpiar todos los controles en la ventana
            ClearControls(this);
        }


        private bool ValidarCampos()
        {
            // Verifica si alguno de los TextBox o ComboBox requeridos está vacío
            if (string.IsNullOrWhiteSpace(textNombF.Text) ||
                string.IsNullOrWhiteSpace(textApellF.Text) ||
                string.IsNullOrWhiteSpace(textDirecF.Text) ||
                string.IsNullOrWhiteSpace(textCorreoF.Text) ||
                string.IsNullOrWhiteSpace(textRutF.Text) ||
                string.IsNullOrWhiteSpace(textFchNF.Text) ||
                string.IsNullOrWhiteSpace(textTel1F.Text) ||
                string.IsNullOrWhiteSpace(textFchCF.Text) ||
                string.IsNullOrWhiteSpace(textCargF.Text) ||
                string.IsNullOrWhiteSpace(textValHF.Text) ||
                string.IsNullOrWhiteSpace(textValHXF.Text) ||
                comboReg.SelectedIndex == -1 ||
                comboPro.SelectedIndex == -1 ||
                comboCom.SelectedIndex == -1)
            {
                // Si algún campo está vacío, retorna false
                return false;
            }

            // Si todos los campos requeridos están llenos, retorna true
            return true;
        }




        private void ClearControls(DependencyObject parent)
        {
            // Recorrer todos los elementos hijos del contenedor principal
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);

                if (child is TextBox textBox)
                {
                    // Limpia el contenido del TextBox
                    textBox.Text = string.Empty;
                }
                else if (child is ComboBox comboBox)
                {
                    // Limpia el contenido del ComboBox
                    comboBox.SelectedIndex = -1; // Deselecciona cualquier elemento
                    comboBox.Text = string.Empty; // Limpia el texto visible
                }
                else if (child is CheckBox checkBox)
                {
                    // Deseleccionar cualquier CheckBox
                    checkBox.IsChecked = false;
                }
                else
                {
                    // Si el control es un contenedor, llama recursivamente al método
                    ClearControls(child);
                }
            }

        }

        private bool IsTextAllowed(string text)
        {
            // Verifica que solo se ingrese dígitos numéricos o un solo punto decimal
            return Regex.IsMatch(text, @"^[0-9@./+]*$");
        }


        private void textFchNF_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Verificar si el texto ingresado es un número o un punto decimal
            e.Handled = !IsTextAllowed(e.Text);
        }

        private void textValHF_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Verificar si el texto ingresado es un número o un punto decimal
            e.Handled = !IsTextAllowed(e.Text);
        }


        private void textFchCF_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Verificar si el texto ingresado es un número o un punto decimal
            e.Handled = !IsTextAllowed(e.Text);
        }

        private void textValHXF_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Verificar si el texto ingresado es un número o un punto decimal
            e.Handled = !IsTextAllowed(e.Text);
        }

        private void textTel1F_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Verificar si el texto ingresado es un número o un punto decimal
            e.Handled = !IsTextAllowed(e.Text);
        }

        private void textNombF_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Verificar si el texto ingresado contiene solo letras
            e.Handled = !IsTextOnlyLetters(e.Text);
        }


        private bool IsTextOnlyLetters(string text)
        {
            // Método que verifica si el texto tiene solo letras
            foreach (char c in text)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }


        private void textApellF_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Verificar si el texto ingresado contiene solo letras
            e.Handled = !IsTextOnlyLetters(e.Text);
        }

        private void textCargF_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Verificar si el texto ingresado contiene solo letras
            e.Handled = !IsTextOnlyLetters(e.Text);
        }

        private bool isRutInvalid = false;

        private void textRutF_LostFocus(object sender, RoutedEventArgs e)
        {
            string rut = textRutF.Text.Trim();

            // Verifica si el RUT es válido
            if (!EsRutValido(rut))
            {
                // Si no es válido y no se ha mostrado el mensaje antes
                if (!isRutInvalid)
                {
                    MessageBox.Show("El RUT ingresado no es válido. Por favor, inténtelo nuevamente.",
                                     "RUT Inválido", MessageBoxButton.OK, MessageBoxImage.Warning);

                    // Limpiar el campo y poner el flag a true para evitar que se vuelva a mostrar el mensaje
                    textRutF.Clear();
                    textRutF.Focus();
                    isRutInvalid = true;
                }
            }
            else
            {
                // Si el RUT es válido, restablecer el flag
                isRutInvalid = false;
            }
        }

    }
}

