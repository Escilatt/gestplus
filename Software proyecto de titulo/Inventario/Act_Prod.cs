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

namespace Software_proyecto_de_titulo.Inventario
{
    public partial class Act_Prod : Form
    {
        NInventario Neg = new NInventario();
        EInventario Ent = new EInventario();
        public Act_Prod()
        {
            InitializeComponent();
            butMod.FlatStyle = FlatStyle.Flat;
            butMod.FlatAppearance.BorderSize = 0;
            butMod.FlatAppearance.MouseOverBackColor = Color.Transparent;
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

        private void Act_Prod_Load(object sender, EventArgs e)
        {

        }
        private void CalcularSuma()
        {
            if (int.TryParse(textCantF.Text, out int numero1) && int.TryParse(textValXuF.Text, out int numero2))
            {
                int multi = numero1 * numero2;
                textValTotF.Text = multi.ToString();
            }
            else
            {
                textValTotF.Text = "";
            }
        }
        private void textNombF_TextChanged(object sender, EventArgs e)
        {
            textNombF.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textNombF.Text);
            textNombF.SelectionStart = textNombF.Text.Length;
        }
        private void textCantF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros");
            }
        }
        private void textCantF_TextChanged(object sender, EventArgs e)
        {
            CalcularSuma();
        }
        private void textValXuF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros");
            }
        }
        private void textValXuF_TextChanged(object sender, EventArgs e)
        {
            CalcularSuma();
        }
        private void butMod_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            string Mensaje = string.Empty;
            Ent.IdProducto = Convert.ToInt32(textIdProductos.Text);
            Ent.Nombre = textNombF.Text;
            Ent.FechaIngreso = textFechIngF.Text;
            Ent.Cantidad = textCantF.Text;
            Ent.ValorPorUnidad = textValXuF.Text;
            Ent.ValorTotal = textValTotF.Text;
            if (res == DialogResult.Yes)
            {
                bool Resultado = new NInventario().Actualizar(Ent, out Mensaje);
                if (Resultado)
                {
                    MessageBox.Show("Actualización fue realizado correctamente", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);//Si la actualizacion es realizada con exito aparece el mensaje 
                    textNombI.Text = textNombF.Text;
                    textFechIngI.Text = textFechIngF.Text;
                    textCantI.Text = textCantF.Text;
                    textValXuI.Text = textValXuF.Text;
                    textValTotI.Text = textValTotF.Text;
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
        private void butVol_Click(object sender, EventArgs e)
        {
            Cons_Producto Cons = new Cons_Producto();            
            Cons.labelNombreUsu.Text = labelNombreUsu.Text;
            Cons.labelTipUsu.Text = labelTipUsu.Text;
            Cons.Show();
            this.Close();
        }

        private void butSal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butLimp_Click(object sender, EventArgs e)
        {
            textNombF.Clear();
            textFechIngF.Clear();
            textCantF.Clear();
            textValXuF.Clear();
            textValTotF.Clear();
        }

        private void textFechIngF_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten Números");
                }
            }

        }

        private void textValTotF_KeyPress(object sender, KeyPressEventArgs e)
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

