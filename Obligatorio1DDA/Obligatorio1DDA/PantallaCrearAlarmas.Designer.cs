﻿namespace Obligatorio1DDA
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaCrearAlarmas));
            this.titulo = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.volverBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(173, 42);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(935, 108);
            this.titulo.TabIndex = 4;
            this.titulo.Text = "Crear Alarmas";
            this.titulo.Click += new System.EventHandler(this.titulo_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // volverBtn
            // 
            this.volverBtn.BackColor = System.Drawing.Color.Transparent;
            this.volverBtn.ForeColor = System.Drawing.Color.Transparent;
            this.volverBtn.Image = ((System.Drawing.Image)(resources.GetObject("volverBtn.Image")));
            this.volverBtn.Location = new System.Drawing.Point(47, 42);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(104, 101);
            this.volverBtn.TabIndex = 5;
            this.volverBtn.UseVisualStyleBackColor = false;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // PantallaCrearAlarmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1282, 885);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.titulo);
            this.Name = "PantallaCrearAlarmas";
            this.Text = "PantallaCrearAlarmas";
            this.Load += new System.EventHandler(this.PantallaCrearAlarmas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button volverBtn;
    }
}