namespace Obligatorio1DDA
{
    partial class PantallaReporteEstadisticas
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
            this.titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.titulo.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(0, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(945, 139);
            this.titulo.TabIndex = 5;
            this.titulo.Text = "REPORTES DE ESTADISTICAS";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.titulo.Click += new System.EventHandler(this.titulo_Click);
            // 
            // PantallaReporteEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(945, 895);
            this.Controls.Add(this.titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaReporteEstadisticas";
            this.Text = "PantallaReporteEstadisticas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titulo;
    }
}