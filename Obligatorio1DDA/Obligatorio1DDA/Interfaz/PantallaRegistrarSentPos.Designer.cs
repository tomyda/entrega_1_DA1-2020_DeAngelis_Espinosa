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
            this.Titulo = new System.Windows.Forms.Label();
            this.TextBoxPalabraIngresada = new System.Windows.Forms.TextBox();
            this.BotonContinuar = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titulo.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(0, 0);
            this.Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(630, 90);
            this.Titulo.TabIndex = 6;
            this.Titulo.Text = "AÑADIR SENTIMIENTOS POSITIVOS";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TextBoxPalabraIngresada
            // 
            this.TextBoxPalabraIngresada.Font = new System.Drawing.Font("MV Boli", 14F);
            this.TextBoxPalabraIngresada.Location = new System.Drawing.Point(135, 271);
            this.TextBoxPalabraIngresada.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxPalabraIngresada.Name = "TextBoxPalabraIngresada";
            this.TextBoxPalabraIngresada.Size = new System.Drawing.Size(360, 38);
            this.TextBoxPalabraIngresada.TabIndex = 21;
            this.TextBoxPalabraIngresada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BotonContinuar
            // 
            this.BotonContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(147)))));
            this.BotonContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonContinuar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BotonContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonContinuar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BotonContinuar.Location = new System.Drawing.Point(199, 320);
            this.BotonContinuar.Margin = new System.Windows.Forms.Padding(2);
            this.BotonContinuar.Name = "BotonContinuar";
            this.BotonContinuar.Size = new System.Drawing.Size(233, 32);
            this.BotonContinuar.TabIndex = 20;
            this.BotonContinuar.Text = "AÑADIR FRASE O PALABRA";
            this.BotonContinuar.UseVisualStyleBackColor = false;
            this.BotonContinuar.Click += new System.EventHandler(this.botonContinuar_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(152, 237);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(328, 24);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "Ingrese la frase o palabra positiva:";
            // 
            // PantallaRegistrarSentPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(630, 582);
            this.Controls.Add(this.TextBoxPalabraIngresada);
            this.Controls.Add(this.BotonContinuar);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PantallaRegistrarSentPos";
            this.Text = "PantallaRegistrarSentPos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox TextBoxPalabraIngresada;
        private System.Windows.Forms.Button BotonContinuar;
        private System.Windows.Forms.Label Label1;
    }
}