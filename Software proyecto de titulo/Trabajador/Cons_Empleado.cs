using Entidad;
using Presentacion;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Drawing;

namespace Software_proyecto_de_titulo.Trabajador
{
    public partial class Cons_Empleado : Form
    {
        EEmpleado Ent = new EEmpleado();
        NEmpleado Neg = new NEmpleado();

        public Cons_Empleado()
        {
            InitializeComponent();
            butIng.FlatStyle = FlatStyle.Flat;
            butIng.FlatAppearance.BorderSize = 0;
            butIng.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butBuscar.FlatStyle = FlatStyle.Flat;
            butBuscar.FlatAppearance.BorderSize = 0;
            butBuscar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butEli.FlatStyle = FlatStyle.Flat;
            butEli.FlatAppearance.BorderSize = 0;
            butEli.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butInicio.FlatStyle = FlatStyle.Flat;
            butInicio.FlatAppearance.BorderSize = 0;
            butInicio.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butMod.FlatStyle = FlatStyle.Flat;
            butMod.FlatAppearance.BorderSize = 0;
            butMod.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butSueld.FlatStyle = FlatStyle.Flat;
            butSueld.FlatAppearance.BorderSize = 0;
            butSueld.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butSalir.FlatStyle = FlatStyle.Flat;
            butSalir.FlatAppearance.BorderSize = 0;
            butSalir.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butLimpiar.FlatStyle = FlatStyle.Flat;
            butLimpiar.FlatAppearance.BorderSize = 0;
            butLimpiar.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

     

        private void butInicio_Click(object sender, EventArgs e)
        {
            Menu Inicio = new Menu();
            Inicio.labelNombreUsu.Text = labelNombreUsu.Text;
            Inicio.labelTipUsu.Text = labelTipUsu.Text;
            Inicio.Show();
            this.Close();
        }

        private void butSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butIng_Click(object sender, EventArgs e)
        {
            string TipUsu = labelTipUsu.Text;

            if (TipUsu == "Jefe" || TipUsu == "Subjefe")
            {
                Ing_Empleado Ingresar = new Ing_Empleado();
                Ingresar.labelNombreUsu.Text = labelNombreUsu.Text;
                Ingresar.labelTipUsu.Text = labelTipUsu.Text;
                Ingresar.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Acceso denegado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Cons_Empleado_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in Grid.Columns)  //Selecciona las columnas del dataGridView
            {

                if (columna.Visible == true && columna.Name != "Selec")  //Si la variable es visible seleciona
                {
                    comboFD.Items.Add(new Filtrar() { Valor = columna.Name, Texto = columna.HeaderText });  //Agrega el campo en comboBox
                }
            }
            comboFD.DisplayMember = "Texto";  //Muestra el texto en comboBox
            comboFD.ValueMember = "Valor";   //Le da el valor en comboBox
            comboFD.SelectedIndex = 0;  //Establece el indice en comboBox
            CarDat();
        }
        public void CarDat()//Funcion que carga los datos en el datagridview
        {
            try
            {
                Grid.Rows.Clear();
                List<EEmpleado> Listar = new NEmpleado().Listar();
                foreach (EEmpleado item in Listar)
                {
                    Grid.Rows.Add(new object[] { "", item.IdTra, item.Nombre, item.Apellido, item.Rut, item.Direccion, item.FechNa, item.IdCom, item.Com.Nombre, item.Correo, item.Tel, item.Contratacion, item.Cargo, item.VaHo, item.VaHoEx });
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

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            butIng.Enabled = false;
            butSueld.Enabled = true;
            butMod.Enabled = true;
            butEli.Enabled = true;
            TextBox1.Text = this.Grid.CurrentRow.Cells[1].Value.ToString();
        }

        private void butMod_Click(object sender, EventArgs e)
        {
            string TipUsu = labelTipUsu.Text;

            if (TipUsu == "Jefe" || TipUsu == "Subjefe")
            {
                // Crea una nueva instancia de la ventana de actualización
                Act_Empleado pasar = new Act_Empleado();
            // Carga los datos del cliente seleccionado en la fila actual del DataGridView en los campos de la ventana de actualización
            pasar.TextIdTra.Text = this.Grid.CurrentRow.Cells[1].Value.ToString();
            pasar.textNombF.Text = this.Grid.CurrentRow.Cells[2].Value.ToString();
            pasar.textNombI.Text = this.Grid.CurrentRow.Cells[2].Value.ToString();
            pasar.textApellF.Text = this.Grid.CurrentRow.Cells[3].Value.ToString();
            pasar.textApellI.Text = this.Grid.CurrentRow.Cells[3].Value.ToString();
            pasar.textRutF.Text = this.Grid.CurrentRow.Cells[4].Value.ToString();
            pasar.textRutI.Text = this.Grid.CurrentRow.Cells[4].Value.ToString();
            pasar.textDirecF.Text = this.Grid.CurrentRow.Cells[5].Value.ToString();
            pasar.textDirecI.Text = this.Grid.CurrentRow.Cells[5].Value.ToString();
            pasar.textFchNF.Text = this.Grid.CurrentRow.Cells[6].Value.ToString();
            pasar.textFchNI.Text = this.Grid.CurrentRow.Cells[6].Value.ToString();
            pasar.comboComF.Text = this.Grid.CurrentRow.Cells[7].Value.ToString();
            pasar.comboRegF.Text = this.Grid.CurrentRow.Cells[8].Value.ToString();
            pasar.textRegI.Text = this.Grid.CurrentRow.Cells[8].Value.ToString();
            pasar.comboProF.Text = this.Grid.CurrentRow.Cells[8].Value.ToString();
            pasar.textProI.Text = this.Grid.CurrentRow.Cells[8].Value.ToString();
            pasar.textCorreoF.Text = this.Grid.CurrentRow.Cells[9].Value.ToString();
            pasar.textCorreoI.Text = this.Grid.CurrentRow.Cells[9].Value.ToString();
            pasar.textTel1F.Text = this.Grid.CurrentRow.Cells[10].Value.ToString();
            pasar.textTel1I.Text = this.Grid.CurrentRow.Cells[10].Value.ToString();
            pasar.textFchCF.Text = this.Grid.CurrentRow.Cells[11].Value.ToString();
            pasar.textFchCI.Text = this.Grid.CurrentRow.Cells[11].Value.ToString();
            pasar.textCargF.Text = this.Grid.CurrentRow.Cells[12].Value.ToString();
            pasar.textCargI.Text = this.Grid.CurrentRow.Cells[12].Value.ToString();
            pasar.textValHF.Text = this.Grid.CurrentRow.Cells[13].Value.ToString();
            pasar.textValHI.Text = this.Grid.CurrentRow.Cells[13].Value.ToString();
            pasar.textValHXF.Text = this.Grid.CurrentRow.Cells[14].Value.ToString();
            pasar.textValHXI.Text = this.Grid.CurrentRow.Cells[14].Value.ToString();
            // Habilita la edición de los campos en la ventana de actualización.
            pasar.labelRut.Enabled = true;
            pasar.labelNomb.Enabled = true;
            pasar.labelApellid.Enabled = true;
            pasar.labelFechn.Enabled = true;
            pasar.labelDirec.Enabled = true;
            pasar.labelCorreo.Enabled = true;
            pasar.labelTel1.Enabled = true;
            pasar.labelFechcon.Enabled = true;
            pasar.labelCarg.Enabled = true;
            pasar.labelValhora.Enabled = true;
            pasar.labelValHoraex.Enabled = true;

                pasar.labelNombreUsu.Text = labelNombreUsu.Text;
                pasar.labelTipUsu.Text = labelTipUsu.Text;
                pasar.Text = "Modificar Trabajador";
                pasar.Show();
            // Deshabilita ciertos botones en la ventana actual.
                butIng.Enabled = false;
                butEli.Enabled = false;
                butMod.Enabled = false;
                this.Close();
        }
        else
            {
                MessageBox.Show("Acceso denegado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
}

        private void butEli_Click(object sender, EventArgs e)
        {
            string TipUsu = labelTipUsu.Text;

            if (TipUsu == "Jefe" || TipUsu == "Subjefe")
            {
                var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);//Muestra un mensaje de confirmacion 
                string Mensaje = string.Empty;
                Ent.IdTra = Convert.ToInt32(TextBox1.Text);
                if (res == DialogResult.Yes)
                {
                    bool Resultado = new NEmpleado().Eliminar(Ent, out Mensaje);
                    if (Resultado)
                    {
                        MessageBox.Show("Eliminación fue realizado correctamente", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);//Si la eliminacion es realizada con exito aparece el mensaje 
                    }
                    else
                    {
                        MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (res == DialogResult.No)
                {
                    butInicio.Focus();
                }
                else if (res == DialogResult.Cancel)
                {
                    butSalir.Focus();
                }
                Grid.Rows.Clear();
                CarDat();
            }
            else
            {
                MessageBox.Show("Acceso denegado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void butBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((Filtrar)comboFD.SelectedItem).Valor.ToString();
            if (Grid.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in Grid.Rows)
                {

                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(textFiltro.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false; 
                }
            }
        }

        private void butLimpiar_Click(object sender, EventArgs e)
        {
            textFiltro.Text = "";
            CarDat();
        }

        private void textFiltro_TextChanged(object sender, EventArgs e)
        {
            textFiltro.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textFiltro.Text);
            textFiltro.SelectionStart = textFiltro.Text.Length;
        }


        private void butSueld_Click(object sender, EventArgs e)
        {
            Calculadora pasar = new Calculadora();
            pasar.label5.Text = this.Grid.CurrentRow.Cells[2].Value.ToString();
            pasar.label4.Text = this.Grid.CurrentRow.Cells[4].Value.ToString();
            pasar.label7.Text = this.Grid.CurrentRow.Cells[13].Value.ToString();
            //pasar.textValHI.Text = this.Grid.CurrentRow.Cells[13].Value.ToString();
            pasar.label9.Text = this.Grid.CurrentRow.Cells[14].Value.ToString();
            //pasar.textValHXI.Text = this.Grid.CurrentRow.Cells[14].Value.ToString();
            pasar.labelNombreUsu.Text = labelNombreUsu.Text;
            pasar.labelTipUsu.Text = labelTipUsu.Text;
            pasar.Show();
            // Deshabilita ciertos botones en la ventana actual.
            butIng.Enabled = false;
            butEli.Enabled = false;
            butMod.Enabled = false;
            this.Close();
        }
    }
}
