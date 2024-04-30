namespace PracticaProfesionalJoselinM01.Formularios
{
    partial class FrmTomaFisica
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fechaCompra = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNotas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.DgLista = new System.Windows.Forms.DataGridView();
            this.CfkIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CnombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cdiferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fechaCompra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtNotas);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toma Fisica";
            // 
            // fechaCompra
            // 
            this.fechaCompra.Location = new System.Drawing.Point(107, 45);
            this.fechaCompra.Name = "fechaCompra";
            this.fechaCompra.Size = new System.Drawing.Size(374, 30);
            this.fechaCompra.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fecha:";
            // 
            // TxtNotas
            // 
            this.TxtNotas.BackColor = System.Drawing.Color.White;
            this.TxtNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNotas.ForeColor = System.Drawing.Color.Black;
            this.TxtNotas.Location = new System.Drawing.Point(107, 83);
            this.TxtNotas.Multiline = true;
            this.TxtNotas.Name = "TxtNotas";
            this.TxtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtNotas.Size = new System.Drawing.Size(573, 60);
            this.TxtNotas.TabIndex = 17;
            this.TxtNotas.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Notas:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(21, 560);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(204, 50);
            this.BtnAgregar.TabIndex = 31;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Salmon;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(528, 560);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(204, 50);
            this.BtnCancelar.TabIndex = 35;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // DgLista
            // 
            this.DgLista.AllowUserToAddRows = false;
            this.DgLista.AllowUserToDeleteRows = false;
            this.DgLista.AllowUserToOrderColumns = true;
            this.DgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CfkIdProducto,
            this.CnombreProducto,
            this.Cstock,
            this.Ccantidad,
            this.Cdiferencia});
            this.DgLista.Location = new System.Drawing.Point(21, 207);
            this.DgLista.MultiSelect = false;
            this.DgLista.Name = "DgLista";
            this.DgLista.RowHeadersVisible = false;
            this.DgLista.RowHeadersWidth = 51;
            this.DgLista.RowTemplate.Height = 24;
            this.DgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgLista.Size = new System.Drawing.Size(711, 324);
            this.DgLista.TabIndex = 36;
            this.DgLista.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgLista_CellLeave);
            // 
            // CfkIdProducto
            // 
            this.CfkIdProducto.DataPropertyName = "idProducto";
            this.CfkIdProducto.HeaderText = "Código";
            this.CfkIdProducto.MinimumWidth = 6;
            this.CfkIdProducto.Name = "CfkIdProducto";
            this.CfkIdProducto.ReadOnly = true;
            this.CfkIdProducto.Width = 85;
            // 
            // CnombreProducto
            // 
            this.CnombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CnombreProducto.DataPropertyName = "nombreProducto";
            this.CnombreProducto.HeaderText = "Producto";
            this.CnombreProducto.MinimumWidth = 6;
            this.CnombreProducto.Name = "CnombreProducto";
            this.CnombreProducto.ReadOnly = true;
            // 
            // Cstock
            // 
            this.Cstock.DataPropertyName = "stock";
            this.Cstock.HeaderText = "Stock";
            this.Cstock.MinimumWidth = 6;
            this.Cstock.Name = "Cstock";
            this.Cstock.ReadOnly = true;
            this.Cstock.Width = 85;
            // 
            // Ccantidad
            // 
            this.Ccantidad.DataPropertyName = "cantidad";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Ccantidad.DefaultCellStyle = dataGridViewCellStyle1;
            this.Ccantidad.HeaderText = "Cantidad";
            this.Ccantidad.MinimumWidth = 6;
            this.Ccantidad.Name = "Ccantidad";
            this.Ccantidad.Width = 85;
            // 
            // Cdiferencia
            // 
            this.Cdiferencia.DataPropertyName = "diferencia";
            this.Cdiferencia.HeaderText = "Diferencia";
            this.Cdiferencia.MinimumWidth = 6;
            this.Cdiferencia.Name = "Cdiferencia";
            this.Cdiferencia.ReadOnly = true;
            this.Cdiferencia.Width = 85;
            // 
            // FrmTomaFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(758, 636);
            this.Controls.Add(this.DgLista);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTomaFisica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTomaFisica";
            this.Load += new System.EventHandler(this.FrmTomaFisica_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtNotas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgLista;
        private System.Windows.Forms.DateTimePicker fechaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CfkIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CnombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cdiferencia;
    }
}