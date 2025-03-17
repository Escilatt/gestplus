using Software_proyecto_de_titulo.Trabajador;
using Software_proyecto_de_titulo.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_proyecto_de_titulo
{
    public partial class Cal_PerVent : Form
    {
        public Cal_PerVent()
        {
            InitializeComponent();
            butCalcular.FlatStyle = FlatStyle.Flat;
            butCalcular.FlatAppearance.BorderSize = 0;
            butCalcular.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butLimpiar.FlatStyle = FlatStyle.Flat;
            butLimpiar.FlatAppearance.BorderSize = 0;
            butLimpiar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butVolver.FlatStyle = FlatStyle.Flat;
            butVolver.FlatAppearance.BorderSize = 0;
            butVolver.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butSalir.FlatStyle = FlatStyle.Flat;
            butSalir.FlatAppearance.BorderSize = 0;
            butSalir.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void butCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener valores ingresados
                decimal precioComprado = Convert.ToDecimal(txtPrecioComprado.Text); // Campo de precio comprado
                decimal precioVenta = Convert.ToDecimal(txtPrecioVenta.Text); // Campo de precio de venta
                int cantidad = Convert.ToInt32(label5.Text); // Campo de cantidad vendida

                // Calcular la diferencia (por unidad)
                decimal diferencia = precioVenta - precioComprado;

                // Calcular ganancia o pérdida total (multiplicado por la cantidad)
                decimal total = diferencia * cantidad;

                // Establecer formato chileno (CLP)
                var formatoChile = new System.Globalization.CultureInfo("es-CL");

                // Mostrar resultados en los Labels con formato CLP
                if (total >= 0)
                {
                    labelganancia.Text = total.ToString("C2", formatoChile); // Ganancia total en CLP
                    labelperdida.Text = "$0,00"; // Mostrar pérdida como $0 si no hay
                }
                else
                {
                    labelganancia.Text = "$0,00"; // Mostrar ganancia como $0 si no hay
                    labelperdida.Text = Math.Abs(total).ToString("C2", formatoChile); // Pérdida total en CLP
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduce valores numéricos válidos.", "Error de Formato");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular: " + ex.Message);
            }
        }

        private void butVolver_Click(object sender, EventArgs e)
        {
            Cons_Vent consultar = new Cons_Vent();
            consultar.Show();
            this.Close();
        }

        private void butSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butLimpiar_Click(object sender, EventArgs e)
        {
            txtPrecioComprado.Clear();
            txtPrecioVenta.Clear();

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecioComprado_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten Números");
                }
            }

        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten Números");
                }
            }

        }
    }
}
