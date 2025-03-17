using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
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
    /// Interaction logic for LoginUsu.xaml
    /// </summary>
    public partial class LoginUsu : Window
    {
        public LoginUsu()
        {
            InitializeComponent();
        }

        public static class SessionData
        {
            // Asegúrate de que las propiedades sean públicas
            public static string username { get; set; }
            public static string TipUsu { get; set; }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton==MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void butSalLog_Click(object sender, RoutedEventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Evita que se hagan cambios innecesarios si el texto ya está correcto
            if (!string.IsNullOrEmpty(tBNom.Text) && char.IsLower(tBNom.Text[0]))
            {
                // La primera letra debe ser mayúscula y el resto en minúscula
                tBNom.Text = char.ToUpper(tBNom.Text[0]) + tBNom.Text.Substring(1).ToLower();
                tBNom.CaretIndex = tBNom.Text.Length; // Coloca el cursor al final del texto
            }
        }


        private void butIngLog_Click(object sender, RoutedEventArgs e)
        {
            {
                string username = tBNom.Text.Trim();
                string password = tBPass.Password.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Se requiere usuario y contraseña");
                    Errorlabel.Visibility = Visibility.Hidden;
                    return;
                }

                try
                {
                    using (SqlConnection connection = new SqlConnection("server=localhost\\SQLEXPRESS;integrated security=true;database=GESTPLUS"))
                    {
                        connection.Open();

                        string query = "SELECT TipUsu FROM Usu WHERE Nombre = @Nombre AND Pass = @Pass";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Nombre", username);
                            command.Parameters.AddWithValue("@Pass", password);

                            var TipUsu = command.ExecuteScalar();                       

                            if (TipUsu != null)
                            {
                              
                                
                                Errorlabel.Visibility = Visibility.Collapsed;

                                SessionData.username = username;
                                SessionData.TipUsu = TipUsu.ToString();

                                var MainWindow = new MainWindow();
                                MainWindow.Show();
                                this.Close();

                               
                            }
                            else
                            {
                                Errorlabel.Content = "Credenciales Incorrectas.";
                                Errorlabel.Visibility = Visibility.Visible; 
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Errorlabel.Content = $"An error occurred: {ex.Message}";
                    Errorlabel.Visibility = Visibility.Visible;
                }
            }
        }
        
    }
}
