namespace PracticaProfesionalJoselinM01.Formularios
{
    partial class FrmMostrarTomasFisicas
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
            this.RptMostrarTomasFisicas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.TomasFisicas11 = new PracticaProfesionalJoselinM01.Reportes.TomasFisicas1();
            this.SuspendLayout();
            // 
            // RptMostrarTomasFisicas
            // 
            this.RptMostrarTomasFisicas.ActiveViewIndex = -1;
            this.RptMostrarTomasFisicas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RptMostrarTomasFisicas.Cursor = System.Windows.Forms.Cursors.Default;
            this.RptMostrarTomasFisicas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RptMostrarTomasFisicas.Location = new System.Drawing.Point(0, 0);
            this.RptMostrarTomasFisicas.Name = "RptMostrarTomasFisicas";
            this.RptMostrarTomasFisicas.ReportSource = this.TomasFisicas11;
            this.RptMostrarTomasFisicas.Size = new System.Drawing.Size(800, 450);
            this.RptMostrarTomasFisicas.TabIndex = 0;
            this.RptMostrarTomasFisicas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.RptMostrarTomasFisicas.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // FrmMostrarTomasFisicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RptMostrarTomasFisicas);
            this.Name = "FrmMostrarTomasFisicas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTomasFisicas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMostrarTomasFisicas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer RptMostrarTomasFisicas;
        private Reportes.TomasFisicas1 TomasFisicas11;
    }
}