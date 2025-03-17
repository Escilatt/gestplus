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

namespace Software_proyecto_de_titulo.Inventario
{
    public partial class Cons_Producto : Form
    {
        EInventario Ent = new EInventario();
        NInventario Neg = new NInventario();
        public Cons_Producto()
        {
            InitializeComponent();
            butBuscar.FlatStyle = FlatStyle.Flat;
            butBuscar.FlatAppearance.BorderSize = 0;
            butBuscar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butEli.FlatStyle = FlatStyle.Flat;
            butEli.FlatAppearance.BorderSize = 0;
            butEli.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butSal.FlatStyle = FlatStyle.Flat;
            butSal.FlatAppearance.BorderSize = 0;
            butSal.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butLimpiar.FlatStyle = FlatStyle.Flat;
            butLimpiar.FlatAppearance.BorderSize = 0;
            butLimpiar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butInicio.FlatStyle = FlatStyle.Flat;
            butInicio.FlatAppearance.BorderSize = 0;
            butInicio.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butMod.FlatStyle = FlatStyle.Flat;
            butMod.FlatAppearance.BorderSize = 0;
            butMod.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butVent.FlatStyle = FlatStyle.Flat;
            butVent.FlatAppearance.BorderSize = 0;
            butVent.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butIngProd.FlatStyle = FlatStyle.Flat;
            butIngProd.FlatAppearance.BorderSize = 0;
            butIngProd.FlatAppearance.MouseOverBackColor = Color.Transparent;

        }
        private void Cons_Producto_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in Grid.Columns)
            {

                if (columna.Visible == true && columna.Name != "Selec")
                {
                    comboFD.Items.Add(new Filtrar() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            comboFD.DisplayMember = "Texto";
            comboFD.ValueMember = "Valor";
            comboFD.SelectedIndex = 0;
            CarDat();
        }
        public void CarDat()
        {
            try
            {
                Grid.Rows.Clear();
                List<EInventario> Listar = new NInventario().Listar();
                foreach (EInventario item in Listar)
                {
                    Grid.Rows.Add(new object[] { "", item.IdProducto, item.Nombre, item.Cantidad, item.FechaIngreso, item.ValorPorUnidad, item.ValorTotal });
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
        private void butIngProd_Click(object sender, EventArgs e)
        {
            Ing_Prod Ingresar = new Ing_Prod();
            Ingresar.Show(); 
            this.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Act_Prod Ingresar = new Act_Prod();
            Ingresar.textIdProductos.Text = this.Grid.CurrentRow.Cells[1].Value.ToString();
            Ingresar.textNombF.Text = this.Grid.CurrentRow.Cells[2].Value.ToString();
            Ingresar.textNombI.Text = this.Grid.CurrentRow.Cells[2].Value.ToString();
            Ingresar.textCantF.Text = this.Grid.CurrentRow.Cells[3].Value.ToString();
            Ingresar.textCantI.Text = this.Grid.CurrentRow.Cells[3].Value.ToString();
            Ingresar.textFechIngF.Text = this.Grid.CurrentRow.Cells[4].Value.ToString();
            Ingresar.textFechIngI.Text = this.Grid.CurrentRow.Cells[4].Value.ToString();
            Ingresar.textValXuF.Text = this.Grid.CurrentRow.Cells[5].Value.ToString();
            Ingresar.textValXuI.Text = this.Grid.CurrentRow.Cells[5].Value.ToString();
            Ingresar.textValTotF.Text = this.Grid.CurrentRow.Cells[6].Value.ToString();
            Ingresar.textValTotI.Text = this.Grid.CurrentRow.Cells[6].Value.ToString();
            Ingresar.labelNombreUsu.Text = labelNombreUsu.Text;
            Ingresar.labelTipUsu.Text = labelTipUsu.Text;
            Ingresar.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu Inicio = new Menu();
            Inicio.labelNombreUsu.Text = labelNombreUsu.Text;
            Inicio.labelTipUsu.Text = labelTipUsu.Text;
            Inicio.Show();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);//Muestra un mensaje de confirmacion 
                string Mensaje = string.Empty;
                Ent.IdProducto = Convert.ToInt32(textBox1.Text);
                if (res == DialogResult.Yes)
                {
                    bool Resultado = new NInventario().Eliminar(Ent, out Mensaje);
                    if (Resultado)
                    {
                        MessageBox.Show("Eliminación fue realizado correctamente", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);//Si la eliminacion es realizada con exito aparece el mensaje 
                        butIngProd.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (res == DialogResult.No)
                {
                    butSal.Focus();
                    butIngProd.Enabled = true;
                }
                else if (res == DialogResult.Cancel)
                {
                    butSal.Focus();
                    butIngProd.Enabled = true;
                }
                Grid.Rows.Clear();
            CarDat();
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {

            butIngProd.Enabled = false;
            butMod.Enabled = true;
            butEli.Enabled = true;
            butVent.Enabled = true;
            textBox1.Text = this.Grid.CurrentRow.Cells[1].Value.ToString();
        }

        private void butVent_Click(object sender, EventArgs e)
        {
            string TipUsu = labelTipUsu.Text;

            if (TipUsu == "Jefe" || TipUsu == "Subjefe")
            {
                Ing_Ventas Ventas = new Ing_Ventas();
                Ventas.textIdProductos.Text = this.Grid.CurrentRow.Cells[1].Value.ToString();
                Ventas.textNombV.Text = this.Grid.CurrentRow.Cells[2].Value.ToString();
                Ventas.textNombI.Text = this.Grid.CurrentRow.Cells[2].Value.ToString();
                Ventas.textCantACV.Text = this.Grid.CurrentRow.Cells[3].Value.ToString();
                Ventas.textCantACI.Text = this.Grid.CurrentRow.Cells[3].Value.ToString();
                Ventas.textValCom.Text = this.Grid.CurrentRow.Cells[5].Value.ToString();
                Ventas.textpreciototCom.Text = this.Grid.CurrentRow.Cells[6].Value.ToString();
                Ventas.labelNombreUsu.Text = labelNombreUsu.Text;
                Ventas.labelTipUsu.Text = labelTipUsu.Text;
                Ventas.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Acceso denegado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void textFiltro_TextChanged(object sender, EventArgs e)
        {
            textFiltro.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textFiltro.Text);
            textFiltro.SelectionStart = textFiltro.Text.Length;
        }

        private void butBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((Filtrar)comboFD.SelectedItem).Valor.ToString();  //Aplica un filtro para comboBox1
            if (Grid.Rows.Count > 0)   //Si la columna de dataGridView es 0
            {
                foreach (DataGridViewRow row in Grid.Rows)  //Fila de dataGridView
                {

                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(textFiltro.Text.Trim().ToUpper()))  //Si el texto de textbox es igual a la celda
                        row.Visible = true;  //Celda visible
                    else
                        row.Visible = false;  //Celda no visible
                }
            }
        }

        private void butLimpiar_Click(object sender, EventArgs e)
        {
            textFiltro.Text = "";
            CarDat();
        }

        private void labelFiltrar_Click(object sender, EventArgs e)
        {

        }
    }
}
