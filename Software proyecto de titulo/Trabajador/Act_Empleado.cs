using Entidad;
using Negocio;
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

namespace Software_proyecto_de_titulo.Trabajador
{
    public partial class Act_Empleado : Form
    {
        EEmpleado Ent = new EEmpleado();
        NEmpleado Neg = new NEmpleado();
        NLocCom NegCom = new NLocCom();
        NLocPro NegPro = new NLocPro();
        NLocReg NegReg = new NLocReg();
        public Act_Empleado()
        {
            InitializeComponent();
            butAct.FlatStyle = FlatStyle.Flat;
            butAct.FlatAppearance.BorderSize = 0;
            butAct.FlatAppearance.MouseOverBackColor = Color.Transparent;
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

        private void Act_Empleado_Load(object sender, EventArgs e)
        {
            CargaCBReg();
            CargaCBPro();
            CargaCBCom();
        }

        public void CargaCBReg()
        {
            comboRegF.DisplayMember = "Nombre";    //Muestra el texto en comboBox
            comboRegF.ValueMember = "IdReg";  //Le da el valor en comboBox
            comboRegF.DataSource = NegReg.Listar();  //Establece el indice en comboBox
        }

        private void CargaCBPro()
        {
            int IdReg = Convert.ToInt32(comboRegF.SelectedValue);  //Una variable de valor entero se convierte en un valor entero en comboBox
            DataTable dt = NegPro.Filtrar(IdReg);  //La variable de una tabla de datos es igual al campo que llama a la funcion
            comboProF.DisplayMember = "Nombre";    //Muestra nombre en comboBox
            comboProF.ValueMember = "IdPro";   //Le da el valor en comboBox
            comboProF.DataSource = dt;   //La variable se muestra en comboBox
        }

        private void CargaCBCom()
        {
            int IdPro = Convert.ToInt32(comboProF.SelectedValue); //Una variable de valor entero se convierte en un valor entero en comboBox
            DataTable dt = NegCom.Filtrar(IdPro); //La variable de una tabla de datos es igual al campo que llama a la funcion
            comboComF.DisplayMember = "Nombre"; //Muestra nombre en comboBox
            comboComF.ValueMember = "IdCom";  //Le da el valor en comboBox
            comboComF.DataSource = dt;   //La variable se muestra en comboBox
        }

        public void Validar()//Funcion que valida los textbox
        {
            if ((textNombF.Text.Trim() != textNombI.Text.Trim()) || (textRutF.Text.Trim() != textRutI.Text.Trim()) || (textDirecF.Text.Trim() != textDirecI.Text.Trim()) || (textCargF.Text.Trim() != textCargI.Text.Trim()) || (textTel1F.Text.Trim() != textTel1I.Text.Trim()) || (textCorreoF.Text.Trim() != textCorreoI.Text.Trim()) || (textApellF.Text.Trim() != textApellI.Text.Trim()) || (textFchNF.Text.Trim() != textFchNI.Text.Trim()) || (textFchCF.Text.Trim() != textFchCI.Text.Trim()) || (textValHF.Text.Trim() != textValHI.Text.Trim()) || (textValHXF.Text.Trim() != textValHXI.Text.Trim()) || (comboRegF.Text.Trim() != textRegI.Text.Trim()) || (comboComF.Text.Trim() != textComI.Text.Trim()) || (comboProF.Text.Trim() != textProI.Text.Trim())) 
            {   //Si hay cambios habilita el boton de modificar y deshabilita el resto
                butAct.Enabled = true;
                labelRut.Enabled = false;
                labelNomb.Enabled = false;
                labelApellid.Enabled = false;
                labelFechn.Enabled = false;
                labelReg.Enabled = false;
                labelCom.Enabled = false;
                labelProv.Enabled = false;
                labelDirec.Enabled = false;
                labelCorreo.Enabled = false;
                labelTel1.Enabled = false;
                labelFechcon.Enabled = false;
                labelCarg.Enabled = false;
                labelValhora.Enabled = false;
                labelValHoraex.Enabled = false;
            }
            else
            { //Si no hay cambios habilita los otros botones y deshabilita el boton de modificar
                butAct.Enabled = false;
                labelRut.Enabled = true;
                labelNomb.Enabled = true;
                labelApellid.Enabled = true;
                labelFechn.Enabled = true;
                labelReg.Enabled = true;
                labelCom.Enabled = true;
                labelProv.Enabled = true;
                labelDirec.Enabled = true;
                labelCorreo.Enabled = true;
                labelTel1.Enabled = true;
                labelFechcon.Enabled = true;
                labelCarg.Enabled = true;
                labelValhora.Enabled = true;
                labelValHoraex.Enabled = true;
            }
        }
        private void textNombF_TextChanged(object sender, EventArgs e)
        {
            CargaCBReg();
        }
        private void comboRegF_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaCBPro();
        }

