namespace Software_proyecto_de_titulo.Inventario
{
    partial class Cons_Producto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cons_Producto));
            this.label1 = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Selec = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValxUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butIngProd = new System.Windows.Forms.Button();
            this.butMod = new System.Windows.Forms.Button();
            this.butEli = new System.Windows.Forms.Button();
            this.butInicio = new System.Windows.Forms.Button();
            this.butSal = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelTipUsu = new System.Windows.Forms.Label();
            this.labelNombreUsu = new System.Windows.Forms.Label();
            this.butVent = new System.Windows.Forms.Button();
            this.labelFiltrar = new System.Windows.Forms.Label();
            this.comboFD = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textFiltro = new System.Windows.Forms.TextBox();
            this.butLimpiar = new System.Windows.Forms.Button();
            this.butBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(142, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Productos";
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
            this.IdProducto,
            this.Nombre,
            this.Cantidad,
            this.FechIngreso,
            this.ValxUnidad,
            this.ValTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.EnableHeadersVisualStyles = false;
            this.Grid.Location = new System.Drawing.Point(5, 230);
            this.Grid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Grid.RowHeadersVisible = false;
            this.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid.Size = new System.Drawing.Size(534, 332);
            this.Grid.TabIndex = 271;
            this.Grid.TabStop = false;
            this.Grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
            // 
            // Selec
            // 
            this.Selec.HeaderText = "Column1";
            this.Selec.Name = "Selec";
            this.Selec.ReadOnly = true;
            this.Selec.Visible = false;
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 120;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 80;
            // 
            // FechIngreso
            // 
            this.FechIngreso.HeaderText = "Fecha de Ingreso";
            this.FechIngreso.Name = "FechIngreso";
            this.FechIngreso.ReadOnly = true;
            this.FechIngreso.Width = 130;
            // 
            // ValxUnidad
            // 
            this.ValxUnidad.HeaderText = "ValorXunidad";
            this.ValxUnidad.Name = "ValxUnidad";
            this.ValxUnidad.ReadOnly = true;
            this.ValxUnidad.Width = 110;
            // 
            // ValTotal
            // 
            this.ValTotal.HeaderText = "ValTotal";
            this.ValTotal.Name = "ValTotal";
            this.ValTotal.ReadOnly = true;
            this.ValTotal.Width = 90;
            // 
            // butIngProd
            // 
            this.butIngProd.BackColor = System.Drawing.Color.Transparent;
            this.butIngProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butIngProd.BackgroundImage")));
            this.butIngProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butIngProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butIngProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butIngProd.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butIngProd.Location = new System.Drawing.Point(286, 578);
            this.butIngProd.Name = "butIngProd";
            this.butIngProd.Size = new System.Drawing.Size(196, 35);
            this.butIngProd.TabIndex = 272;
            this.butIngProd.TabStop = false;
            this.butIngProd.Text = "Ingresar Producto";
            this.butIngProd.UseVisualStyleBackColor = false;
            this.butIngProd.Click += new System.EventHandler(this.butIngProd_Click);
            // 
            // butMod
            // 
            this.butMod.BackColor = System.Drawing.Color.Transparent;
            this.butMod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butMod.BackgroundImage")));
            this.butMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butMod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butMod.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMod.Location = new System.Drawing.Point(286, 619);
            this.butMod.Name = "butMod";
            this.butMod.Size = new System.Drawing.Size(110, 35);
            this.butMod.TabIndex = 273;
            this.butMod.TabStop = false;
            this.butMod.Text = "Modificar Producto";
            this.butMod.UseVisualStyleBackColor = false;
            this.butMod.Click += new System.EventHandler(this.button1_Click);
            // 
            // butEli
            // 
            this.butEli.BackColor = System.Drawing.Color.Transparent;
            this.butEli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butEli.BackgroundImage")));
            this.butEli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butEli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butEli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butEli.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEli.Location = new System.Drawing.Point(149, 619);
            this.butEli.Name = "butEli";
            this.butEli.Size = new System.Drawing.Size(107, 35);
            this.butEli.TabIndex = 274;
            this.butEli.TabStop = false;
            this.butEli.Text = "Eliminar Producto";
            this.butEli.UseVisualStyleBackColor = false;
            this.butEli.Click += new System.EventHandler(this.button2_Click);
            // 
            // butInicio
            // 
            this.butInicio.BackColor = System.Drawing.Color.Transparent;
            this.butInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butInicio.BackgroundImage")));
            this.butInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butInicio.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butInicio.Location = new System.Drawing.Point(12, 665);
            this.butInicio.Name = "butInicio";
            this.butInicio.Size = new System.Drawing.Size(107, 35);
            this.butInicio.TabIndex = 275;
            this.butInicio.TabStop = false;
            this.butInicio.Text = "Menu";
            this.butInicio.UseVisualStyleBackColor = false;
            this.butInicio.Click += new System.EventHandler(this.button3_Click);
            // 
            // butSal
            // 
            this.butSal.BackColor = System.Drawing.Color.Transparent;
            this.butSal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butSal.BackgroundImage")));
            this.butSal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butSal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSal.Location = new System.Drawing.Point(424, 665);
            this.butSal.Name = "butSal";
            this.butSal.Size = new System.Drawing.Size(107, 35);
            this.butSal.TabIndex = 276;
            this.butSal.TabStop = false;
            this.butSal.Text = "Salir";
            this.butSal.UseVisualStyleBackColor = false;
            this.butSal.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 802);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 277;
            // 
            // labelTipUsu
            // 
            this.labelTipUsu.AutoSize = true;
            this.labelTipUsu.BackColor = System.Drawing.Color.Transparent;
            this.labelTipUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipUsu.Location = new System.Drawing.Point(158, 865);
            this.labelTipUsu.Name = "labelTipUsu";
            this.labelTipUsu.Size = new System.Drawing.Size(0, 20);
            this.labelTipUsu.TabIndex = 279;
            // 
            // labelNombreUsu
            // 
            this.labelNombreUsu.AutoSize = true;
            this.labelNombreUsu.BackColor = System.Drawing.Color.Transparent;
            this.labelNombreUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsu.Location = new System.Drawing.Point(158, 802);
            this.labelNombreUsu.Name = "labelNombreUsu";
            this.labelNombreUsu.Size = new System.Drawing.Size(0, 20);
            this.labelNombreUsu.TabIndex = 278;
            // 
            // butVent
            // 
            this.butVent.BackColor = System.Drawing.Color.Transparent;
            this.butVent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butVent.BackgroundImage")));
            this.butVent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butVent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butVent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butVent.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butVent.Location = new System.Drawing.Point(80, 578);
            this.butVent.Name = "butVent";
            this.butVent.Size = new System.Drawing.Size(176, 35);
            this.butVent.TabIndex = 280;
            this.butVent.TabStop = false;
            this.butVent.Text = "Ingresar Venta";
            this.butVent.UseVisualStyleBackColor = false;
            this.butVent.Click += new System.EventHandler(this.butVent_Click);
            // 
            // labelFiltrar
            // 
            this.labelFiltrar.AutoSize = true;
            this.labelFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.labelFiltrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltrar.ForeColor = System.Drawing.Color.White;
            this.labelFiltrar.Location = new System.Drawing.Point(19, 96);
            this.labelFiltrar.Name = "labelFiltrar";
            this.labelFiltrar.Size = new System.Drawing.Size(106, 25);
            this.labelFiltrar.TabIndex = 282;
            this.labelFiltrar.Text = "Buscar por:";
            this.labelFiltrar.Click += new System.EventHandler(this.labelFiltrar_Click);
            // 
            // comboFD
            // 
            this.comboFD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFD.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFD.FormattingEnabled = true;
            this.comboFD.Location = new System.Drawing.Point(24, 129);
            this.comboFD.Name = "comboFD";
            this.comboFD.Size = new System.Drawing.Size(176, 33);
            this.comboFD.TabIndex = 281;
            this.comboFD.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(240, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 25);
            this.label2.TabIndex = 284;
            this.label2.Text = "Ingrese dato para su busqueda:";
            // 
            // textFiltro
            // 
            this.textFiltro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFiltro.Location = new System.Drawing.Point(245, 129);
            this.textFiltro.Name = "textFiltro";
            this.textFiltro.Size = new System.Drawing.Size(150, 33);
            this.textFiltro.TabIndex = 283;
            this.textFiltro.TabStop = false;
            this.textFiltro.TextChanged += new System.EventHandler(this.textFiltro_TextChanged);
            // 
            // butLimpiar
            // 
            this.butLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.butLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butLimpiar.BackgroundImage")));
            this.butLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butLimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLimpiar.Location = new System.Drawing.Point(401, 168);
            this.butLimpiar.Name = "butLimpiar";
            this.butLimpiar.Size = new System.Drawing.Size(115, 34);
            this.butLimpiar.TabIndex = 286;
            this.butLimpiar.TabStop = false;
            this.butLimpiar.Text = "Limpiar Filtros";
            this.butLimpiar.UseVisualStyleBackColor = false;
            this.butLimpiar.Click += new System.EventHandler(this.butLimpiar_Click);
            // 
            // butBuscar
            // 
            this.butBuscar.BackColor = System.Drawing.Color.Transparent;
            this.butBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butBuscar.BackgroundImage")));
            this.butBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBuscar.Location = new System.Drawing.Point(401, 128);
            this.butBuscar.Name = "butBuscar";
            this.butBuscar.Size = new System.Drawing.Size(115, 34);
            this.butBuscar.TabIndex = 285;
            this.butBuscar.TabStop = false;
            this.butBuscar.Text = "Buscar";
            this.butBuscar.UseVisualStyleBackColor = false;
            this.butBuscar.Click += new System.EventHandler(this.butBuscar_Click);
            // 
            // Cons_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(547, 878);
            this.Controls.Add(this.butLimpiar);
            this.Controls.Add(this.butBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textFiltro);
            this.Controls.Add(this.labelFiltrar);
            this.Controls.Add(this.comboFD);
            this.Controls.Add(this.butVent);
            this.Controls.Add(this.labelTipUsu);
            this.Controls.Add(this.labelNombreUsu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butSal);
            this.Controls.Add(this.butInicio);
            this.Controls.Add(this.butEli);
            this.Controls.Add(this.butMod);
            this.Controls.Add(this.butIngProd);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cons_Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Cons_Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button butIngProd;
        private System.Windows.Forms.Button butMod;
        private System.Windows.Forms.Button butEli;
        private System.Windows.Forms.Button butInicio;
        private System.Windows.Forms.Button butSal;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label labelTipUsu;
        public System.Windows.Forms.Label labelNombreUsu;
        private System.Windows.Forms.Button butVent;
        public System.Windows.Forms.Label labelFiltrar;
        public System.Windows.Forms.ComboBox comboFD;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textFiltro;
        public System.Windows.Forms.Button butLimpiar;
        public System.Windows.Forms.Button butBuscar;
        private System.Windows.Forms.DataGridViewButtonColumn Selec;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValxUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValTotal;
    }
}