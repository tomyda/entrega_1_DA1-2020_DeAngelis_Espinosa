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
            this.Titulo = new System.Windows.Forms.Label();
            this.BotonContinuar = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBoxEntidadIngresada = new System.Windows.Forms.TextBox();
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
            this.Titulo.TabIndex = 7;
            this.Titulo.Text = "AÑADIR NUEVA ENTIDAD";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // BotonContinuar
            // 
            this.BotonContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(147)))));
            this.BotonContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonContinuar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BotonContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonContinuar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BotonContinuar.Location = new System.Drawing.Point(197, 320);
            this.BotonContinuar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BotonContinuar.Name = "BotonContinuar";
            this.BotonContinuar.Size = new System.Drawing.Size(233, 32);
            this.BotonContinuar.TabIndex = 14;
            this.BotonContinuar.Text = "AÑADIR ENTIDAD";
            this.BotonContinuar.UseVisualStyleBackColor = false;
            this.BotonContinuar.Click += new System.EventHandler(this.botonContinuar_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(131, 239);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(377, 24);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Ingrese el nombre de la nueva entidad:";
            this.Label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextBoxEntidadIngresada
            // 
            this.TextBoxEntidadIngresada.Font = new System.Drawing.Font("MV Boli", 14F);
            this.TextBoxEntidadIngresada.Location = new System.Drawing.Point(135, 272);
            this.TextBoxEntidadIngresada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxEntidadIngresada.Name = "TextBoxEntidadIngresada";
            this.TextBoxEntidadIngresada.Size = new System.Drawing.Size(360, 38);
            this.TextBoxEntidadIngresada.TabIndex = 15;
            this.TextBoxEntidadIngresada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxEntidadIngresada.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PantallaRegistrarEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(630, 582);
            this.Controls.Add(this.TextBoxEntidadIngresada);
            this.Controls.Add(this.BotonContinuar);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PantallaRegistrarEntidades";
            this.Load += new System.EventHandler(this.PantallaRegistrarEntidades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button BotonContinuar;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox TextBoxEntidadIngresada;
    }
}