        private void comboProF_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaCBCom();
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
        private void butAct_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            string Mensaje = string.Empty;
            Ent.IdTra = Convert.ToInt32(TextIdTra.Text);
            Ent.Nombre = textNombF.Text;
            Ent.Apellido = textApellF.Text;
            Ent.FechNa = textFchNF.Text;
            Ent.IdCom = Convert.ToInt32(textIdComF.Text);
            Ent.Rut = textRutF.Text;
            Ent.Correo = textCorreoF.Text;
            Ent.Direccion = textDirecF.Text;
            Ent.Tel = textTel1F.Text;
            Ent.Contratacion = textFchCF.Text;
            Ent.Cargo = textCargF.Text;
            Ent.VaHo = textValHF.Text;
            Ent.VaHoEx = textValHXF.Text;
            if (res == DialogResult.Yes)
            {
                bool Resultado = new NEmpleado().Actualizar(Ent, out Mensaje);
                if (Resultado)
                {
                    MessageBox.Show("Actualización fue realizado correctamente", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);//Si la actualizacion es realizada con exito aparece el mensaje 
                    textNombI.Text = textNombF.Text;
                    textApellI.Text = textApellF.Text;
                    textFchNI.Text = textFchNF.Text;
                    textIdComI.Text = textIdComF.Text;
                    textComI.Text = textComF.Text;
                    textRutI.Text = textRutF.Text;
                    textCorreoI.Text = textCorreoF.Text;
                    textDirecI.Text = textDirecF.Text;
                    textTel1I.Text = textTel1F.Text;
                    textFchCI.Text = textFchCF.Text;
                    textCargI.Text = textCargF.Text;
                    textValHI.Text = textValHF.Text;
                    textValHXI.Text = textValHXF.Text;
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
            
            Validar();
        }
        private void butSal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butLimp_Click(object sender, EventArgs e)
        {
            textNombF.Clear();
            textApellF.Clear();
            textRutF.Clear();
            textFchNF.Clear();
            textDirecF.Clear();
            textCorreoF.Clear();
            textTel1F.Clear();
            textTel2F.Clear();
            textFchCF.Clear();
            textCargF.Clear();
            textValHF.Clear();
            textValHXF.Clear();
        }

        private void comboComF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboComF.SelectedItem != null)
            {
                var ComBoxComuna = comboComF.SelectedItem as DataRowView;
                int comunaID = (int)ComBoxComuna["IdCom"];
                textIdComF.Text = comunaID.ToString();
            }
        }

        private void textTel1F_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten Números");
                }
            }

        }

        private void textTel2F_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten Números");
                }
            }

        }

        private void textValHF_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten Números");
                }
            }

        }

        private void textValHXF_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten Números");
                }
            }

        }

        private void textFchCF_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten Números");
                }
            }

        }

        private void textFchNF_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten Números");
                }
            }

        }

        private void textNombF_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten Letras");
                }
            }

        }

        private void textApellF_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten Letras");
                }
            }

        }
    }
}

