namespace Obligatorio1DDA
{
    partial class PanelPrincipal
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
            this.BarraDeTitulo = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.BotonCerrar = new System.Windows.Forms.PictureBox();
            this.BotonMinimizar = new System.Windows.Forms.PictureBox();
            this.BotonReporteEstadisticas = new System.Windows.Forms.Button();
            this.BotonReporteAlarmas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BotonIngresarFrase = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.BotonAnadir = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.BotonEntidad = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.BotonPalabraPositiva = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.BotonPalabraNegativa = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.BotonAlarma = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.PanelSubmenu = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.BarraDeTitulo.SuspendLayout();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMinimizar)).BeginInit();
            this.PanelSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraDeTitulo
            // 
            this.BarraDeTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.BarraDeTitulo.Controls.Add(this.labelTitulo);
            this.BarraDeTitulo.Controls.Add(this.BotonCerrar);
            this.BarraDeTitulo.Controls.Add(this.BotonMinimizar);
            this.BarraDeTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraDeTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraDeTitulo.Name = "BarraDeTitulo";
            this.BarraDeTitulo.Size = new System.Drawing.Size(1300, 55);
            this.BarraDeTitulo.TabIndex = 0;
            this.BarraDeTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraDeTitulo_Paint);
            this.BarraDeTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraDeTitulo_MouseDown);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(355, 55);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(945, 895);
            this.PanelContenedor.TabIndex = 2;
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackgroundImage = global::Obligatorio1DDA.Properties.Resources.wallpaper;
            this.MenuVertical.Controls.Add(this.PanelSubmenu);
            this.MenuVertical.Controls.Add(this.panel7);
            this.MenuVertical.Controls.Add(this.panel8);
            this.MenuVertical.Controls.Add(this.BotonAnadir);
            this.MenuVertical.Controls.Add(this.panel5);
            this.MenuVertical.Controls.Add(this.panel6);
            this.MenuVertical.Controls.Add(this.BotonIngresarFrase);
            this.MenuVertical.Controls.Add(this.panel4);
            this.MenuVertical.Controls.Add(this.panel3);
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Controls.Add(this.BotonReporteAlarmas);
            this.MenuVertical.Controls.Add(this.BotonReporteEstadisticas);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 55);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(355, 895);
            this.MenuVertical.TabIndex = 1;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonCerrar.Image = global::Obligatorio1DDA.Properties.Resources.cerrarImg;
            this.BotonCerrar.Location = new System.Drawing.Point(1250, 7);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(47, 40);
            this.BotonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonCerrar.TabIndex = 0;
            this.BotonCerrar.TabStop = false;
            this.BotonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // BotonMinimizar
            // 
            this.BotonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonMinimizar.Image = global::Obligatorio1DDA.Properties.Resources.minimizarImg;
            this.BotonMinimizar.Location = new System.Drawing.Point(1204, 6);
            this.BotonMinimizar.Name = "BotonMinimizar";
            this.BotonMinimizar.Size = new System.Drawing.Size(40, 41);
            this.BotonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonMinimizar.TabIndex = 1;
            this.BotonMinimizar.TabStop = false;
            this.BotonMinimizar.Click += new System.EventHandler(this.botonMinimizar_Click);
            // 
            // BotonReporteEstadisticas
            // 
            this.BotonReporteEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(147)))));
            this.BotonReporteEstadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonReporteEstadisticas.FlatAppearance.BorderSize = 0;
            this.BotonReporteEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonReporteEstadisticas.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonReporteEstadisticas.ForeColor = System.Drawing.SystemColors.Control;
            this.BotonReporteEstadisticas.Location = new System.Drawing.Point(12, 212);
            this.BotonReporteEstadisticas.Name = "BotonReporteEstadisticas";
            this.BotonReporteEstadisticas.Size = new System.Drawing.Size(332, 43);
            this.BotonReporteEstadisticas.TabIndex = 0;
            this.BotonReporteEstadisticas.Text = "REPORTE DE ESTADISTICAS";
            this.BotonReporteEstadisticas.UseVisualStyleBackColor = false;
            // 
            // BotonReporteAlarmas
            // 
            this.BotonReporteAlarmas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(147)))));
            this.BotonReporteAlarmas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonReporteAlarmas.FlatAppearance.BorderSize = 0;
            this.BotonReporteAlarmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonReporteAlarmas.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonReporteAlarmas.ForeColor = System.Drawing.SystemColors.Control;
            this.BotonReporteAlarmas.Location = new System.Drawing.Point(12, 366);
            this.BotonReporteAlarmas.Name = "BotonReporteAlarmas";
            this.BotonReporteAlarmas.Size = new System.Drawing.Size(332, 43);
            this.BotonReporteAlarmas.TabIndex = 1;
            this.BotonReporteAlarmas.Text = "REPORTE DE ALARMAS";
            this.BotonReporteAlarmas.UseVisualStyleBackColor = false;
            this.BotonReporteAlarmas.Click += new System.EventHandler(this.botonReporteAlarmas_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 43);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 366);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 43);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(334, 212);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 43);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(334, 366);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 43);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(334, 287);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 43);
            this.panel5.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(12, 287);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 43);
            this.panel6.TabIndex = 5;
            // 
            // BotonIngresarFrase
            // 
            this.BotonIngresarFrase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(147)))));
            this.BotonIngresarFrase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonIngresarFrase.FlatAppearance.BorderSize = 0;
            this.BotonIngresarFrase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonIngresarFrase.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonIngresarFrase.ForeColor = System.Drawing.SystemColors.Control;
            this.BotonIngresarFrase.Location = new System.Drawing.Point(12, 287);
            this.BotonIngresarFrase.Name = "BotonIngresarFrase";
            this.BotonIngresarFrase.Size = new System.Drawing.Size(332, 43);
            this.BotonIngresarFrase.TabIndex = 4;
            this.BotonIngresarFrase.Text = "INGRESAR NUEVA FRASE";
            this.BotonIngresarFrase.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(334, 439);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 43);
            this.panel7.TabIndex = 9;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(12, 439);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 43);
            this.panel8.TabIndex = 8;
            // 
            // BotonAnadir
            // 
            this.BotonAnadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(147)))));
            this.BotonAnadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonAnadir.FlatAppearance.BorderSize = 0;
            this.BotonAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAnadir.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAnadir.ForeColor = System.Drawing.SystemColors.Control;
            this.BotonAnadir.Location = new System.Drawing.Point(12, 439);
            this.BotonAnadir.Name = "BotonAnadir";
            this.BotonAnadir.Size = new System.Drawing.Size(332, 43);
            this.BotonAnadir.TabIndex = 7;
            this.BotonAnadir.Text = "AÑADIR";
            this.BotonAnadir.UseVisualStyleBackColor = false;
            this.BotonAnadir.Click += new System.EventHandler(this.BotonAnadir_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.ForeColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(11, 8);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 43);
            this.panel9.TabIndex = 11;
            // 
            // BotonEntidad
            // 
            this.BotonEntidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(147)))));
            this.BotonEntidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonEntidad.FlatAppearance.BorderSize = 0;
            this.BotonEntidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonEntidad.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEntidad.ForeColor = System.Drawing.SystemColors.Control;
            this.BotonEntidad.Location = new System.Drawing.Point(27, 8);
            this.BotonEntidad.Name = "BotonEntidad";
            this.BotonEntidad.Size = new System.Drawing.Size(231, 43);
            this.BotonEntidad.TabIndex = 10;
            this.BotonEntidad.Text = "ENTIDAD";
            this.BotonEntidad.UseVisualStyleBackColor = false;
            this.BotonEntidad.Click += new System.EventHandler(this.BotonEntidad_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.ForeColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(11, 57);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(10, 43);
            this.panel10.TabIndex = 13;
            // 
            // BotonPalabraPositiva
            // 
            this.BotonPalabraPositiva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(147)))));
            this.BotonPalabraPositiva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonPalabraPositiva.FlatAppearance.BorderSize = 0;
            this.BotonPalabraPositiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonPalabraPositiva.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonPalabraPositiva.ForeColor = System.Drawing.SystemColors.Control;
            this.BotonPalabraPositiva.Location = new System.Drawing.Point(27, 57);
            this.BotonPalabraPositiva.Name = "BotonPalabraPositiva";
            this.BotonPalabraPositiva.Size = new System.Drawing.Size(231, 43);
            this.BotonPalabraPositiva.TabIndex = 12;
            this.BotonPalabraPositiva.Text = "PALABRA POSITIVA";
            this.BotonPalabraPositiva.UseVisualStyleBackColor = false;
            this.BotonPalabraPositiva.Click += new System.EventHandler(this.botonPalabraPositiva_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.ForeColor = System.Drawing.Color.White;
            this.panel11.Location = new System.Drawing.Point(11, 106);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(10, 43);
            this.panel11.TabIndex = 15;
            // 
            // BotonPalabraNegativa
            // 
            this.BotonPalabraNegativa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(147)))));
            this.BotonPalabraNegativa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonPalabraNegativa.FlatAppearance.BorderSize = 0;
            this.BotonPalabraNegativa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonPalabraNegativa.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonPalabraNegativa.ForeColor = System.Drawing.SystemColors.Control;
            this.BotonPalabraNegativa.Location = new System.Drawing.Point(27, 106);
            this.BotonPalabraNegativa.Name = "BotonPalabraNegativa";
            this.BotonPalabraNegativa.Size = new System.Drawing.Size(231, 43);
            this.BotonPalabraNegativa.TabIndex = 14;
            this.BotonPalabraNegativa.Text = "PALABRA NEGATIVA";
            this.BotonPalabraNegativa.UseVisualStyleBackColor = false;
            this.BotonPalabraNegativa.Click += new System.EventHandler(this.BotonPalabraNegativa_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.Location = new System.Drawing.Point(11, 155);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(10, 43);
            this.panel12.TabIndex = 17;
            // 
            // BotonAlarma
            // 
            this.BotonAlarma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(147)))));
            this.BotonAlarma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonAlarma.FlatAppearance.BorderSize = 0;
            this.BotonAlarma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAlarma.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAlarma.ForeColor = System.Drawing.SystemColors.Control;
            this.BotonAlarma.Location = new System.Drawing.Point(27, 155);
            this.BotonAlarma.Name = "BotonAlarma";
            this.BotonAlarma.Size = new System.Drawing.Size(231, 43);
            this.BotonAlarma.TabIndex = 16;
            this.BotonAlarma.Text = "ALARMA";
            this.BotonAlarma.UseVisualStyleBackColor = false;
            this.BotonAlarma.Click += new System.EventHandler(this.BotonAlarma_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.Location = new System.Drawing.Point(264, 155);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(10, 43);
            this.panel13.TabIndex = 21;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel15.ForeColor = System.Drawing.Color.White;
            this.panel15.Location = new System.Drawing.Point(264, 57);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(10, 43);
            this.panel15.TabIndex = 19;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel16.ForeColor = System.Drawing.Color.White;
            this.panel16.Location = new System.Drawing.Point(264, 8);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(10, 43);
            this.panel16.TabIndex = 18;
            // 
            // PanelSubmenu
            // 
            this.PanelSubmenu.BackColor = System.Drawing.Color.Transparent;
            this.PanelSubmenu.Controls.Add(this.panel14);
            this.PanelSubmenu.Controls.Add(this.BotonPalabraPositiva);
            this.PanelSubmenu.Controls.Add(this.panel13);
            this.PanelSubmenu.Controls.Add(this.BotonEntidad);
            this.PanelSubmenu.Controls.Add(this.panel9);
            this.PanelSubmenu.Controls.Add(this.panel15);
            this.PanelSubmenu.Controls.Add(this.panel10);
            this.PanelSubmenu.Controls.Add(this.panel16);
            this.PanelSubmenu.Controls.Add(this.BotonPalabraNegativa);
            this.PanelSubmenu.Controls.Add(this.panel12);
            this.PanelSubmenu.Controls.Add(this.panel11);
            this.PanelSubmenu.Controls.Add(this.BotonAlarma);
            this.PanelSubmenu.Location = new System.Drawing.Point(36, 488);
            this.PanelSubmenu.Name = "PanelSubmenu";
            this.PanelSubmenu.Size = new System.Drawing.Size(281, 222);
            this.PanelSubmenu.TabIndex = 22;
            this.PanelSubmenu.Visible = false;
            this.PanelSubmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSubmenu_Paint);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.Location = new System.Drawing.Point(264, 106);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(10, 43);
            this.panel14.TabIndex = 22;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(506, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(310, 32);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "ANALIZADOR DE FRASES";
            this.labelTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // PanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 950);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraDeTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelPrincipal";
            this.Text = "Form1";
            this.BarraDeTitulo.ResumeLayout(false);
            this.BarraDeTitulo.PerformLayout();
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMinimizar)).EndInit();
            this.PanelSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraDeTitulo;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox BotonMinimizar;
        private System.Windows.Forms.PictureBox BotonCerrar;
        private System.Windows.Forms.Button BotonReporteEstadisticas;
        private System.Windows.Forms.Button BotonReporteAlarmas;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BotonIngresarFrase;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelSubmenu;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button BotonPalabraPositiva;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button BotonEntidad;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button BotonPalabraNegativa;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button BotonAlarma;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button BotonAnadir;
        private System.Windows.Forms.Label labelTitulo;
    }
}