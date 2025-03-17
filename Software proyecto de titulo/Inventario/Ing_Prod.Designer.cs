namespace Software_proyecto_de_titulo.Inventario
{
    partial class Ing_Prod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ing_Prod));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNomb = new System.Windows.Forms.TextBox();
            this.textFechIng = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textValXu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textValTot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.butIng = new System.Windows.Forms.Button();
            this.butVol = new System.Windows.Forms.Button();
            this.butLimp = new System.Windows.Forms.Button();
            this.butSal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(94, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // textNomb
            // 
            this.textNomb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomb.Location = new System.Drawing.Point(193, 82);
            this.textNomb.Name = "textNomb";
            this.textNomb.Size = new System.Drawing.Size(207, 29);
            this.textNomb.TabIndex = 2;
            this.textNomb.TabStop = false;
            this.textNomb.TextChanged += new System.EventHandler(this.textNomb_TextChanged);
            // 
            // textFechIng
            // 
            this.textFechIng.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFechIng.Location = new System.Drawing.Point(193, 122);
            this.textFechIng.Name = "textFechIng";
            this.textFechIng.Size = new System.Drawing.Size(207, 29);
            this.textFechIng.TabIndex = 4;
            this.textFechIng.TabStop = false;
            this.textFechIng.TextChanged += new System.EventHandler(this.textFechIng_TextChanged);
            this.textFechIng.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFechIng_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de Ingreso:";
            // 
            // textCant
            // 
            this.textCant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCant.Location = new System.Drawing.Point(193, 162);
            this.textCant.Name = "textCant";
            this.textCant.Size = new System.Drawing.Size(207, 29);
            this.textCant.TabIndex = 6;
            this.textCant.TabStop = false;
            this.textCant.TextChanged += new System.EventHandler(this.textCant_TextChanged);
            this.textCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCant_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(13, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad:";
            // 
            // textValXu
            // 
            this.textValXu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValXu.Location = new System.Drawing.Point(193, 205);
            this.textValXu.Name = "textValXu";
            this.textValXu.Size = new System.Drawing.Size(207, 29);
            this.textValXu.TabIndex = 8;
            this.textValXu.TabStop = false;
            this.textValXu.TextChanged += new System.EventHandler(this.textValXu_TextChanged);
            this.textValXu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textValXu_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(13, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Valor por Unidad:";
            // 
            // textValTot
            // 
            this.textValTot.Enabled = false;
            this.textValTot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValTot.Location = new System.Drawing.Point(193, 248);
            this.textValTot.Name = "textValTot";
            this.textValTot.Size = new System.Drawing.Size(207, 29);
            this.textValTot.TabIndex = 10;
            this.textValTot.TabStop = false;
            this.textValTot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textValTot_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(13, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Valor Total:";
            // 
            // butIng
            // 
            this.butIng.BackColor = System.Drawing.Color.Transparent;
            this.butIng.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butIng.BackgroundImage")));
            this.butIng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butIng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butIng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butIng.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butIng.Location = new System.Drawing.Point(158, 334);
            this.butIng.Name = "butIng";
            this.butIng.Size = new System.Drawing.Size(103, 42);
            this.butIng.TabIndex = 11;
            this.butIng.TabStop = false;
            this.butIng.Text = "Ingresar";
            this.butIng.UseVisualStyleBackColor = false;
            this.butIng.Click += new System.EventHandler(this.butIng_Click);
            // 
            // butVol
            // 
            this.butVol.BackColor = System.Drawing.Color.Transparent;
            this.butVol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butVol.BackgroundImage")));
            this.butVol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butVol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butVol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butVol.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butVol.Location = new System.Drawing.Point(49, 382);
            this.butVol.Name = "butVol";
            this.butVol.Size = new System.Drawing.Size(103, 42);
            this.butVol.TabIndex = 12;
            this.butVol.TabStop = false;
            this.butVol.Text = "Volver";
            this.butVol.UseVisualStyleBackColor = false;
            this.butVol.Click += new System.EventHandler(this.butVol_Click);
            // 
            // butLimp
            // 
            this.butLimp.BackColor = System.Drawing.Color.Transparent;
            this.butLimp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butLimp.BackgroundImage")));
            this.butLimp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butLimp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butLimp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLimp.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLimp.Location = new System.Drawing.Point(158, 382);
            this.butLimp.Name = "butLimp";
            this.butLimp.Size = new System.Drawing.Size(103, 42);
            this.butLimp.TabIndex = 13;
            this.butLimp.TabStop = false;
            this.butLimp.Text = "Limpiar";
            this.butLimp.UseVisualStyleBackColor = false;
            this.butLimp.Click += new System.EventHandler(this.butLimp_Click);
            // 
            // butSal
            // 
            this.butSal.BackColor = System.Drawing.Color.Transparent;
            this.butSal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butSal.BackgroundImage")));
            this.butSal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butSal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSal.Location = new System.Drawing.Point(267, 382);
            this.butSal.Name = "butSal";
            this.butSal.Size = new System.Drawing.Size(103, 42);
            this.butSal.TabIndex = 14;
            this.butSal.TabStop = false;
            this.butSal.Text = "Salir";
            this.butSal.UseVisualStyleBackColor = false;
            this.butSal.Click += new System.EventHandler(this.butSal_Click);
            // 
            // Ing_Prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(423, 441);
            this.Controls.Add(this.butSal);
            this.Controls.Add(this.butLimp);
            this.Controls.Add(this.butVol);
            this.Controls.Add(this.butIng);
            this.Controls.Add(this.textValTot);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textValXu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textCant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textFechIng);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNomb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ing_Prod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Producto";
            this.Load += new System.EventHandler(this.Ing_Prod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNomb;
        private System.Windows.Forms.TextBox textFechIng;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textValXu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textValTot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butIng;
        private System.Windows.Forms.Button butVol;
        private System.Windows.Forms.Button butLimp;
        private System.Windows.Forms.Button butSal;
    }
}