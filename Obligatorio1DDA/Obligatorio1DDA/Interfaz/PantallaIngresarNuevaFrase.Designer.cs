namespace Obligatorio1DDA
{
    partial class PantallaIngresarNuevaFrase
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIngresarFrase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botonContinuar = new System.Windows.Forms.Button();
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
            this.titulo.TabIndex = 7;
            this.titulo.Text = "INGRESAR NUEVA FRASE";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingrese la frase...";
            // 
            // textBoxIngresarFrase
            // 
            this.textBoxIngresarFrase.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIngresarFrase.Location = new System.Drawing.Point(131, 363);
            this.textBoxIngresarFrase.Multiline = true;
            this.textBoxIngresarFrase.Name = "textBoxIngresarFrase";
            this.textBoxIngresarFrase.Size = new System.Drawing.Size(685, 227);
            this.textBoxIngresarFrase.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(147)))));
            this.label2.Location = new System.Drawing.Point(333, 593);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(483, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Recuerda no exceder los 240 caracteres";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // botonContinuar
            // 
            this.botonContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(147)))));
            this.botonContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonContinuar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonContinuar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botonContinuar.Location = new System.Drawing.Point(303, 727);
            this.botonContinuar.Name = "botonContinuar";
            this.botonContinuar.Size = new System.Drawing.Size(349, 49);
            this.botonContinuar.TabIndex = 11;
            this.botonContinuar.Text = "INGRESAR";
            this.botonContinuar.UseVisualStyleBackColor = false;
            // 
            // PantallaIngresarNuevaFrase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(945, 895);
            this.Controls.Add(this.botonContinuar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIngresarFrase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaIngresarNuevaFrase";
            this.Text = "PantallaIngresarNuevaFrase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIngresarFrase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonContinuar;
    }
}