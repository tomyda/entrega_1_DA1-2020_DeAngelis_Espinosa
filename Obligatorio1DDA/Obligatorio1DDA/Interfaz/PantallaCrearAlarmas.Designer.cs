namespace Obligatorio1DDA
{
    partial class PantallaCrearAlarmas
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
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.BotonContinuar = new System.Windows.Forms.Button();
            this.TextBoxIngresarFrase = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.ComboBoxDiasUHoras = new System.Windows.Forms.ComboBox();
            this.ComboBoxCantidadTiempo = new System.Windows.Forms.ComboBox();
            this.ComboBoxCantPosts = new System.Windows.Forms.ComboBox();
            this.ComboBoxTipoAlarma = new System.Windows.Forms.ComboBox();
            this.ComboBoxEntidadRelacionada = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
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
            this.Titulo.TabIndex = 8;
            this.Titulo.Text = "AÑADIR NUEVA ALARMA";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(32, 117);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(86, 24);
            this.Label1.TabIndex = 17;
            this.Label1.Text = "Ingrese:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(92, 151);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(202, 24);
            this.Label2.TabIndex = 18;
            this.Label2.Text = "Entidad relacionada:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(92, 201);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(156, 24);
            this.Label3.TabIndex = 19;
            this.Label3.Text = "Tipo de alarma:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(92, 250);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(404, 24);
            this.Label4.TabIndex = 20;
            this.Label4.Text = "Cantidad de posts necesarios para activar:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(92, 303);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(166, 24);
            this.Label5.TabIndex = 21;
            this.Label5.Text = "Plazo de tiempo:";
            // 
            // BotonContinuar
            // 
            this.BotonContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(147)))));
            this.BotonContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonContinuar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BotonContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonContinuar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BotonContinuar.Location = new System.Drawing.Point(206, 501);
            this.BotonContinuar.Margin = new System.Windows.Forms.Padding(2);
            this.BotonContinuar.Name = "BotonContinuar";
            this.BotonContinuar.Size = new System.Drawing.Size(233, 32);
            this.BotonContinuar.TabIndex = 22;
            this.BotonContinuar.Text = "AÑADIR ALARMA";
            this.BotonContinuar.UseVisualStyleBackColor = false;
            this.BotonContinuar.Click += new System.EventHandler(this.BotonContinuar_Click);
            // 
            // TextBoxIngresarFrase
            // 
            this.TextBoxIngresarFrase.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxIngresarFrase.Location = new System.Drawing.Point(158, 357);
            this.TextBoxIngresarFrase.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxIngresarFrase.Multiline = true;
            this.TextBoxIngresarFrase.Name = "TextBoxIngresarFrase";
            this.TextBoxIngresarFrase.Size = new System.Drawing.Size(442, 104);
            this.TextBoxIngresarFrase.TabIndex = 23;
            this.TextBoxIngresarFrase.TextChanged += new System.EventHandler(this.textBoxIngresarFrase_TextChanged);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(92, 357);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(50, 24);
            this.Label6.TabIndex = 24;
            this.Label6.Text = "Info:";
            // 
            // ComboBoxDiasUHoras
            // 
            this.ComboBoxDiasUHoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDiasUHoras.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDiasUHoras.FormattingEnabled = true;
            this.ComboBoxDiasUHoras.Location = new System.Drawing.Point(263, 303);
            this.ComboBoxDiasUHoras.Name = "ComboBoxDiasUHoras";
            this.ComboBoxDiasUHoras.Size = new System.Drawing.Size(127, 31);
            this.ComboBoxDiasUHoras.TabIndex = 25;
            this.ComboBoxDiasUHoras.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDiasUHoras_SelectedIndexChanged);
            // 
            // ComboBoxCantidadTiempo
            // 
            this.ComboBoxCantidadTiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCantidadTiempo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCantidadTiempo.FormattingEnabled = true;
            this.ComboBoxCantidadTiempo.Location = new System.Drawing.Point(415, 302);
            this.ComboBoxCantidadTiempo.Name = "ComboBoxCantidadTiempo";
            this.ComboBoxCantidadTiempo.Size = new System.Drawing.Size(185, 31);
            this.ComboBoxCantidadTiempo.TabIndex = 26;
            // 
            // ComboBoxCantPosts
            // 
            this.ComboBoxCantPosts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCantPosts.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCantPosts.FormattingEnabled = true;
            this.ComboBoxCantPosts.Location = new System.Drawing.Point(512, 249);
            this.ComboBoxCantPosts.Name = "ComboBoxCantPosts";
            this.ComboBoxCantPosts.Size = new System.Drawing.Size(88, 31);
            this.ComboBoxCantPosts.TabIndex = 27;
            // 
            // ComboBoxTipoAlarma
            // 
            this.ComboBoxTipoAlarma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTipoAlarma.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxTipoAlarma.FormattingEnabled = true;
            this.ComboBoxTipoAlarma.Location = new System.Drawing.Point(253, 200);
            this.ComboBoxTipoAlarma.Name = "ComboBoxTipoAlarma";
            this.ComboBoxTipoAlarma.Size = new System.Drawing.Size(347, 31);
            this.ComboBoxTipoAlarma.TabIndex = 28;
            this.ComboBoxTipoAlarma.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTipoAlarma_SelectedIndexChanged);
            // 
            // ComboBoxEntidadRelacionada
            // 
            this.ComboBoxEntidadRelacionada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEntidadRelacionada.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxEntidadRelacionada.FormattingEnabled = true;
            this.ComboBoxEntidadRelacionada.Location = new System.Drawing.Point(306, 150);
            this.ComboBoxEntidadRelacionada.Name = "ComboBoxEntidadRelacionada";
            this.ComboBoxEntidadRelacionada.Size = new System.Drawing.Size(294, 31);
            this.ComboBoxEntidadRelacionada.TabIndex = 29;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label7.Location = new System.Drawing.Point(81, 150);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(18, 24);
            this.Label7.TabIndex = 30;
            this.Label7.Text = "*";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label8.Location = new System.Drawing.Point(81, 201);
            this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(18, 24);
            this.Label8.TabIndex = 31;
            this.Label8.Text = "*";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label9.Location = new System.Drawing.Point(81, 250);
            this.Label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(18, 24);
            this.Label9.TabIndex = 32;
            this.Label9.Text = "*";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label10.Location = new System.Drawing.Point(81, 302);
            this.Label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(18, 24);
            this.Label10.TabIndex = 33;
            this.Label10.Text = "*";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(147)))));
            this.Label11.Location = new System.Drawing.Point(183, 466);
            this.Label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(408, 20);
            this.Label11.TabIndex = 34;
            this.Label11.Text = "Recuerde llenar todos los campos marcados con: ";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label12.Location = new System.Drawing.Point(582, 466);
            this.Label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(18, 24);
            this.Label12.TabIndex = 35;
            this.Label12.Text = "*";
            // 
            // PantallaCrearAlarmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(630, 582);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.ComboBoxEntidadRelacionada);
            this.Controls.Add(this.ComboBoxTipoAlarma);
            this.Controls.Add(this.ComboBoxCantPosts);
            this.Controls.Add(this.ComboBoxCantidadTiempo);
            this.Controls.Add(this.ComboBoxDiasUHoras);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.TextBoxIngresarFrase);
            this.Controls.Add(this.BotonContinuar);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PantallaCrearAlarmas";
            this.Text = "PantallaCrearAlarmas";
            this.Load += new System.EventHandler(this.PantallaCrearAlarmas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Button BotonContinuar;
        private System.Windows.Forms.TextBox TextBoxIngresarFrase;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.ComboBox ComboBoxDiasUHoras;
        private System.Windows.Forms.ComboBox ComboBoxCantidadTiempo;
        private System.Windows.Forms.ComboBox ComboBoxCantPosts;
        private System.Windows.Forms.ComboBox ComboBoxTipoAlarma;
        private System.Windows.Forms.ComboBox ComboBoxEntidadRelacionada;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.Label Label12;
    }
}