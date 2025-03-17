namespace Software_proyecto_de_titulo.Trabajador
{
    partial class Cons_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cons_Empleado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.butIng = new System.Windows.Forms.Button();
            this.butMod = new System.Windows.Forms.Button();
            this.butEli = new System.Windows.Forms.Button();
            this.butInicio = new System.Windows.Forms.Button();
            this.butSalir = new System.Windows.Forms.Button();
            this.labelTipUsu = new System.Windows.Forms.Label();
            this.labelNombreUsu = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Selec = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contratacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VaHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VaHoEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.comboFD = new System.Windows.Forms.ComboBox();
            this.labelFiltrar = new System.Windows.Forms.Label();
            this.butBuscar = new System.Windows.Forms.Button();
            this.textFiltro = new System.Windows.Forms.TextBox();
            this.butLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.butSueld = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(478, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 37);
            this.label1.TabIndex = 156;
            this.label1.Text = "Consultar Empleado";
            // 
            // butIng
            // 
            this.butIng.BackColor = System.Drawing.Color.Transparent;
            this.butIng.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butIng.BackgroundImage")));
            this.butIng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butIng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butIng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butIng.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butIng.Location = new System.Drawing.Point(243, 527);
            this.butIng.Name = "butIng";
            this.butIng.Size = new System.Drawing.Size(202, 38);
            this.butIng.TabIndex = 157;
            this.butIng.TabStop = false;
            this.butIng.Text = "Ingresar Empleado";
            this.butIng.UseVisualStyleBackColor = false;
            this.butIng.Click += new System.EventHandler(this.butIng_Click);
            // 
            // butMod
            // 
            this.butMod.BackColor = System.Drawing.Color.Transparent;
            this.butMod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butMod.BackgroundImage")));
            this.butMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butMod.Enabled = false;
            this.butMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMod.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMod.Location = new System.Drawing.Point(451, 527);
            this.butMod.Name = "butMod";
            this.butMod.Size = new System.Drawing.Size(202, 38);
            this.butMod.TabIndex = 158;
            this.butMod.TabStop = false;
            this.butMod.Text = "Modificar Empleado";
            this.butMod.UseVisualStyleBackColor = false;
            this.butMod.Click += new System.EventHandler(this.butMod_Click);
            // 
            // butEli
            // 
            this.butEli.BackColor = System.Drawing.Color.Transparent;
            this.butEli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butEli.BackgroundImage")));
            this.butEli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butEli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butEli.Enabled = false;
            this.butEli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butEli.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEli.Location = new System.Drawing.Point(12, 527);
            this.butEli.Name = "butEli";
            this.butEli.Size = new System.Drawing.Size(225, 38);
            this.butEli.TabIndex = 159;
            this.butEli.TabStop = false;
            this.butEli.Text = "Eliminar Empleado";
            this.butEli.UseVisualStyleBackColor = false;
            this.butEli.Click += new System.EventHandler(this.butEli_Click);
            // 
            // butInicio
            // 
            this.butInicio.BackColor = System.Drawing.Color.Transparent;
            this.butInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butInicio.BackgroundImage")));
            this.butInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butInicio.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butInicio.Location = new System.Drawing.Point(934, 527);
            this.butInicio.Name = "butInicio";
            this.butInicio.Size = new System.Drawing.Size(115, 38);
            this.butInicio.TabIndex = 160;
            this.butInicio.TabStop = false;
            this.butInicio.Text = "Menu";
            this.butInicio.UseVisualStyleBackColor = false;
            this.butInicio.Click += new System.EventHandler(this.butInicio_Click);
            // 
            // butSalir
            // 
            this.butSalir.BackColor = System.Drawing.Color.Transparent;
            this.butSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butSalir.BackgroundImage")));
            this.butSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSalir.Location = new System.Drawing.Point(1055, 527);
            this.butSalir.Name = "butSalir";
            this.butSalir.Size = new System.Drawing.Size(115, 38);
            this.butSalir.TabIndex = 161;
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
            this.labelTipUsu.Location = new System.Drawing.Point(706, 746);
            this.labelTipUsu.Name = "labelTipUsu";
            this.labelTipUsu.Size = new System.Drawing.Size(0, 20);
            this.labelTipUsu.TabIndex = 163;
            // 
            // labelNombreUsu
            // 
            this.labelNombreUsu.AutoSize = true;
            this.labelNombreUsu.BackColor = System.Drawing.Color.Transparent;
            this.labelNombreUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsu.Location = new System.Drawing.Point(706, 683);
            this.labelNombreUsu.Name = "labelNombreUsu";
            this.labelNombreUsu.Size = new System.Drawing.Size(0, 20);
            this.labelNombreUsu.TabIndex = 162;
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
            this.IdTra,
            this.Nombre,
            this.Apellido,
            this.Rut,
            this.Direccion,
            this.FechaNa,
            this.IdCom,
            this.Comuna,
            this.Correo,
            this.Tel,
            this.Contratacion,
            this.Cargo,
            this.VaHo,
            this.VaHoEx});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.EnableHeadersVisualStyles = false;
            this.Grid.Location = new System.Drawing.Point(12, 201);
            this.Grid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Grid.RowHeadersVisible = false;
            this.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid.Size = new System.Drawing.Size(1162, 314);
            this.Grid.TabIndex = 270;
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
            // IdTra
            // 
            this.IdTra.HeaderText = "IdTra";
            this.IdTra.Name = "IdTra";
            this.IdTra.ReadOnly = true;
            this.IdTra.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 120;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 120;
            // 
            // Rut
            // 
            this.Rut.HeaderText = "Rut";
            this.Rut.Name = "Rut";
            this.Rut.ReadOnly = true;
            this.Rut.Width = 80;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 125;
            // 
            // FechaNa
            // 
            this.FechaNa.HeaderText = "FechNacim";
            this.FechaNa.Name = "FechaNa";
            this.FechaNa.ReadOnly = true;
            // 
            // IdCom
            // 
            this.IdCom.HeaderText = "IdCom";
            this.IdCom.Name = "IdCom";
            this.IdCom.ReadOnly = true;
            this.IdCom.Visible = false;
            // 
            // Comuna
            // 
            this.Comuna.HeaderText = "Comuna";
            this.Comuna.Name = "Comuna";
            this.Comuna.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 110;
            // 
            // Tel
            // 
            this.Tel.HeaderText = "Tel";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            this.Tel.Width = 90;
            // 
            // Contratacion
            // 
            this.Contratacion.HeaderText = "Contratacion";
            this.Contratacion.Name = "Contratacion";
            this.Contratacion.ReadOnly = true;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            this.Cargo.Width = 70;
            // 
            // VaHo
            // 
            this.VaHo.HeaderText = "VaHo";
            this.VaHo.Name = "VaHo";
            this.VaHo.ReadOnly = true;
            this.VaHo.Width = 65;
            // 
            // VaHoEx
            // 
            this.VaHoEx.HeaderText = "VaHoEx";
            this.VaHoEx.Name = "VaHoEx";
            this.VaHoEx.ReadOnly = true;
            this.VaHoEx.Width = 80;
            // 
            // TextBox1
            // 
            this.TextBox1.Enabled = false;
            this.TextBox1.Location = new System.Drawing.Point(209, 707);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(101, 20);
            this.TextBox1.TabIndex = 271;
            this.TextBox1.TabStop = false;
            this.TextBox1.Visible = false;
            // 
            // comboFD
            // 
            this.comboFD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFD.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFD.FormattingEnabled = true;
            this.comboFD.Location = new System.Drawing.Point(31, 142);
            this.comboFD.Name = "comboFD";
            this.comboFD.Size = new System.Drawing.Size(269, 33);
            this.comboFD.TabIndex = 273;
            this.comboFD.TabStop = false;
            // 
            // labelFiltrar
            // 
            this.labelFiltrar.AutoSize = true;
            this.labelFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.labelFiltrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltrar.ForeColor = System.Drawing.Color.White;
            this.labelFiltrar.Location = new System.Drawing.Point(26, 112);
            this.labelFiltrar.Name = "labelFiltrar";
            this.labelFiltrar.Size = new System.Drawing.Size(106, 25);
            this.labelFiltrar.TabIndex = 274;
            this.labelFiltrar.Text = "Buscar por:";
            // 
            // butBuscar
            // 
            this.butBuscar.BackColor = System.Drawing.Color.Transparent;
            this.butBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butBuscar.BackgroundImage")));
            this.butBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBuscar.Location = new System.Drawing.Point(671, 138);
            this.butBuscar.Name = "butBuscar";
            this.butBuscar.Size = new System.Drawing.Size(103, 38);
            this.butBuscar.TabIndex = 275;
            this.butBuscar.TabStop = false;
            this.butBuscar.Text = "Buscar";
            this.butBuscar.UseVisualStyleBackColor = false;
            this.butBuscar.Click += new System.EventHandler(this.butBuscar_Click);
            // 
            // textFiltro
            // 
            this.textFiltro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFiltro.Location = new System.Drawing.Point(382, 142);
            this.textFiltro.Name = "textFiltro";
            this.textFiltro.Size = new System.Drawing.Size(271, 33);
            this.textFiltro.TabIndex = 276;
            this.textFiltro.TabStop = false;
            this.textFiltro.TextChanged += new System.EventHandler(this.textFiltro_TextChanged);
            // 
            // butLimpiar
            // 
            this.butLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.butLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butLimpiar.BackgroundImage")));
            this.butLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLimpiar.Location = new System.Drawing.Point(780, 138);
            this.butLimpiar.Name = "butLimpiar";
            this.butLimpiar.Size = new System.Drawing.Size(103, 38);
            this.butLimpiar.TabIndex = 277;
            this.butLimpiar.TabStop = false;
            this.butLimpiar.Text = "Limpiar Filtros";
            this.butLimpiar.UseVisualStyleBackColor = false;
            this.butLimpiar.Click += new System.EventHandler(this.butLimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(377, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 25);
            this.label2.TabIndex = 278;
            this.label2.Text = "Ingrese dato para su busqueda:";
            // 
            // butSueld
            // 
            this.butSueld.BackColor = System.Drawing.Color.Transparent;
            this.butSueld.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butSueld.BackgroundImage")));
            this.butSueld.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butSueld.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSueld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSueld.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSueld.Location = new System.Drawing.Point(659, 527);
            this.butSueld.Name = "butSueld";
            this.butSueld.Size = new System.Drawing.Size(115, 38);
            this.butSueld.TabIndex = 279;
            this.butSueld.TabStop = false;
            this.butSueld.Text = "Sueldos";
            this.butSueld.UseVisualStyleBackColor = false;
            this.butSueld.Click += new System.EventHandler(this.butSueld_Click);
            // 
            // Cons_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 590);
            this.Controls.Add(this.butSueld);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butLimpiar);
            this.Controls.Add(this.textFiltro);
            this.Controls.Add(this.butBuscar);
            this.Controls.Add(this.labelFiltrar);
            this.Controls.Add(this.comboFD);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.labelTipUsu);
            this.Controls.Add(this.labelNombreUsu);
            this.Controls.Add(this.butSalir);
            this.Controls.Add(this.butInicio);
            this.Controls.Add(this.butEli);
            this.Controls.Add(this.butMod);
            this.Controls.Add(this.butIng);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cons_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Cons_Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button butIng;
        public System.Windows.Forms.Button butMod;
        public System.Windows.Forms.Button butEli;
        public System.Windows.Forms.Button butInicio;
        public System.Windows.Forms.Button butSalir;
        public System.Windows.Forms.Label labelTipUsu;
        public System.Windows.Forms.Label labelNombreUsu;
        public System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox TextBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboFD;
        public System.Windows.Forms.Label labelFiltrar;
        public System.Windows.Forms.Button butBuscar;
        public System.Windows.Forms.TextBox textFiltro;
        public System.Windows.Forms.Button butLimpiar;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button butSueld;
        private System.Windows.Forms.DataGridViewButtonColumn Selec;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contratacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VaHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VaHoEx;
    }
}