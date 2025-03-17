namespace Software_proyecto_de_titulo
{
    partial class LoginUsu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUsu));
            this.labelUsu = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.butSalLog = new System.Windows.Forms.Button();
            this.butIngLog = new System.Windows.Forms.Button();
            this.tBPass = new System.Windows.Forms.TextBox();
            this.tBNom = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUsu
            // 
            this.labelUsu.AutoSize = true;
            this.labelUsu.BackColor = System.Drawing.Color.Transparent;
            this.labelUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsu.Location = new System.Drawing.Point(302, 315);
            this.labelUsu.Name = "labelUsu";
            this.labelUsu.Size = new System.Drawing.Size(0, 20);
            this.labelUsu.TabIndex = 69;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Enabled = false;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(251, 278);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(0, 20);
            this.labelNombre.TabIndex = 68;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.White;
            this.labelLogin.Location = new System.Drawing.Point(114, 24);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(85, 37);
            this.labelLogin.TabIndex = 65;
            this.labelLogin.Text = "Login";
            // 
            // butSalLog
            // 
            this.butSalLog.BackColor = System.Drawing.Color.Transparent;
            this.butSalLog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butSalLog.BackgroundImage")));
            this.butSalLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butSalLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSalLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSalLog.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSalLog.ForeColor = System.Drawing.Color.Black;
            this.butSalLog.Location = new System.Drawing.Point(166, 266);
            this.butSalLog.Name = "butSalLog";
            this.butSalLog.Size = new System.Drawing.Size(123, 46);
            this.butSalLog.TabIndex = 64;
            this.butSalLog.TabStop = false;
            this.butSalLog.Text = "Salir";
            this.butSalLog.UseVisualStyleBackColor = false;
            this.butSalLog.Click += new System.EventHandler(this.butSalLog_Click);
            // 
            // butIngLog
            // 
            this.butIngLog.BackColor = System.Drawing.Color.Transparent;
            this.butIngLog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butIngLog.BackgroundImage")));
            this.butIngLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butIngLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butIngLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butIngLog.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butIngLog.ForeColor = System.Drawing.Color.Black;
            this.butIngLog.Location = new System.Drawing.Point(26, 266);
            this.butIngLog.Name = "butIngLog";
            this.butIngLog.Size = new System.Drawing.Size(112, 46);
            this.butIngLog.TabIndex = 63;
            this.butIngLog.TabStop = false;
            this.butIngLog.Text = "Ingresar";
            this.butIngLog.UseVisualStyleBackColor = false;
            this.butIngLog.Click += new System.EventHandler(this.butIngLog_Click);
            // 
            // tBPass
            // 
            this.tBPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPass.Location = new System.Drawing.Point(79, 21);
            this.tBPass.Name = "tBPass";
            this.tBPass.PasswordChar = '*';
            this.tBPass.Size = new System.Drawing.Size(198, 29);
            this.tBPass.TabIndex = 62;
            this.tBPass.TabStop = false;
            this.tBPass.TextChanged += new System.EventHandler(this.tBPass_TextChanged);
            this.tBPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBPass_KeyPress);
            // 
            // tBNom
            // 
            this.tBNom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNom.Location = new System.Drawing.Point(79, 23);
            this.tBNom.Name = "tBNom";
            this.tBNom.Size = new System.Drawing.Size(198, 29);
            this.tBNom.TabIndex = 61;
            this.tBNom.TabStop = false;
            this.tBNom.TextChanged += new System.EventHandler(this.tBNom_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tBNom);
            this.panel1.Location = new System.Drawing.Point(12, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 72);
            this.panel1.TabIndex = 70;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.tBPass);
            this.panel2.Location = new System.Drawing.Point(12, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 70);
            this.panel2.TabIndex = 73;
            // 
            // LoginUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(313, 337);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelUsu);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.butSalLog);
            this.Controls.Add(this.butIngLog);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginUsu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login ";
            this.Load += new System.EventHandler(this.LoginUsu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsu;
        private System.Windows.Forms.Label labelLogin;
        public System.Windows.Forms.Button butSalLog;
        public System.Windows.Forms.Button butIngLog;
        public System.Windows.Forms.TextBox tBPass;
        public System.Windows.Forms.TextBox tBNom;
        public System.Windows.Forms.Label labelNombre;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}