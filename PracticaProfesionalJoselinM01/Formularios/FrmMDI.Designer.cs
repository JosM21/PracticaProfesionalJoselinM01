namespace PracticaProfesionalJoselinM01.Formularios
{
    partial class FrmMDI
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
            this.MnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MnuGestiones = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProovedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.tomaFisicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSeguridad = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.versiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuPrincipal
            // 
            this.MnuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MnuPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MnuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuGestiones,
            this.MnuProcesos,
            this.MnuSeguridad,
            this.MnuAyuda,
            this.MnuSalir});
            this.MnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MnuPrincipal.Name = "MnuPrincipal";
            this.MnuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MnuPrincipal.Size = new System.Drawing.Size(1042, 28);
            this.MnuPrincipal.TabIndex = 1;
            this.MnuPrincipal.Text = "MnuPrincpal";
            // 
            // MnuGestiones
            // 
            this.MnuGestiones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.ProductosToolStripMenuItem,
            this.ProovedoresToolStripMenuItem,
            this.toolStripSeparator2,
            this.CategoriasToolStripMenuItem,
            this.MarcasToolStripMenuItem});
            this.MnuGestiones.ForeColor = System.Drawing.Color.Silver;
            this.MnuGestiones.Name = "MnuGestiones";
            this.MnuGestiones.Size = new System.Drawing.Size(130, 24);
            this.MnuGestiones.Text = "Mantenimientos";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // ProductosToolStripMenuItem
            // 
            this.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem";
            this.ProductosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ProductosToolStripMenuItem.Text = "Productos";
            this.ProductosToolStripMenuItem.Click += new System.EventHandler(this.ProductosToolStripMenuItem_Click);
            // 
            // ProovedoresToolStripMenuItem
            // 
            this.ProovedoresToolStripMenuItem.Name = "ProovedoresToolStripMenuItem";
            this.ProovedoresToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ProovedoresToolStripMenuItem.Text = "Proovedores";
            this.ProovedoresToolStripMenuItem.Click += new System.EventHandler(this.ProovedoresToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // CategoriasToolStripMenuItem
            // 
            this.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem";
            this.CategoriasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.CategoriasToolStripMenuItem.Text = "Categorias";
            this.CategoriasToolStripMenuItem.Click += new System.EventHandler(this.CategoriasToolStripMenuItem_Click);
            // 
            // MarcasToolStripMenuItem
            // 
            this.MarcasToolStripMenuItem.Name = "MarcasToolStripMenuItem";
            this.MarcasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.MarcasToolStripMenuItem.Text = "Marcas";
            this.MarcasToolStripMenuItem.Click += new System.EventHandler(this.MarcasToolStripMenuItem_Click);
            // 
            // MnuProcesos
            // 
            this.MnuProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tomaFisicaToolStripMenuItem});
            this.MnuProcesos.ForeColor = System.Drawing.Color.Silver;
            this.MnuProcesos.Name = "MnuProcesos";
            this.MnuProcesos.Size = new System.Drawing.Size(81, 24);
            this.MnuProcesos.Text = "Procesos";
            // 
            // tomaFisicaToolStripMenuItem
            // 
            this.tomaFisicaToolStripMenuItem.Name = "tomaFisicaToolStripMenuItem";
            this.tomaFisicaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tomaFisicaToolStripMenuItem.Text = "Toma Fisica";
            // 
            // MnuSeguridad
            // 
            this.MnuSeguridad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.MnuSeguridad.ForeColor = System.Drawing.Color.Silver;
            this.MnuSeguridad.Name = "MnuSeguridad";
            this.MnuSeguridad.Size = new System.Drawing.Size(91, 24);
            this.MnuSeguridad.Text = "Seguridad";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // MnuAyuda
            // 
            this.MnuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versiónToolStripMenuItem,
            this.manualDeUsuarioToolStripMenuItem});
            this.MnuAyuda.ForeColor = System.Drawing.Color.Silver;
            this.MnuAyuda.Name = "MnuAyuda";
            this.MnuAyuda.Size = new System.Drawing.Size(65, 24);
            this.MnuAyuda.Text = "Ayuda";
            // 
            // versiónToolStripMenuItem
            // 
            this.versiónToolStripMenuItem.Name = "versiónToolStripMenuItem";
            this.versiónToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.versiónToolStripMenuItem.Text = "Versión";
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de Usuario";
            // 
            // MnuSalir
            // 
            this.MnuSalir.ForeColor = System.Drawing.Color.Silver;
            this.MnuSalir.Name = "MnuSalir";
            this.MnuSalir.Size = new System.Drawing.Size(52, 24);
            this.MnuSalir.Text = "Salir";
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 617);
            this.Controls.Add(this.MnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MnuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FrmMDI";
            this.Text = "FrmMDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMDI_FormClosed);
            this.MnuPrincipal.ResumeLayout(false);
            this.MnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MnuGestiones;
        private System.Windows.Forms.ToolStripMenuItem MnuProcesos;
        private System.Windows.Forms.ToolStripMenuItem MnuSeguridad;
        private System.Windows.Forms.ToolStripMenuItem MnuAyuda;
        private System.Windows.Forms.ToolStripMenuItem MnuSalir;
        private System.Windows.Forms.ToolStripMenuItem ProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProovedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tomaFisicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}