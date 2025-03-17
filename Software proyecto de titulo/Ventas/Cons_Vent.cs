using Entidad;
using Negocio;
using System;
using Software_proyecto_de_titulo.Ventas;
using Presentacion;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Datos;
using System.Drawing;

namespace Software_proyecto_de_titulo.Ventas
{
    public partial class Cons_Vent : Form

    {
        EVentas Ent = new EVentas();
        NVentas Neg = new NVentas();
        public Cons_Vent()
        {
            InitializeComponent();
            butCalcular.FlatStyle = FlatStyle.Flat;
            butCalcular.FlatAppearance.BorderSize = 0;
            butCalcular.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butSalir.FlatStyle = FlatStyle.Flat;
            butSalir.FlatAppearance.BorderSize = 0;
            butSalir.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butVol.FlatStyle = FlatStyle.Flat;
            butVol.FlatAppearance.BorderSize = 0;
            butVol.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void Cons_Vent_Load(object sender, EventArgs e)
        {
            CarDat();
        }

        public void CarDat()
        {
            try
            {
                Grid.Rows.Clear();
                List<EVentas> Listar = new NVentas().Listar();
                foreach (EVentas item in Listar)
                {
                    Grid.Rows.Add(new object[] { "", item.IdVenta, item.Nombre, item.CantidadVenta, item.TotalVenta, item.PrecioProducto, item.precio_compra, item.PrecioTotCom });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Grid.ClearSelection();
        }
        public void ResetGrid()//Funcion que restaura el datagridview
        {
            foreach (DataGridViewRow row in Grid.Rows)
            {
                row.Visible = true;
            }
        }

        private void butVol_Click(object sender, EventArgs e)
        {
            Inventario.Cons_Producto Cons = new Inventario.Cons_Producto();
            Cons.Show();
            Cons.labelNombreUsu.Text = labelNombreUsu.Text;
            Cons.labelTipUsu.Text = labelTipUsu.Text;
            this.Close();
        }

        private void butSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butCalcular_Click(object sender, EventArgs e)
        {
            Cal_PerVent pasar = new Cal_PerVent();
            pasar.label5.Text = this.Grid.CurrentRow.Cells[3].Value.ToString();
            pasar.label4.Text = this.Grid.CurrentRow.Cells[2].Value.ToString();
            pasar.label7.Text = this.Grid.CurrentRow.Cells[5].Value.ToString();
            pasar.label8.Text = this.Grid.CurrentRow.Cells[6].Value.ToString();
            pasar.label17.Text = this.Grid.CurrentRow.Cells[4].Value.ToString();
            pasar.label16.Text = this.Grid.CurrentRow.Cells[7].Value.ToString();
            pasar.Show();
            // Deshabilita ciertos botones en la ventana actual.
            this.Close();
        }

    }
}
