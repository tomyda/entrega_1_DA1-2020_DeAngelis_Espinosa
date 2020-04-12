namespace Obligatorio1DDA
{
    partial class PantallaRegistrarEntidades
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
            this.botonContinuar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.titulo.Text = "AÑADIR NUEVA ENTIDAD";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // botonContinuar
            // 
            this.botonContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(147)))));
            this.botonContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonContinuar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonContinuar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botonContinuar.Location = new System.Drawing.Point(290, 499);
            this.botonContinuar.Name = "botonContinuar";
            this.botonContinuar.Size = new System.Drawing.Size(349, 49);
            this.botonContinuar.TabIndex = 14;
            this.botonContinuar.Text = "AÑADIR ENTIDAD";
            this.botonContinuar.UseVisualStyleBackColor = false;
            this.botonContinuar.Click += new System.EventHandler(this.botonContinuar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ingrese el nombre de la nueva entidad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MV Boli", 14F);
            this.textBox1.Location = new System.Drawing.Point(197, 424);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(538, 53);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PantallaRegistrarEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(945, 895);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.botonContinuar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaRegistrarEntidades";
            this.Load += new System.EventHandler(this.PantallaRegistrarEntidades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button botonContinuar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}