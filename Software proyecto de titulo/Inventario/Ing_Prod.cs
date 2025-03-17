using Entidad;
using Negocio;
using Software_proyecto_de_titulo.Trabajador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Software_proyecto_de_titulo.Inventario
{
    public partial class Ing_Prod : Form
    {
        EInventario Ent = new EInventario();
        NInventario Neg = new NInventario();
        public Ing_Prod()
        {
            InitializeComponent();
            butIng.FlatStyle = FlatStyle.Flat;
            butIng.FlatAppearance.BorderSize = 0;
            butIng.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butLimp.FlatStyle = FlatStyle.Flat;
            butLimp.FlatAppearance.BorderSize = 0;
            butLimp.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butSal.FlatStyle = FlatStyle.Flat;
            butSal.FlatAppearance.BorderSize = 0;
            butSal.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butVol.FlatStyle = FlatStyle.Flat;
            butVol.FlatAppearance.BorderSize = 0;
            butVol.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void Ing_Prod_Load(object sender, EventArgs e)
        {

        }
        private void CalcularSuma()
        {
            if (int.TryParse(textCant.Text, out int numero1) && int.TryParse(textValXu.Text, out int numero2))
            {
                int multi = numero1 * numero2;
                textValTot.Text = multi.ToString();
            }
            else
            {
                textValTot.Text = "";
            }
        }

        private void textNomb_TextChanged(object sender, EventArgs e)
        {
            textNomb.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textNomb.Text);
            textNomb.SelectionStart = textNomb.Text.Length;
            if (textNomb.Text.Trim() != "")
            {
                textFechIng.TabStop = true;
                textNomb.TabStop = false;

            }
            else
            {
                textFechIng.TabStop = false;
                textNomb.TabStop = true;
            }
            
        }
      

        private void butIng_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            string Mensaje = string.Empty;
            Ent.Nombre = textNomb.Text;
            Ent.FechaIngreso = textFechIng.Text;
            Ent.ValorPorUnidad = textValXu.Text;
            Ent.ValorTotal = textValTot.Text;
            Ent.Cantidad = textCant.Text;
            if (res == DialogResult.Yes)
            {
                if (Ent.IdProducto == 0)
                {
                    int Resultado = new NInventario().Ingresar(Ent, out Mensaje);
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

        private void textFechIng_TextChanged(object sender, EventArgs e)
        {
            if (textFechIng.Text.Trim() != "")
            {
                textCant.TabStop = true;
                textFechIng.TabStop = false;

            }
            else
            {
                textCant.TabStop = false;
                textFechIng.TabStop = true;
            }
           
        }

        private void textCant_TextChanged(object sender, EventArgs e)
        {
            if (textCant.Text.Trim() != "")
            {
                textValXu.TabStop = true;
                textCant.TabStop = false;

            }
            else
            {
                textValXu.TabStop = false;
                textCant.TabStop = true;
            }
            CalcularSuma();

        }
        private void textValXu_TextChanged(object sender, EventArgs e)
        {
            if (textValXu.Text.Trim() != "")
            {
                textValTot.TabStop = true;
                textValXu.TabStop = false;

            }
            else
            {
                textValTot.TabStop = false;
                textValXu.TabStop = true;
            }
            CalcularSuma();

        }    
        private void butLimp_Click(object sender, EventArgs e)
        {
            textNomb.Clear();
            textCant.Clear();
            textFechIng.Clear();
            textValXu.Clear();
            textValTot.Clear();
        }
        private void butSal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butVol_Click(object sender, EventArgs e)
        {
            Cons_Producto mos = new Cons_Producto();
            mos.Show();
            this.Close();
        }

        private void textFechIng_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten Números");
                }
            }

        }

        private void textCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten Números");
                }
            }

        }

        private void textValXu_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten Números");
                }
            }

        }

        private void textValTot_KeyPress(object sender, KeyPressEventArgs e)
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
