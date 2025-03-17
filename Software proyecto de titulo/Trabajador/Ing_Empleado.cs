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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Application = System.Windows.Forms.Application;

namespace Presentacion
{
    public partial class Ing_Empleado : Form
    {
        EEmpleado Ent = new EEmpleado();
        NEmpleado Neg = new NEmpleado();
        NLocCom NegCom = new NLocCom();
        NLocPro NegPro = new NLocPro();
        NLocReg NegReg = new NLocReg();
        public Ing_Empleado()
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void CargaCBReg()
        {
            comboReg.DisplayMember = "Nombre";    //Muestra el texto en comboBox
            comboReg.ValueMember = "IdReg";  //Le da el valor en comboBox
            comboReg.DataSource = NegReg.Listar();  //Establece el indice en comboBox
        }

        private void CargaCBPro()
        {
            int IdReg = Convert.ToInt32(comboReg.SelectedValue);  //Una variable de valor entero se convierte en un valor entero en comboBox
            DataTable dt = NegPro.Filtrar(IdReg);  //La variable de una tabla de datos es igual al campo que llama a la funcion
            comboPro.DisplayMember = "Nombre";    //Muestra nombre en comboBox
            comboPro.ValueMember = "IdPro";   //Le da el valor en comboBox
            comboPro.DataSource = dt;   //La variable se muestra en comboBox
        }

        private void CargaCBCom()
        {
            int IdPro = Convert.ToInt32(comboPro.SelectedValue); //Una variable de valor entero se convierte en un valor entero en comboBox
            DataTable dt = NegCom.Filtrar(IdPro); //La variable de una tabla de datos es igual al campo que llama a la funcion
            comboCom.DisplayMember = "Nombre"; //Muestra nombre en comboBox
            comboCom.ValueMember = "IdCom";  //Le da el valor en comboBox
            comboCom.DataSource = dt;   //La variable se muestra en comboBox
        }

