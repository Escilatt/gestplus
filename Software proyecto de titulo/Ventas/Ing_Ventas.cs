using Datos;
using Entidad;
using Negocio;
using Software_proyecto_de_titulo.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_proyecto_de_titulo.Ventas
{
    public partial class Ing_Ventas : Form
    {
        NVentas Neg = new NVentas();
        EVentas Ent = new EVentas();
        public Ing_Ventas()
        {
            InitializeComponent();
            butIng.FlatStyle = FlatStyle.Flat;
            butIng.FlatAppearance.BorderSize = 0;
            butIng.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butLimp.FlatStyle = FlatStyle.Flat;
            butLimp.FlatAppearance.BorderSize = 0;
            butLimp.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butVol.FlatStyle = FlatStyle.Flat;
            butVol.FlatAppearance.BorderSize = 0;
            butVol.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butSal.FlatStyle = FlatStyle.Flat;
            butSal.FlatAppearance.BorderSize = 0;
            butSal.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void Ing_Ventas_Load(object sender, EventArgs e)
        {

        }

        private void butVol_Click(object sender, EventArgs e)
        {
            Cons_Producto Cons = new Cons_Producto();
            Cons.Show();
            Cons.labelNombreUsu.Text = labelNombreUsu.Text;
            Cons.labelTipUsu.Text = labelTipUsu.Text;
            this.Close();
        }

        private void butSal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CalcularSuma()
        {
            if (int.TryParse(textCantV.Text, out int numero1) && int.TryParse(textPrec.Text, out int numero2))
            {
                int multi = numero1 * numero2;
                textTot.Text = multi.ToString();
            }
            else
            {
                textTot.Text = "";
            }
        }

        private void textCantV_TextChanged(object sender, EventArgs e)
        {
            CalcularSuma();
        }

        private void textPrec_TextChanged(object sender, EventArgs e)
        {
            CalcularSuma();
        }

        private void butIng_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            string Mensaje = string.Empty;
            Ent.Nombre = textNombV.Text;
            Ent.CantidadVenta = textCantV.Text;
            Ent.TotalVenta = textTot.Text;
            Ent.PrecioProducto = textPrec.Text;
            Ent.precio_compra = textValCom.Text;
            Ent.PrecioTotCom = textpreciototCom.Text;

            if (res == DialogResult.Yes)
            {
                if (Ent.IdVenta == 0)
                {
                    int Resultado = new NVentas().Ingresar(Ent, out Mensaje);
                    if (Resultado != 0)
                    {
                        MessageBox.Show("Ingreso fue realizado correctamente", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);//Si el ingreso fue exitoso aparece el mensaje 
                        butLimp.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show(Mensaje);
                    }
                }
                else if (res == DialogResult.No)
                {
                    butVol.Focus();
                }
                else if (res == DialogResult.Cancel)
                {
                    butSal.Focus();
                }
            }
        }

        private void butLimp_Click(object sender, EventArgs e)
        {
            textTot.Clear();
            textPrec.Clear();
            textCantV.Clear();
        }

        private void textValCom_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten Números");
                }
            }

        }

        private void textCantV_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten Números");
                }
            }

        }

        private void textPrec_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten Números");
                }
            }

        }

        private void textTot_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten Números");
                }
            }

        }

        private void textCantACV_KeyPress(object sender, KeyPressEventArgs e)
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
