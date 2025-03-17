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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SoftUI.MVVM.View
{
    /// <summary>
    /// Interaction logic for Act_Empleado.xaml
    /// </summary>
    public partial class Act_Empleado : Window
    {

        public event Action RefreshGrid;
        private Trabajador _data;

        public Act_Empleado(Trabajador data)
        {
            InitializeComponent();
            LoadComboboxData();

            _data = data;

            TextIdTra.Text = _data.IdTra.ToString();
            textNombF.Text = _data.Nombre;
            textApellF.Text = _data.Apellido;
            textDirecF.Text = _data.Direccion;
            textCorreoF.Text = _data.Correo;
            textRutF.Text = _data.Rut;
            textFchNF.Text = _data.FechNa;
            textTel1F.Text = _data.Tel;
            textFchCF.Text = _data.Contratacion;
            textCargF.Text = _data.Cargo;
            textValHF.Text = _data.VaHo;
            textValHXF.Text = _data.VaHoEx;





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

                    // Vaciar los ComboBox de provincia y comuna
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
                // Limpiar las comunas cuando se cambie de región
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

        private void ButIng_Click(object sender, RoutedEventArgs e)
        {

        }

        

        private void ButIng_Click_1(object sender, RoutedEventArgs e)
        {
            // Validar campos
            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios antes de continuar.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Aquí continúa el código existente para guardar los datos
            if (!int.TryParse(TextIdTra.Text, out int id))
            {
                MessageBox.Show("El ID debe ser válido.", "Error", MessageBoxButton.OK);
                return;
            }

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
            int IdCom = (comboCom.SelectedItem as Comuna)?.IdCom ?? 0;

            if (IdCom == 0)
            {
                MessageBox.Show("Debe seleccionar una comuna.", "Error", MessageBoxButton.OK);
                return;
            }

            string connectionString = "server=localhost\\SQLEXPRESS;integrated security=true;database=GESTPLUS";
            string query = @"
       UPDATE Trabajador 
       SET 
           Nombre = @Nombre, 
           Apellido = @Apellido, 
           Rut = @Rut, 
           Direccion = @Direccion, 
           IdCom = @IdCom, 
           FechNa = @FechNa, 
           Correo = @Correo, 
           Tel = @Telefono, 
           Contratacion = @Contratacion, 
           Cargo = @Cargo, 
           VaHo = @ValorHora, 
           VaHoEx = @ValorHoraExtra
       WHERE IdTra = @IdTra";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdTra", id);
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

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Datos del trabajador actualizados con éxito.", "Éxito", MessageBoxButton.OK);
                RefreshGrid?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar los datos: {ex.Message}", "Error", MessageBoxButton.OK);
            }

            this.Close();
        }

        private void butCan_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButLim_Click(object sender, RoutedEventArgs e)
        {
            LimpiarFormulario();
            MessageBox.Show("Formulario limpiado.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
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

        private void LimpiarFormulario()
        {
            // Método auxiliar para limpiar todos los controles en la ventana
            ClearControls(this);
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

        private void textTel1F_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Verificar si el texto ingresado es un número o un punto decimal
            e.Handled = !IsTextAllowed(e.Text);
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

        private void textValHF_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Verificar si el texto ingresado es un número o un punto decimal
            e.Handled = !IsTextAllowed(e.Text);
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


        private void textRutF_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

