namespace Obligatorio1DDA
{
    partial class PantallaPorDefecto
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
            this.label2 = new System.Windows.Forms.Label();
            this.fotoDePajaroGrande = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fotoDePajaroGrande)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(147)))));
            this.label2.Location = new System.Drawing.Point(100, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Seleccione una accion a realizar!";
            // 
            // fotoDePajaroGrande
            // 
            this.fotoDePajaroGrande.Image = global::Obligatorio1DDA.Properties.Resources.pajaros2;
            this.fotoDePajaroGrande.Location = new System.Drawing.Point(408, 228);
            this.fotoDePajaroGrande.Name = "fotoDePajaroGrande";
            this.fotoDePajaroGrande.Size = new System.Drawing.Size(403, 376);
            this.fotoDePajaroGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoDePajaroGrande.TabIndex = 14;
            this.fotoDePajaroGrande.TabStop = false;
            // 
            // PanelPorDefecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(945, 895);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fotoDePajaroGrande);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelPorDefecto";
            this.Text = "PanelPorDefecto";
            ((System.ComponentModel.ISupportInitialize)(this.fotoDePajaroGrande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox fotoDePajaroGrande;
    }
}