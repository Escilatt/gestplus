using Entidad;
using Negocio;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Software_proyecto_de_titulo
{
    public partial class LoginUsu : Form
    {
        ELogin Ent = new ELogin();
        public LoginUsu()
        {
            InitializeComponent();
            butIngLog.FlatStyle = FlatStyle.Flat;
            butIngLog.FlatAppearance.BorderSize = 0;
            butSalLog.FlatStyle = FlatStyle.Flat;
            butSalLog.FlatAppearance.BorderSize = 0;
            butIngLog.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butSalLog.FlatAppearance.MouseOverBackColor = Color.Transparent;
            

        }


        public void HabIng()
        {
            if ((tBNom.Text.Trim() != "") && (tBPass.Text.Trim() != ""))
            {
                butIngLog.Enabled = true;
            }
            else
            {
                butIngLog.Enabled = false;
            }
        }
        private void tBNom_TextChanged(object sender, EventArgs e)
        {
            tBNom.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tBNom.Text);
            tBNom.SelectionStart = tBNom.Text.Length;

            if (tBNom.Text.Trim() != "")
            {
                tBPass.TabStop = true;
                tBNom.TabStop = false;
            }
            else
            {
                tBPass.TabStop = false;
                tBNom.TabStop = true;
            }
            HabIng();
        }

        private void tBPass_TextChanged(object sender, EventArgs e)
        {
            if (tBPass.Text.Trim() != "")
            {
                butIngLog.TabStop = true;
                tBPass.TabStop = false;
            }
            else
            {
                butIngLog.TabStop = false;
                tBPass.TabStop = true;
            }
            HabIng();
        }
        private void tBPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                butIngLog.PerformClick();
            }
        }
        private void butIngLog_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;
            string Nombre = tBNom.Text;
            string Pass = tBPass.Text;
            NLogin Neg = new NLogin();
            int IdUsu = Neg.IngSig(Nombre, Pass, out Mensaje);
            Puente.Ent = new ELogin() { IdUsu = IdUsu };

            if (IdUsu != 0)
            {
                String Nom = tBNom.Text;
                MessageBox.Show("Bienvenido Sr(a): " + Nom + ", " + Mensaje, "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                labelUsu.Text = Mensaje;
                Menu MP = new Menu();
                MP.labelNombreUsu.Text = Nom;
                MP.labelTipUsu.Text = labelUsu.Text;
                MP.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
            butIngLog.BackColor = Color.Transparent;
        }

        private void butSalLog_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void LoginUsu_Load(object sender, EventArgs e)
        {

        }

        private void labelNomLog_Click(object sender, EventArgs e)
        {

        }

    }
}

