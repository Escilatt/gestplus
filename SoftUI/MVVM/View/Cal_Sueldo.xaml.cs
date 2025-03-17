using SoftUI.DataModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SoftUI.MVVM.View
{
    /// <summary>
    /// Interaction logic for Cal_Sueldo.xaml
    /// </summary>
    public partial class Cal_Sueldo : UserControl
    {
        private int clickCount = 0;
        private List<Trabajador> trabajadores = new List<Trabajador>();
        private double valorHora = 0;
        private double valorHoraExtra = 0;
        private double sueldoBruto = 0;
        private double sueldoLiquido = 0;


        public Cal_Sueldo()
        {
            InitializeComponent();
            LoadEmpleados();
        }


        private void RefreshGrid()
        {
            // Si tienes una colección que está vinculada al ItemsSource de la Grid,
            // puedes simplemente restablecer la fuente de datos, recargar o vaciar los items.

            // Si estás utilizando la colección 'trabajadores' como fuente de datos de la Grid:
            GridInv.ItemsSource = null; // Desvincula los datos
            GridInv.ItemsSource = trabajadores; // Vuelve a asignar la colección a la Grid

            // O puedes volver a llamar al método LoadEmpleados para recargar los datos de la base de datos
            LoadEmpleados();
        }


        private void ButRegre_Click(object sender, RoutedEventArgs e)
        {
            Main.Visibility = Visibility.Collapsed;

            ConsProd.Content = new HomeView();
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
                                    Rut = reader.GetString(3),
                                    VaHo = reader.GetString(12),
                                    VaHoEx = reader.GetString(13)
                                });
                            }
                        }
                    }
                }

                GridInv.ItemsSource = trabajadores;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los empleados: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }



        private void ButNueProd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GridInv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Incrementar el contador de clics
            clickCount++;

            // Si es el segundo clic, realizamos el refresh de la grid
            if (clickCount == 2)
            {
                // Llamamos a RefreshGrid para actualizar la grid (esto debe ser una función que actualice o recargue los datos de la Grid)
                RefreshGrid();

                // Reiniciar el contador después de la acción
                clickCount = 0;
            }

            // Resetear los controles
            ResetControls();

            if (GridInv.SelectedItem is Trabajador empleado)
            {
                // Cargar valores de VaHo y VaHoEx en los TextBox correspondientes
                valorHora = double.Parse(empleado.VaHo);
                valorHoraExtra = double.Parse(empleado.VaHoEx);

                // Mostrar los valores formateados en los TextBox
                textValH.Text = valorHora.ToString("N2");
                textValHX.Text = valorHoraExtra.ToString("N2");
            }
        }

        private void comboAFP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sueldoBruto > 0)
            {
                // Obtener la opción seleccionada en el ComboBox
                string selectedAFP = (comboAFP.SelectedItem as ComboBoxItem)?.Content.ToString();

                double porcentajeAFP = 0;

                // Asignar el porcentaje según la selección
                if (selectedAFP == "CUPRUM")
                {
                    porcentajeAFP = 0.07;
                }
                else if (selectedAFP == "MODELO")
                {
                    porcentajeAFP = 0.09;
                }
                else if (selectedAFP == "CAPITAL")
                {
                    porcentajeAFP = 0.12;
                }
                else if (selectedAFP == "PROVIDA")
                {
                    porcentajeAFP = 0.13;
                }

                // Calcular el descuento y asignarlo al label
                double descuentoAFP = sueldoBruto * porcentajeAFP;
                LabelDAFP.Content = descuentoAFP.ToString("C0", new CultureInfo("es-CL"));

                // Recalcular el sueldo líquido
                CalcularSueldoLiquido();
            }
        }

        private void comboISAPRE_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sueldoBruto > 0)
            {
                // Obtener la opción seleccionada en el ComboBox
                string selectedSalud = (comboISAPRE.SelectedItem as ComboBoxItem)?.Content.ToString();

                double porcentajeSalud = 0;

                // Asignar el porcentaje según la selección
                if (selectedSalud == "FONASA")
                {
                    porcentajeSalud = 0.12;
                }
                else if (selectedSalud == "CONSALUD")
                {
                    porcentajeSalud = 0.13;
                }
                else if (selectedSalud == "MASVIDA")
                {
                    porcentajeSalud = 0.14;
                }
                else if (selectedSalud == "BANMEDICA")
                {
                    porcentajeSalud = 0.15;
                }

                // Calcular el descuento y asignarlo al label
                double descuentoSalud = sueldoBruto * porcentajeSalud;
                LabelDISAPRE.Content = descuentoSalud.ToString("C0", new CultureInfo("es-CL"));

                // Recalcular el sueldo líquido
                CalcularSueldoLiquido();
            }
        }

        private void CalcularSueldoLiquido()
        {
            // Limpiar el formato CLP de las etiquetas (eliminando '$' y '.')
            string valorAFP = LabelDAFP.Content.ToString().Replace("$", "").Replace(".", "");
            string valorSalud = LabelDISAPRE.Content.ToString().Replace("$", "").Replace(".", "");

            // Intentar convertir los valores limpiados a double
            if (double.TryParse(valorAFP, out double descuentoAFP) &&
                double.TryParse(valorSalud, out double descuentoSalud))
            {
                // Calcular el sueldo líquido
                sueldoLiquido = sueldoBruto - descuentoAFP - descuentoSalud;

                // Mostrar el sueldo líquido en formato CLP
                LabelSLiquido.Content = sueldoLiquido.ToString("C0", System.Globalization.CultureInfo.CreateSpecificCulture("es-CL"));
            }
            else
            {
                // Si no se puede convertir, establecer el sueldo líquido en cero
                LabelSLiquido.Content = "0";
            }
        }


        private void CalcularSueldoBruto()
        {
            // Verificar si las cajas de texto tienen valores válidos
            if (double.TryParse(textValH.Text, out double valorHora) &&
                double.TryParse(textValHX.Text, out double valorHoraExtra) &&
                double.TryParse(textHTrabajadas.Text, out double horasTrabajadas) &&
                double.TryParse(textHExtras.Text, out double horasExtras))
            {
                // Calcular el sueldo bruto
                sueldoBruto = (valorHora * horasTrabajadas) + (valorHoraExtra * horasExtras);
                LabelSBruto.Content = sueldoBruto.ToString("C0", System.Globalization.CultureInfo.CreateSpecificCulture("es-CL"));

                // Habilitar las cajas de selección de AFP e ISAPRE
                comboAFP.IsEnabled = true;
                comboISAPRE.IsEnabled = true;
            }
            else
            {
                LabelSBruto.Content = "0";
                comboAFP.IsEnabled = false;
                comboISAPRE.IsEnabled = false;
            }
        }

        private void ResetControls()
        {

            // Reiniciar labels y controles a su valor por defecto
            LabelSBruto.Content = "0";
            LabelSLiquido.Content = "0"; // Se asegura que se restablezca el valor
            LabelDAFP.Content = "0";
            LabelDISAPRE.Content = "0";

            // Limpiar TextBoxes
            textValH.Text = "";
            textValHX.Text = "";
            textHTrabajadas.Text = "";
            textHExtras.Text = "";

            // Deshabilitar ComboBoxes inicialmente
            comboAFP.IsEnabled = false;
            comboISAPRE.IsEnabled = false;

            // Resetear los ComboBoxes
            comboAFP.SelectedIndex = -1;
            comboISAPRE.SelectedIndex = -1;

            // Forzar la actualización de la UI en caso de que los valores estén vinculados a la lógica de la UI
            // Esto es útil si estás usando data binding o algún otro patrón
            LabelSLiquido.UpdateLayout(); // Esto asegura que la UI se actualice correctamente.
        }



        private void secondclick(object sender, SelectionChangedEventArgs e)
        {
            // Asegurarse de que haya una selección
            if (GridInv.SelectedItem != null)
            {
                // Incrementar el contador de clics
                clickCount++;

                // Si es el segundo clic, actualizamos la Grid
                if (clickCount == 2)
                {
                    // Llamar a RefreshGrid para actualizar la Grid
                    RefreshGrid();

                    // Reiniciar el contador después de la acción
                    clickCount = 0;
                }
            }
        }




        private void textHTrabajadas_TextChanged(object sender, TextChangedEventArgs e)
        {
            CalcularSueldoBruto();
        }

        private void textHExtras_TextChanged(object sender, TextChangedEventArgs e)
        {
            CalcularSueldoBruto();
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Verificar si el texto ingresado es un número o un punto decimal
            e.Handled = !IsTextAllowed(e.Text);
        }


        private bool IsTextAllowed(string text)
        {
            // Verifica que solo se ingrese dígitos numéricos o un solo punto decimal
            return Regex.IsMatch(text, @"^[0-9]*\.?[0-9]*$");
        }
    }
}
