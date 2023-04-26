
namespace P520231_RoyR.Formularios
{
    partial class FrmProveedorGestion
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CboxVerActivos = new System.Windows.Forms.CheckBox();
            this.DgLista = new System.Windows.Forms.DataGridView();
            this.CProveedorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProveedorNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProveedorCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbTiposProveedor = new System.Windows.Forms.ComboBox();
            this.TxtProveedorNotas = new System.Windows.Forms.TextBox();
            this.TxtProveedorDireccion = new System.Windows.Forms.TextBox();
            this.TxtProveedorEmail = new System.Windows.Forms.TextBox();
            this.TxtProveedorCedula = new System.Windows.Forms.TextBox();
            this.TxtProveedorNombre = new System.Windows.Forms.TextBox();
            this.TxtProveedorID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TxtBuscar.Location = new System.Drawing.Point(264, 28);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(260, 22);
            this.TxtBuscar.TabIndex = 1;
            this.TxtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CboxVerActivos
            // 
            this.CboxVerActivos.AutoSize = true;
            this.CboxVerActivos.Checked = true;
            this.CboxVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CboxVerActivos.Location = new System.Drawing.Point(625, 28);
            this.CboxVerActivos.Name = "CboxVerActivos";
            this.CboxVerActivos.Size = new System.Drawing.Size(177, 20);
            this.CboxVerActivos.TabIndex = 2;
            this.CboxVerActivos.Text = "Ver Proveedores Activos";
            this.CboxVerActivos.UseVisualStyleBackColor = true;
            // 
            // DgLista
            // 
            this.DgLista.AllowUserToAddRows = false;
            this.DgLista.AllowUserToDeleteRows = false;
            this.DgLista.AllowUserToOrderColumns = true;
            this.DgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CProveedorID,
            this.CProveedorNombre,
            this.CProveedorCedula});
            this.DgLista.Location = new System.Drawing.Point(33, 82);
            this.DgLista.MultiSelect = false;
            this.DgLista.Name = "DgLista";
            this.DgLista.ReadOnly = true;
            this.DgLista.RowHeadersVisible = false;
            this.DgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgLista.Size = new System.Drawing.Size(769, 202);
            this.DgLista.TabIndex = 3;
            this.DgLista.VirtualMode = true;
            this.DgLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgLista_CellClick);
            this.DgLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgLista_CellContentClick);
            this.DgLista.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgLista_DataBindingComplete);
            // 
            // CProveedorID
            // 
            this.CProveedorID.DataPropertyName = "ProveedorID";
            this.CProveedorID.HeaderText = "Cod Proveedor";
            this.CProveedorID.Name = "CProveedorID";
            this.CProveedorID.ReadOnly = true;
            // 
            // CProveedorNombre
            // 
            this.CProveedorNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CProveedorNombre.DataPropertyName = "ProveedorNombre";
            this.CProveedorNombre.HeaderText = "Nombre";
            this.CProveedorNombre.Name = "CProveedorNombre";
            this.CProveedorNombre.ReadOnly = true;
            // 
            // CProveedorCedula
            // 
            this.CProveedorCedula.DataPropertyName = "ProveedorCedula";
            this.CProveedorCedula.HeaderText = "Cedula";
            this.CProveedorCedula.Name = "CProveedorCedula";
            this.CProveedorCedula.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbTiposProveedor);
            this.groupBox1.Controls.Add(this.TxtProveedorNotas);
            this.groupBox1.Controls.Add(this.TxtProveedorDireccion);
            this.groupBox1.Controls.Add(this.TxtProveedorEmail);
            this.groupBox1.Controls.Add(this.TxtProveedorCedula);
            this.groupBox1.Controls.Add(this.TxtProveedorNombre);
            this.groupBox1.Controls.Add(this.TxtProveedorID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(33, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 203);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Proveedor";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CbTiposProveedor
            // 
            this.CbTiposProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTiposProveedor.FormattingEnabled = true;
            this.CbTiposProveedor.Location = new System.Drawing.Point(476, 33);
            this.CbTiposProveedor.Name = "CbTiposProveedor";
            this.CbTiposProveedor.Size = new System.Drawing.Size(233, 24);
            this.CbTiposProveedor.TabIndex = 13;
            // 
            // TxtProveedorNotas
            // 
            this.TxtProveedorNotas.Location = new System.Drawing.Point(449, 76);
            this.TxtProveedorNotas.Name = "TxtProveedorNotas";
            this.TxtProveedorNotas.Size = new System.Drawing.Size(260, 22);
            this.TxtProveedorNotas.TabIndex = 12;
            // 
            // TxtProveedorDireccion
            // 
            this.TxtProveedorDireccion.Location = new System.Drawing.Point(451, 122);
            this.TxtProveedorDireccion.Multiline = true;
            this.TxtProveedorDireccion.Name = "TxtProveedorDireccion";
            this.TxtProveedorDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtProveedorDireccion.Size = new System.Drawing.Size(258, 57);
            this.TxtProveedorDireccion.TabIndex = 11;
            // 
            // TxtProveedorEmail
            // 
            this.TxtProveedorEmail.Location = new System.Drawing.Point(155, 128);
            this.TxtProveedorEmail.Name = "TxtProveedorEmail";
            this.TxtProveedorEmail.Size = new System.Drawing.Size(204, 22);
            this.TxtProveedorEmail.TabIndex = 10;
            // 
            // TxtProveedorCedula
            // 
            this.TxtProveedorCedula.Location = new System.Drawing.Point(155, 98);
            this.TxtProveedorCedula.Name = "TxtProveedorCedula";
            this.TxtProveedorCedula.Size = new System.Drawing.Size(204, 22);
            this.TxtProveedorCedula.TabIndex = 9;
            // 
            // TxtProveedorNombre
            // 
            this.TxtProveedorNombre.Location = new System.Drawing.Point(155, 63);
            this.TxtProveedorNombre.Name = "TxtProveedorNombre";
            this.TxtProveedorNombre.Size = new System.Drawing.Size(204, 22);
            this.TxtProveedorNombre.TabIndex = 8;
            // 
            // TxtProveedorID
            // 
            this.TxtProveedorID.Location = new System.Drawing.Point(155, 30);
            this.TxtProveedorID.Name = "TxtProveedorID";
            this.TxtProveedorID.ReadOnly = true;
            this.TxtProveedorID.Size = new System.Drawing.Size(204, 22);
            this.TxtProveedorID.TabIndex = 7;
            this.TxtProveedorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tipo Proveedor";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Notas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Direccion";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cod Proveedor";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Location = new System.Drawing.Point(188, 499);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(144, 42);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Location = new System.Drawing.Point(519, 499);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(144, 42);
            this.BtnLimpiar.TabIndex = 6;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FrmProveedorGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 567);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgLista);
            this.Controls.Add(this.CboxVerActivos);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmProveedorGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Proveedores";
            this.Load += new System.EventHandler(this.FrmProveedorGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.CheckBox CboxVerActivos;
        private System.Windows.Forms.DataGridView DgLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbTiposProveedor;
        private System.Windows.Forms.TextBox TxtProveedorNotas;
        private System.Windows.Forms.TextBox TxtProveedorDireccion;
        private System.Windows.Forms.TextBox TxtProveedorEmail;
        private System.Windows.Forms.TextBox TxtProveedorCedula;
        private System.Windows.Forms.TextBox TxtProveedorNombre;
        private System.Windows.Forms.TextBox TxtProveedorID;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedorNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedorCedula;
    }
}