using Software_proyecto_de_titulo.Trabajador;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Software_proyecto_de_titulo
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
            butCalcular.FlatStyle = FlatStyle.Flat; 
            butCalcular.FlatAppearance.BorderSize = 0;
            butCalcular.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butLimpiar.FlatStyle = FlatStyle.Flat;
            butLimpiar.FlatAppearance.BorderSize = 0;
            butLimpiar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butSumar.FlatStyle = FlatStyle.Flat;
            butSumar.FlatAppearance.BorderSize = 0;
            butSumar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butSalir.FlatStyle = FlatStyle.Flat;
            butSalir.FlatAppearance.BorderSize = 0;
            butSalir.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butVolver.FlatStyle = FlatStyle.Flat;
            butVolver.FlatAppearance.BorderSize = 0;
            butVolver.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            HabBSumar();
            HabBLimpiar();
        }
        public void HabBSumar() // Habilitar Boton de Ingreso
        {
            if ((textHTrabajadas.Text.Trim() != "") && (textHExtras.Text.Trim() != "")) // "Y" Distinto a vacio 
            {
                butSumar.Enabled = true;
            }
            else
            {
                butSumar.Enabled = false;
            }
        }
        public void HabBCalcular() // Habilitar Boton de Ingreso
        {
            if ((comboAFP.Text.Trim() != "") && (comboSSalud.Text.Trim() != "")) // "Y" Distinto a vacio 
            {
                butSumar.Enabled = true;
            }
            else
            {
                butSumar.Enabled = false;
            }
        }
        public void HabBLimpiar() // Habilitar Boton de Ingreso
        {
            if ((textHTrabajadas.Text.Trim() != "") || (textHExtras.Text.Trim() != "")) // "o" Distinto a vacio 
            {
                butLimpiar.Enabled = true;
            }
            else
            {
                butLimpiar.Enabled = false;
            }
        }

        private void comboAFP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAFP.Text.Trim() == "CUPRUM")
            {
                Double res = double.Parse(labelSBruto.Text) * 0.07;
                labelDAFP.Text = res.ToString();
            }
            else if (comboAFP.Text.Trim() == "MODELO")
            {
                Double res = double.Parse(labelSBruto.Text) * 0.09;
                labelDAFP.Text = res.ToString();
            }
            else if (comboAFP.Text.Trim() == "CAPITAL")
            {
                Double res = double.Parse(labelSBruto.Text) * 0.12;
                labelDAFP.Text = res.ToString();
            }
            else if (comboAFP.Text.Trim() == "PROVIDA")
            {
                Double res = double.Parse(labelSBruto.Text) * 0.13;
                labelDAFP.Text = res.ToString();
            }
        }

        private void comboSSalud_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSSalud.Text.Trim() == "FONASA")
            {
                Double res = double.Parse(labelSBruto.Text) * 0.12;
                labelDSSalud.Text = res.ToString();
            }
            else if (comboSSalud.Text.Trim() == "CONSALUD")
            {
                Double res = double.Parse(labelSBruto.Text) * 0.13;
                labelDSSalud.Text = res.ToString();
            }
            else if (comboSSalud.Text.Trim() == "MASVIDA")
            {
                Double res = double.Parse(labelSBruto.Text) * 0.14;
                labelDSSalud.Text = res.ToString();
            }
            else if (comboSSalud.Text.Trim() == "BANMEDICA")
            {
                Double res = double.Parse(labelSBruto.Text) * 0.15;
                labelDSSalud.Text = res.ToString();
            }
        }
        private void textHTrabajadas_TextChanged(object sender, EventArgs e)
        {
            HabBSumar();
            HabBLimpiar();
        }
        private void textHTrabajadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Números");
            }
        }
        private void textHExtras_TextChanged(object sender, EventArgs e)
        {
            HabBSumar();
            HabBLimpiar();
        }
        private void textHExtras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Números");
            }
        }

        private void butSumar_Click(object sender, EventArgs e)
        {
            Double res = (double.Parse(label7.Text) * double.Parse(textHTrabajadas.Text)) + (double.Parse(label9.Text) * double.Parse(textHExtras.Text));
            labelSBruto.Text = res.ToString();
            comboAFP.Enabled = true;
            comboSSalud.Enabled = true;
        }

        private void butCalcular_Click(object sender, EventArgs e)
        {
            Double res = double.Parse(labelSBruto.Text) - double.Parse(labelDAFP.Text) - double.Parse(labelDSSalud.Text);
            labelSLiquido.Text = res.ToString();
        }

        private void butVolver_Click(object sender, EventArgs e)
        {
            Cons_Empleado consultar = new Cons_Empleado();
            consultar.labelNombreUsu.Text = labelNombreUsu.Text;
            consultar.labelTipUsu.Text = labelTipUsu.Text;
            consultar.Show();
            this.Close();
        }

        private void butSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butLimpiar_Click(object sender, EventArgs e)
        {
            textHTrabajadas.Clear();
            textHExtras.Clear();
            
        }

    }
}
