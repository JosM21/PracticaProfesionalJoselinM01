namespace PracticaProfesionalJoselinM01.Formularios
{
    partial class FrmUsuario
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
            this.CBoxVerActivos = new System.Windows.Forms.CheckBox();
            this.DgLista = new System.Windows.Forms.DataGridView();
            this.CidUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ctelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdescripcionRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbRolesUsuario = new System.Windows.Forms.ComboBox();
            this.TxtUsuarioDireccion = new System.Windows.Forms.TextBox();
            this.TxtUsuarioContrasennia = new System.Windows.Forms.TextBox();
            this.TxtUsuarioCorreo = new System.Windows.Forms.TextBox();
            this.TxtUsuarioTelefono = new System.Windows.Forms.TextBox();
            this.TxtUsuarioCedula = new System.Windows.Forms.TextBox();
            this.TxtUsuarioNombre = new System.Windows.Forms.TextBox();
            this.TxtUsuarioID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(40, 583);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(136, 586);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(840, 22);
            this.TxtBuscar.TabIndex = 1;
            // 
            // CBoxVerActivos
            // 
            this.CBoxVerActivos.AutoSize = true;
            this.CBoxVerActivos.Checked = true;
            this.CBoxVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBoxVerActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxVerActivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CBoxVerActivos.Location = new System.Drawing.Point(1005, 582);
            this.CBoxVerActivos.Name = "CBoxVerActivos";
            this.CBoxVerActivos.Size = new System.Drawing.Size(134, 29);
            this.CBoxVerActivos.TabIndex = 2;
            this.CBoxVerActivos.Text = "Ver Activos";
            this.CBoxVerActivos.UseVisualStyleBackColor = true;
            // 
            // DgLista
            // 
            this.DgLista.AllowUserToAddRows = false;
            this.DgLista.AllowUserToDeleteRows = false;
            this.DgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CidUsuario,
            this.Cnombre,
            this.Ccedula,
            this.Ctelefono,
            this.Cemail,
            this.CdescripcionRol});
            this.DgLista.Location = new System.Drawing.Point(38, 333);
            this.DgLista.MultiSelect = false;
            this.DgLista.Name = "DgLista";
            this.DgLista.ReadOnly = true;
            this.DgLista.RowHeadersVisible = false;
            this.DgLista.RowHeadersWidth = 51;
            this.DgLista.RowTemplate.Height = 24;
            this.DgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgLista.Size = new System.Drawing.Size(1102, 230);
            this.DgLista.TabIndex = 3;
            this.DgLista.VirtualMode = true;
            this.DgLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgLista_CellClick);
            this.DgLista.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgLista_DataBindingComplete);
            // 
            // CidUsuario
            // 
            this.CidUsuario.DataPropertyName = "idUsuario";
            this.CidUsuario.HeaderText = "Código";
            this.CidUsuario.MinimumWidth = 6;
            this.CidUsuario.Name = "CidUsuario";
            this.CidUsuario.ReadOnly = true;
            this.CidUsuario.Width = 125;
            // 
            // Cnombre
            // 
            this.Cnombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cnombre.DataPropertyName = "nombre";
            this.Cnombre.HeaderText = "Nombre";
            this.Cnombre.MinimumWidth = 6;
            this.Cnombre.Name = "Cnombre";
            this.Cnombre.ReadOnly = true;
            // 
            // Ccedula
            // 
            this.Ccedula.DataPropertyName = "cedula";
            this.Ccedula.HeaderText = "Cedula";
            this.Ccedula.MinimumWidth = 6;
            this.Ccedula.Name = "Ccedula";
            this.Ccedula.ReadOnly = true;
            this.Ccedula.Width = 125;
            // 
            // Ctelefono
            // 
            this.Ctelefono.DataPropertyName = "telefono";
            this.Ctelefono.HeaderText = "Teléfono";
            this.Ctelefono.MinimumWidth = 6;
            this.Ctelefono.Name = "Ctelefono";
            this.Ctelefono.ReadOnly = true;
            this.Ctelefono.Width = 125;
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
            // CdescripcionRol
            // 
            this.CdescripcionRol.DataPropertyName = "descripcionRol";
            this.CdescripcionRol.HeaderText = "Rol";
            this.CdescripcionRol.MinimumWidth = 6;
            this.CdescripcionRol.Name = "CdescripcionRol";
            this.CdescripcionRol.ReadOnly = true;
            this.CdescripcionRol.Width = 125;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Salmon;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(938, 263);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(204, 50);
            this.BtnCancelar.TabIndex = 14;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(712, 263);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(204, 50);
            this.BtnLimpiar.TabIndex = 13;
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
            this.BtnEliminar.Location = new System.Drawing.Point(491, 263);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(204, 50);
            this.BtnEliminar.TabIndex = 12;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Orange;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(268, 263);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(205, 50);
            this.BtnModificar.TabIndex = 11;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(41, 263);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(204, 50);
            this.BtnAgregar.TabIndex = 10;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbRolesUsuario);
            this.groupBox1.Controls.Add(this.TxtUsuarioDireccion);
            this.groupBox1.Controls.Add(this.TxtUsuarioContrasennia);
            this.groupBox1.Controls.Add(this.TxtUsuarioCorreo);
            this.groupBox1.Controls.Add(this.TxtUsuarioTelefono);
            this.groupBox1.Controls.Add(this.TxtUsuarioCedula);
            this.groupBox1.Controls.Add(this.TxtUsuarioNombre);
            this.groupBox1.Controls.Add(this.TxtUsuarioID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(41, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1098, 212);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Usuario";
            // 
            // CbRolesUsuario
            // 
            this.CbRolesUsuario.BackColor = System.Drawing.Color.White;
            this.CbRolesUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbRolesUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbRolesUsuario.ForeColor = System.Drawing.Color.Black;
            this.CbRolesUsuario.FormattingEnabled = true;
            this.CbRolesUsuario.Location = new System.Drawing.Point(706, 34);
            this.CbRolesUsuario.Name = "CbRolesUsuario";
            this.CbRolesUsuario.Size = new System.Drawing.Size(373, 28);
            this.CbRolesUsuario.TabIndex = 16;
            // 
            // TxtUsuarioDireccion
            // 
            this.TxtUsuarioDireccion.BackColor = System.Drawing.Color.White;
            this.TxtUsuarioDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuarioDireccion.ForeColor = System.Drawing.Color.Black;
            this.TxtUsuarioDireccion.Location = new System.Drawing.Point(706, 157);
            this.TxtUsuarioDireccion.Multiline = true;
            this.TxtUsuarioDireccion.Name = "TxtUsuarioDireccion";
            this.TxtUsuarioDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtUsuarioDireccion.Size = new System.Drawing.Size(373, 35);
            this.TxtUsuarioDireccion.TabIndex = 15;
            this.TxtUsuarioDireccion.UseSystemPasswordChar = true;
            // 
            // TxtUsuarioContrasennia
            // 
            this.TxtUsuarioContrasennia.BackColor = System.Drawing.Color.White;
            this.TxtUsuarioContrasennia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuarioContrasennia.ForeColor = System.Drawing.Color.Black;
            this.TxtUsuarioContrasennia.Location = new System.Drawing.Point(706, 117);
            this.TxtUsuarioContrasennia.Name = "TxtUsuarioContrasennia";
            this.TxtUsuarioContrasennia.Size = new System.Drawing.Size(373, 27);
            this.TxtUsuarioContrasennia.TabIndex = 14;
            this.TxtUsuarioContrasennia.UseSystemPasswordChar = true;
            // 
            // TxtUsuarioCorreo
            // 
            this.TxtUsuarioCorreo.BackColor = System.Drawing.Color.White;
            this.TxtUsuarioCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuarioCorreo.ForeColor = System.Drawing.Color.Black;
            this.TxtUsuarioCorreo.Location = new System.Drawing.Point(706, 77);
            this.TxtUsuarioCorreo.Name = "TxtUsuarioCorreo";
            this.TxtUsuarioCorreo.Size = new System.Drawing.Size(373, 27);
            this.TxtUsuarioCorreo.TabIndex = 13;
            // 
            // TxtUsuarioTelefono
            // 
            this.TxtUsuarioTelefono.BackColor = System.Drawing.Color.White;
            this.TxtUsuarioTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuarioTelefono.ForeColor = System.Drawing.Color.Black;
            this.TxtUsuarioTelefono.Location = new System.Drawing.Point(128, 160);
            this.TxtUsuarioTelefono.Name = "TxtUsuarioTelefono";
            this.TxtUsuarioTelefono.Size = new System.Drawing.Size(371, 27);
            this.TxtUsuarioTelefono.TabIndex = 11;
            // 
            // TxtUsuarioCedula
            // 
            this.TxtUsuarioCedula.BackColor = System.Drawing.Color.White;
            this.TxtUsuarioCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuarioCedula.ForeColor = System.Drawing.Color.Black;
            this.TxtUsuarioCedula.Location = new System.Drawing.Point(128, 119);
            this.TxtUsuarioCedula.Name = "TxtUsuarioCedula";
            this.TxtUsuarioCedula.Size = new System.Drawing.Size(371, 27);
            this.TxtUsuarioCedula.TabIndex = 10;
            // 
            // TxtUsuarioNombre
            // 
            this.TxtUsuarioNombre.BackColor = System.Drawing.Color.White;
            this.TxtUsuarioNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuarioNombre.ForeColor = System.Drawing.Color.Black;
            this.TxtUsuarioNombre.Location = new System.Drawing.Point(128, 78);
            this.TxtUsuarioNombre.Name = "TxtUsuarioNombre";
            this.TxtUsuarioNombre.Size = new System.Drawing.Size(371, 27);
            this.TxtUsuarioNombre.TabIndex = 9;
            // 
            // TxtUsuarioID
            // 
            this.TxtUsuarioID.BackColor = System.Drawing.Color.White;
            this.TxtUsuarioID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuarioID.ForeColor = System.Drawing.Color.Black;
            this.TxtUsuarioID.Location = new System.Drawing.Point(128, 37);
            this.TxtUsuarioID.Name = "TxtUsuarioID";
            this.TxtUsuarioID.ReadOnly = true;
            this.TxtUsuarioID.Size = new System.Drawing.Size(371, 27);
            this.TxtUsuarioID.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(534, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Direccion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(534, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rol de Usuario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(534, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(534, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cedula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Codigo:";
            // 
            // FrmUsuario
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
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuariosGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.CheckBox CBoxVerActivos;
        private System.Windows.Forms.DataGridView DgLista;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbRolesUsuario;
        private System.Windows.Forms.TextBox TxtUsuarioDireccion;
        private System.Windows.Forms.TextBox TxtUsuarioContrasennia;
        private System.Windows.Forms.TextBox TxtUsuarioCorreo;
        private System.Windows.Forms.TextBox TxtUsuarioTelefono;
        private System.Windows.Forms.TextBox TxtUsuarioCedula;
        private System.Windows.Forms.TextBox TxtUsuarioNombre;
        private System.Windows.Forms.TextBox TxtUsuarioID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn CidUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ctelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdescripcionRol;
    }
}