        public void HabilitBotLimp() // Habilitar Boton de Ingerso
        {
            if ((textNomb.Text.Trim() != "") && (textRut.Text.Trim() != "") && (textApell.Text.Trim() != "") && (textFchN.Text.Trim() != "") && (comboReg.Text.Trim() != "") && (comboPro.Text.Trim() != "") && (comboCom.Text.Trim() != "") && (textCorreo.Text.Trim() != "") && (textTel1.Text.Trim() != "") && (textTel2.Text.Trim() != "") && (textFchC.Text.Trim() != "") && (textCarg.Text.Trim() != "") && (textValH.Text.Trim() != "") && (textValHX.Text.Trim() != ""))// "Y" Distinto a vacio 
            {
                butLimp.Enabled = true;
            }
            else
            {
                butLimp.Enabled = false;
            }
        }
        private void textNomb_TextChanged_1(object sender, EventArgs e)
        {
            textNomb.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textNomb.Text);
            textNomb.SelectionStart = textNomb.Text.Length;
            if (textNomb.Text.Trim() != "")
            {
                textApell.TabStop = true;
                textNomb.TabStop = false;
            }
            else
            {
                textApell.TabStop = false;
                textNomb.TabStop = true;
            }
        }
        private void textApell_TextChanged_1(object sender, EventArgs e)
        {
            textApell.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textApell.Text);
            textApell.SelectionStart = textApell.Text.Length;
            if (textApell.Text.Trim() != "")
            {
                textRut.TabStop = true;
                textApell.TabStop = false;
            }
            else
            {
                textRut.TabStop = false;
                textApell.TabStop = true;
            }
        }
        private void textRut_TextChanged_1(object sender, EventArgs e)
        {
            if (textRut.Text.Trim() != "")
            {
                textFchN.TabStop = true;
                textRut.TabStop = false;
            }
            else
            {
                textFchN.TabStop = false;
                textRut.TabStop = true;
            }
        }
        private void textFchN_TextChanged_1(object sender, EventArgs e)
        {
            if (textFchN.Text.Trim() != "")
            {
                comboReg.TabStop = true;
                textFchN.TabStop = false;
                CargaCBReg();
            }
            else
            {
                comboReg.TabStop = false;
                textFchN.TabStop = true;
            }
        }

        private void comboReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboReg.Text.Trim() != "")
            {
                comboPro.TabStop = true;
                comboReg.TabStop = false;
                CargaCBPro();
            }
            else
            {
                comboPro.TabStop = false;
                comboReg.TabStop = true;
            }
        }
        private void comboPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPro.Text.Trim() != "")
            {
                comboCom.TabStop = true;
                comboPro.TabStop = false;
                CargaCBCom();
            }
            else
            {
                comboCom.TabStop = false;
                comboReg.TabStop = true;
            }
        }
        private void comboCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCom.Text.Trim() != "")
            {
                textDirec.TabStop = true;
                comboCom.TabStop = false;
            }
            else
            {
                textDirec.TabStop = false;
                comboCom.TabStop = true;
            }
        }
        private void textDirec_TextChanged(object sender, EventArgs e)
        {
            if (textDirec.Text.Trim() != "")
            {
                textDirec.TabStop = true;
                textCorreo.TabStop = false;
            }
            else
            {
                textDirec.TabStop = false;
                textCorreo.TabStop = true;
            }

        }

        private void textCorreo_TextChanged(object sender, EventArgs e)
        {
            if (textCorreo.Text.Trim() != "")
            {
                textCorreo.TabStop = true;
                textTel1.TabStop = false;
            }
            else
            {
                textCorreo.TabStop = false;
                textTel1.TabStop = true;
            }

        }

        private void textTel1_TextChanged(object sender, EventArgs e)
        {
            if (textTel1.Text.Trim() != "")
            {
                textTel1.TabStop = true;
                textTel2.TabStop = false;
            }
            else
            {
                textTel1.TabStop = false;
                textTel2.TabStop = true;
            }

        }

        private void textTel2_TextChanged(object sender, EventArgs e)
        {
            if (textTel2.Text.Trim() != "")
            {
                textTel2.TabStop = true;
                textFchC.TabStop = false;
            }
            else
            {
                textTel2.TabStop = false;
                textFchC.TabStop = true;
            }

        }

        private void textFchC_TextChanged(object sender, EventArgs e)
        {
            if (textFchC.Text.Trim() != "")
            {
                textFchC.TabStop = true;
                textCarg.TabStop = false;
            }
            else
            {
                textFchC.TabStop = false;
                textCarg.TabStop = true;
            }

        }

        private void textCarg_TextChanged(object sender, EventArgs e)
        {
            if (textCarg.Text.Trim() != "")
            {
                textCarg.TabStop = true;
                textValH.TabStop = false;
            }
            else
            {
                textCarg.TabStop = false;
                textValH.TabStop = true;
            }

        }

        private void textValH_TextChanged(object sender, EventArgs e)
        {
            if (textValH.Text.Trim() != "")
            {
                textCarg.TabStop = true;
                textValHX.TabStop = false;
            }
            else
            {
                textValH.TabStop = false;
                textValHX.TabStop = true;
            }

        }

        private void butSal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butVol_Click(object sender, EventArgs e)
        {
            Cons_Empleado mos = new Cons_Empleado();
            mos.butSueld.Visible = false;
            mos.labelNombreUsu.Text = labelNombreUsu.Text;
            mos.labelTipUsu.Text = labelTipUsu.Text;
            mos.Show();
            this.Close();

        }

        private void butLimp_Click(object sender, EventArgs e)
        {
            textNomb.Clear();
            textApell.Clear();
            textRut.Clear();
            textFchN.Clear();
            textDirec.Clear();
            textCorreo.Clear();
            textTel1.Clear();
            textTel2.Clear();
            textFchC.Clear();
            textCarg.Clear();
            textValH.Clear();
            textValHX.Clear();
            HabilitBotLimp();


        }

        private void butIng_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            string Mensaje = string.Empty;
            Ent.Nombre = textNomb.Text;
            Ent.Apellido = textApell.Text;
            Ent.FechNa = textFchN.Text;
            Ent.IdCom = Convert.ToInt32(comboCom.SelectedValue);
            Ent.Rut = textRut.Text;
            Ent.Correo = textCorreo.Text;
            Ent.Direccion = textDirec.Text;
            Ent.Tel = textTel1.Text;
            Ent.Contratacion = textFchC.Text;
            Ent.Cargo = textCarg.Text;
            Ent.VaHo = textValH.Text;
            Ent.VaHoEx = textValHX.Text;
            if (res == DialogResult.Yes)
            {
                if (Ent.IdTra == 0)
                {
                    int Resultado = new NEmpleado().Ingresar(Ent, out Mensaje);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textNomb_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten Letras");
                }
            }

        }

        private void textApell_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten Letras");
                }
            }

        }

        private void textRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten Números");
                }
            }

        }

        private void textFchN_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten Números");
                }
            }

        }

        private void textTel1_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten Números");
                }
            }

        }

        private void textTel2_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten Números");
                }
            }

        }

        private void textFchC_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten Números");
                }
            }

        }

        private void textValH_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten Números");
                }
            }

        }

        private void textValHX_KeyPress(object sender, KeyPressEventArgs e)
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

 

