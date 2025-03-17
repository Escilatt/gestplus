namespace Software_proyecto_de_titulo.Ventas
{
    partial class Cons_Vent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cons_Vent));
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Selec = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioComp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreTotCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butVol = new System.Windows.Forms.Button();
            this.butSalir = new System.Windows.Forms.Button();
            this.labelTipUsu = new System.Windows.Forms.Label();
            this.labelNombreUsu = new System.Windows.Forms.Label();
            this.butCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToResizeColumns = false;
            this.Grid.AllowUserToResizeRows = false;
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selec,
            this.IdVenta,
            this.Nombre,
            this.CantidadV,
            this.TotalV,
            this.PrecioProd,
            this.PrecioComp,
            this.PreTotCom});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.EnableHeadersVisualStyles = false;
            this.Grid.Location = new System.Drawing.Point(12, 20);
            this.Grid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersVisible = false;
            this.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid.Size = new System.Drawing.Size(403, 255);
            this.Grid.TabIndex = 272;
            this.Grid.TabStop = false;
            // 
            // Selec
            // 
            this.Selec.HeaderText = "Column1";
            this.Selec.Name = "Selec";
            this.Selec.ReadOnly = true;
            this.Selec.Visible = false;
            // 
            // IdVenta
            // 
            this.IdVenta.HeaderText = "IdVenta";
            this.IdVenta.Name = "IdVenta";
            this.IdVenta.ReadOnly = true;
            this.IdVenta.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // CantidadV
            // 
            this.CantidadV.HeaderText = "C.Vendida";
            this.CantidadV.Name = "CantidadV";
            this.CantidadV.ReadOnly = true;
            // 
            // TotalV
            // 
            this.TotalV.HeaderText = "T.Vendido";
            this.TotalV.Name = "TotalV";
            this.TotalV.ReadOnly = true;
            // 
            // PrecioProd
            // 
            this.PrecioProd.HeaderText = "P.Producto";
            this.PrecioProd.Name = "PrecioProd";
            this.PrecioProd.ReadOnly = true;
            // 
            // PrecioComp
            // 
            this.PrecioComp.HeaderText = "PrecioComp";
            this.PrecioComp.Name = "PrecioComp";
            this.PrecioComp.ReadOnly = true;
            this.PrecioComp.Visible = false;
            // 
            // PreTotCom
            // 
            this.PreTotCom.HeaderText = "PreTotCom";
            this.PreTotCom.Name = "PreTotCom";
            this.PreTotCom.ReadOnly = true;
            this.PreTotCom.Visible = false;
            // 
            // butVol
            // 
            this.butVol.BackColor = System.Drawing.Color.Transparent;
            this.butVol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butVol.BackgroundImage")));
            this.butVol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butVol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butVol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butVol.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butVol.Location = new System.Drawing.Point(325, 289);
            this.butVol.Name = "butVol";
            this.butVol.Size = new System.Drawing.Size(90, 36);
            this.butVol.TabIndex = 273;
            this.butVol.TabStop = false;
            this.butVol.Text = "Volver";
            this.butVol.UseVisualStyleBackColor = false;
            this.butVol.Click += new System.EventHandler(this.butVol_Click);
            // 
            // butSalir
            // 
            this.butSalir.BackColor = System.Drawing.Color.Transparent;
            this.butSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butSalir.BackgroundImage")));
            this.butSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSalir.Location = new System.Drawing.Point(325, 340);
            this.butSalir.Name = "butSalir";
            this.butSalir.Size = new System.Drawing.Size(90, 36);
            this.butSalir.TabIndex = 274;
            this.butSalir.TabStop = false;
            this.butSalir.Text = "Salir";
            this.butSalir.UseVisualStyleBackColor = false;
            this.butSalir.Click += new System.EventHandler(this.butSalir_Click);
            // 
            // labelTipUsu
            // 
            this.labelTipUsu.AutoSize = true;
            this.labelTipUsu.BackColor = System.Drawing.Color.Transparent;
            this.labelTipUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipUsu.Location = new System.Drawing.Point(213, 480);
            this.labelTipUsu.Name = "labelTipUsu";
            this.labelTipUsu.Size = new System.Drawing.Size(0, 20);
            this.labelTipUsu.TabIndex = 276;
            // 
            // labelNombreUsu
            // 
            this.labelNombreUsu.AutoSize = true;
            this.labelNombreUsu.BackColor = System.Drawing.Color.Transparent;
            this.labelNombreUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsu.Location = new System.Drawing.Point(213, 417);
            this.labelNombreUsu.Name = "labelNombreUsu";
            this.labelNombreUsu.Size = new System.Drawing.Size(0, 20);
            this.labelNombreUsu.TabIndex = 275;
            // 
            // butCalcular
            // 
            this.butCalcular.BackColor = System.Drawing.Color.Transparent;
            this.butCalcular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butCalcular.BackgroundImage")));
            this.butCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCalcular.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCalcular.Location = new System.Drawing.Point(46, 310);
            this.butCalcular.Name = "butCalcular";
            this.butCalcular.Size = new System.Drawing.Size(235, 36);
            this.butCalcular.TabIndex = 277;
            this.butCalcular.TabStop = false;
            this.butCalcular.Text = "Calcular Ventas/Perdidas";
            this.butCalcular.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butCalcular.UseVisualStyleBackColor = false;
            this.butCalcular.Click += new System.EventHandler(this.butCalcular_Click);
            // 
            // Cons_Vent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(442, 402);
            this.Controls.Add(this.butCalcular);
            this.Controls.Add(this.labelTipUsu);
            this.Controls.Add(this.labelNombreUsu);
            this.Controls.Add(this.butSalir);
            this.Controls.Add(this.butVol);
            this.Controls.Add(this.Grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cons_Vent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Cons_Vent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button butVol;
        private System.Windows.Forms.Button butSalir;
        public System.Windows.Forms.Label labelTipUsu;
        public System.Windows.Forms.Label labelNombreUsu;
        private System.Windows.Forms.Button butCalcular;
        private System.Windows.Forms.DataGridViewButtonColumn Selec;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreTotCom;
    }
}