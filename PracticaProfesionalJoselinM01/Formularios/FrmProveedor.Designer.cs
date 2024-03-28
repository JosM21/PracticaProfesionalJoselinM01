namespace PracticaProfesionalJoselinM01.Formularios
{
    partial class FrmProveedor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtProveedorDireccion = new System.Windows.Forms.TextBox();
            this.TxtProveedorCorreo = new System.Windows.Forms.TextBox();
            this.TxtProveedorTelefono = new System.Windows.Forms.TextBox();
            this.TxtProveedorCedula = new System.Windows.Forms.TextBox();
            this.TxtProveedorNombre = new System.Windows.Forms.TextBox();
            this.TxtProveedorID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DgLista = new System.Windows.Forms.DataGridView();
            this.CidProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CnombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ctelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBoxVerActivos = new System.Windows.Forms.CheckBox();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtProveedorDireccion);
            this.groupBox1.Controls.Add(this.TxtProveedorCorreo);
            this.groupBox1.Controls.Add(this.TxtProveedorTelefono);
            this.groupBox1.Controls.Add(this.TxtProveedorCedula);
            this.groupBox1.Controls.Add(this.TxtProveedorNombre);
            this.groupBox1.Controls.Add(this.TxtProveedorID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(41, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1098, 212);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Proveedor";
            // 
            // TxtProveedorDireccion
            // 
            this.TxtProveedorDireccion.BackColor = System.Drawing.Color.White;
            this.TxtProveedorDireccion.ForeColor = System.Drawing.Color.Black;
            this.TxtProveedorDireccion.Location = new System.Drawing.Point(698, 82);
            this.TxtProveedorDireccion.Multiline = true;
            this.TxtProveedorDireccion.Name = "TxtProveedorDireccion";
            this.TxtProveedorDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtProveedorDireccion.Size = new System.Drawing.Size(373, 108);
            this.TxtProveedorDireccion.TabIndex = 15;
            this.TxtProveedorDireccion.UseSystemPasswordChar = true;
            // 
            // TxtProveedorCorreo
            // 
            this.TxtProveedorCorreo.BackColor = System.Drawing.Color.White;
            this.TxtProveedorCorreo.ForeColor = System.Drawing.Color.Black;
            this.TxtProveedorCorreo.Location = new System.Drawing.Point(698, 37);
            this.TxtProveedorCorreo.Name = "TxtProveedorCorreo";
            this.TxtProveedorCorreo.Size = new System.Drawing.Size(373, 30);
            this.TxtProveedorCorreo.TabIndex = 13;
            // 
            // TxtProveedorTelefono
            // 
            this.TxtProveedorTelefono.BackColor = System.Drawing.Color.White;
            this.TxtProveedorTelefono.ForeColor = System.Drawing.Color.Black;
            this.TxtProveedorTelefono.Location = new System.Drawing.Point(137, 161);
            this.TxtProveedorTelefono.Name = "TxtProveedorTelefono";
            this.TxtProveedorTelefono.Size = new System.Drawing.Size(371, 30);
            this.TxtProveedorTelefono.TabIndex = 11;
            // 
            // TxtProveedorCedula
            // 
            this.TxtProveedorCedula.BackColor = System.Drawing.Color.White;
            this.TxtProveedorCedula.ForeColor = System.Drawing.Color.Black;
            this.TxtProveedorCedula.Location = new System.Drawing.Point(137, 120);
            this.TxtProveedorCedula.Name = "TxtProveedorCedula";
            this.TxtProveedorCedula.Size = new System.Drawing.Size(371, 30);
            this.TxtProveedorCedula.TabIndex = 10;
            // 
            // TxtProveedorNombre
            // 
            this.TxtProveedorNombre.BackColor = System.Drawing.Color.White;
            this.TxtProveedorNombre.ForeColor = System.Drawing.Color.Black;
            this.TxtProveedorNombre.Location = new System.Drawing.Point(137, 79);
            this.TxtProveedorNombre.Name = "TxtProveedorNombre";
            this.TxtProveedorNombre.Size = new System.Drawing.Size(371, 30);
            this.TxtProveedorNombre.TabIndex = 9;
            // 
            // TxtProveedorID
            // 
            this.TxtProveedorID.BackColor = System.Drawing.Color.White;
            this.TxtProveedorID.ForeColor = System.Drawing.Color.Black;
            this.TxtProveedorID.Location = new System.Drawing.Point(137, 38);
            this.TxtProveedorID.Name = "TxtProveedorID";
            this.TxtProveedorID.ReadOnly = true;
            this.TxtProveedorID.Size = new System.Drawing.Size(371, 30);
            this.TxtProveedorID.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(588, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Direccion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cedula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Codigo:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Salmon;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(938, 277);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(204, 50);
            this.BtnCancelar.TabIndex = 24;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(712, 277);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(204, 50);
            this.BtnLimpiar.TabIndex = 23;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(491, 277);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(204, 50);
            this.BtnEliminar.TabIndex = 22;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Orange;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(268, 277);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(205, 50);
            this.BtnModificar.TabIndex = 21;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(41, 277);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(204, 50);
            this.BtnAgregar.TabIndex = 20;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // DgLista
            // 
            this.DgLista.AllowUserToAddRows = false;
            this.DgLista.AllowUserToDeleteRows = false;
            this.DgLista.AllowUserToOrderColumns = true;
            this.DgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CidProveedor,
            this.CnombreProveedor,
            this.Ctelefono,
            this.Cemail,
            this.Ccedula});
            this.DgLista.Location = new System.Drawing.Point(37, 347);
            this.DgLista.MultiSelect = false;
            this.DgLista.Name = "DgLista";
            this.DgLista.ReadOnly = true;
            this.DgLista.RowHeadersVisible = false;
            this.DgLista.RowHeadersWidth = 51;
            this.DgLista.RowTemplate.Height = 24;
            this.DgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgLista.Size = new System.Drawing.Size(1102, 193);
            this.DgLista.TabIndex = 19;
            this.DgLista.VirtualMode = true;
            this.DgLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgLista_CellClick);
            this.DgLista.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgLista_DataBindingComplete);
            // 
            // CidProveedor
            // 
            this.CidProveedor.DataPropertyName = "idProveedor";
            this.CidProveedor.HeaderText = "Código";
            this.CidProveedor.MinimumWidth = 6;
            this.CidProveedor.Name = "CidProveedor";
            this.CidProveedor.ReadOnly = true;
            this.CidProveedor.Width = 125;
            // 
            // CnombreProveedor
            // 
            this.CnombreProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CnombreProveedor.DataPropertyName = "nombreProveedor";
            this.CnombreProveedor.HeaderText = "Nombre";
            this.CnombreProveedor.MinimumWidth = 6;
            this.CnombreProveedor.Name = "CnombreProveedor";
            this.CnombreProveedor.ReadOnly = true;
            // 
            // Ctelefono
            // 
            this.Ctelefono.DataPropertyName = "telefono";
            this.Ctelefono.HeaderText = "Teléfono";
            this.Ctelefono.MinimumWidth = 6;
            this.Ctelefono.Name = "Ctelefono";
            this.Ctelefono.ReadOnly = true;
            this.Ctelefono.Width = 200;
            // 
            // Cemail
            // 
            this.Cemail.DataPropertyName = "email";
            this.Cemail.HeaderText = "Email";
            this.Cemail.MinimumWidth = 6;
            this.Cemail.Name = "Cemail";
            this.Cemail.ReadOnly = true;
            this.Cemail.Width = 200;
            // 
            // Ccedula
            // 
            this.Ccedula.DataPropertyName = "cedula";
            this.Ccedula.HeaderText = "Cedula";
            this.Ccedula.MinimumWidth = 6;
            this.Ccedula.Name = "Ccedula";
            this.Ccedula.ReadOnly = true;
            this.Ccedula.Width = 200;
            // 
            // CBoxVerActivos
            // 
            this.CBoxVerActivos.AutoSize = true;
            this.CBoxVerActivos.Checked = true;
            this.CBoxVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBoxVerActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxVerActivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CBoxVerActivos.Location = new System.Drawing.Point(1005, 571);
            this.CBoxVerActivos.Name = "CBoxVerActivos";
            this.CBoxVerActivos.Size = new System.Drawing.Size(134, 29);
            this.CBoxVerActivos.TabIndex = 18;
            this.CBoxVerActivos.Text = "Ver Activos";
            this.CBoxVerActivos.UseVisualStyleBackColor = true;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(128, 575);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(852, 22);
            this.TxtBuscar.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(32, 572);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Buscar";
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1174, 636);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DgLista);
            this.Controls.Add(this.CBoxVerActivos);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Proveedor";
            this.Load += new System.EventHandler(this.FrmProveedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtProveedorDireccion;
        private System.Windows.Forms.TextBox TxtProveedorCorreo;
        private System.Windows.Forms.TextBox TxtProveedorTelefono;
        private System.Windows.Forms.TextBox TxtProveedorCedula;
        private System.Windows.Forms.TextBox TxtProveedorNombre;
        private System.Windows.Forms.TextBox TxtProveedorID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView DgLista;
        private System.Windows.Forms.CheckBox CBoxVerActivos;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CidProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CnombreProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ctelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccedula;
    }
}