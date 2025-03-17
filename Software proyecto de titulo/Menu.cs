using Software_proyecto_de_titulo.Inventario;
using Software_proyecto_de_titulo.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_proyecto_de_titulo
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            butFicha.FlatStyle = FlatStyle.Flat;
            butFicha.FlatAppearance.BorderSize = 0;
            butFicha.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butInventario.FlatStyle = FlatStyle.Flat;
            butInventario.FlatAppearance.BorderSize = 0;
            butInventario.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butLogin.FlatStyle = FlatStyle.Flat;
            butLogin.FlatAppearance.BorderSize = 0;
            butLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butSalir.FlatStyle = FlatStyle.Flat;
            butSalir.FlatAppearance.BorderSize = 0;
            butSalir.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butVentas.FlatStyle = FlatStyle.Flat;
            butVentas.FlatAppearance.BorderSize = 0;
            butVentas.FlatAppearance.MouseOverBackColor = Color.Transparent;


        }

        private void butSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butFicha_Click(object sender, EventArgs e)
        {
            Trabajador.Cons_Empleado Empleado = new Trabajador.Cons_Empleado();
            Empleado.butSueld.Visible = true;
            Empleado.labelNombreUsu.Text = labelNombreUsu.Text;
            Empleado.labelTipUsu.Text = labelTipUsu.Text;
            Empleado.ShowDialog();
            this.Close();
        }

     

        private void butInventario_Click(object sender, EventArgs e)
        {

            Cons_Producto Inventario= new Cons_Producto();
            Inventario.labelNombreUsu.Text = labelNombreUsu.Text;
            Inventario.labelTipUsu.Text = labelTipUsu.Text;
            Inventario.ShowDialog();
            this.Close();

        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            LoginUsu LU = new LoginUsu();
            LU.Show();
            this.Close();
        }

        private void butVentas_Click(object sender, EventArgs e)
        {
            Cons_Vent Ventas = new Cons_Vent();
            Ventas.labelNombreUsu.Text = labelNombreUsu.Text;
            Ventas.labelTipUsu.Text = labelTipUsu.Text;
            Ventas.ShowDialog();
            this.Close();
        }

        private void butGanPerd_Click(object sender, EventArgs e)
        {

        }
    }
}
