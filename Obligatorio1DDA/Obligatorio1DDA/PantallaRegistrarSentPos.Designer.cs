namespace Obligatorio1DDA
{
    partial class PantallaRegistrarSentPos
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
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(82, 64);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(1084, 238);
            this.titulo.TabIndex = 5;
            this.titulo.Text = "Registrar sentimientos positivos";
            // 
            // PantallaRegistrarSentPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 885);
            this.Controls.Add(this.titulo);
            this.Name = "PantallaRegistrarSentPos";
            this.Text = "PantallaRegistrarSentPos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titulo;
    }
}