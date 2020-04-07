namespace Obligatorio1DDA
{
    partial class PantallaDeInicio
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
            this.subtitulo = new System.Windows.Forms.Label();
            this.registrarSentPosBtn = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.crearAlarmaBtn = new System.Windows.Forms.Button();
            this.registrarSentNegBtn = new System.Windows.Forms.Button();
            this.registrarEntidadesBtn = new System.Windows.Forms.Button();
            this.ingresarNuevaFraseBtn = new System.Windows.Forms.Button();
            this.reporteDeAlarmasBtn = new System.Windows.Forms.Button();
            this.reporteDeEstadisticasBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subtitulo
            // 
            this.subtitulo.AutoSize = true;
            this.subtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitulo.Location = new System.Drawing.Point(257, 179);
            this.subtitulo.Name = "subtitulo";
            this.subtitulo.Size = new System.Drawing.Size(771, 40);
            this.subtitulo.TabIndex = 1;
            this.subtitulo.Text = "Menu Principal: Seleccione actividad a realizar.";
            this.subtitulo.Click += new System.EventHandler(this.debugInstructionsLabel_Click);
            // 
            // registrarSentPosBtn
            // 
            this.registrarSentPosBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarSentPosBtn.Location = new System.Drawing.Point(27, 251);
            this.registrarSentPosBtn.Name = "registrarSentPosBtn";
            this.registrarSentPosBtn.Size = new System.Drawing.Size(603, 125);
            this.registrarSentPosBtn.TabIndex = 2;
            this.registrarSentPosBtn.Text = "Registrar sentimientos positivos";
            this.registrarSentPosBtn.UseVisualStyleBackColor = true;
            this.registrarSentPosBtn.Click += new System.EventHandler(this.registrarSentPosBtn_Click);
            // 
            // titulo
            // 
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(168, 48);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(1015, 108);
            this.titulo.TabIndex = 3;
            this.titulo.Text = "Analizador de frases";
            // 
            // crearAlarmaBtn
            // 
            this.crearAlarmaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearAlarmaBtn.Location = new System.Drawing.Point(667, 407);
            this.crearAlarmaBtn.Name = "crearAlarmaBtn";
            this.crearAlarmaBtn.Size = new System.Drawing.Size(585, 125);
            this.crearAlarmaBtn.TabIndex = 4;
            this.crearAlarmaBtn.Text = "Crear configuracion de alarma";
            this.crearAlarmaBtn.UseVisualStyleBackColor = true;
            this.crearAlarmaBtn.Click += new System.EventHandler(this.crearAlarmaBtn_Click);
            // 
            // registrarSentNegBtn
            // 
            this.registrarSentNegBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarSentNegBtn.Location = new System.Drawing.Point(27, 407);
            this.registrarSentNegBtn.Name = "registrarSentNegBtn";
            this.registrarSentNegBtn.Size = new System.Drawing.Size(603, 125);
            this.registrarSentNegBtn.TabIndex = 5;
            this.registrarSentNegBtn.Text = "Registrar sentimientos negativos";
            this.registrarSentNegBtn.UseVisualStyleBackColor = true;
            this.registrarSentNegBtn.Click += new System.EventHandler(this.registrarSentNegBtn_Click);
            // 
            // registrarEntidadesBtn
            // 
            this.registrarEntidadesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarEntidadesBtn.Location = new System.Drawing.Point(27, 563);
            this.registrarEntidadesBtn.Name = "registrarEntidadesBtn";
            this.registrarEntidadesBtn.Size = new System.Drawing.Size(603, 125);
            this.registrarEntidadesBtn.TabIndex = 6;
            this.registrarEntidadesBtn.Text = "Registrar entidades";
            this.registrarEntidadesBtn.UseVisualStyleBackColor = true;
            this.registrarEntidadesBtn.Click += new System.EventHandler(this.registrarEntidadesBtn_Click);
            // 
            // ingresarNuevaFraseBtn
            // 
            this.ingresarNuevaFraseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresarNuevaFraseBtn.Location = new System.Drawing.Point(667, 251);
            this.ingresarNuevaFraseBtn.Name = "ingresarNuevaFraseBtn";
            this.ingresarNuevaFraseBtn.Size = new System.Drawing.Size(585, 125);
            this.ingresarNuevaFraseBtn.TabIndex = 7;
            this.ingresarNuevaFraseBtn.Text = "Ingresar Nueva Frase";
            this.ingresarNuevaFraseBtn.UseVisualStyleBackColor = true;
            this.ingresarNuevaFraseBtn.Click += new System.EventHandler(this.ingresarNuevaFraseBtn_Click);
            // 
            // reporteDeAlarmasBtn
            // 
            this.reporteDeAlarmasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reporteDeAlarmasBtn.Location = new System.Drawing.Point(667, 563);
            this.reporteDeAlarmasBtn.Name = "reporteDeAlarmasBtn";
            this.reporteDeAlarmasBtn.Size = new System.Drawing.Size(585, 125);
            this.reporteDeAlarmasBtn.TabIndex = 8;
            this.reporteDeAlarmasBtn.Text = "Reporte de alarmas";
            this.reporteDeAlarmasBtn.UseVisualStyleBackColor = true;
            this.reporteDeAlarmasBtn.Click += new System.EventHandler(this.reporteDeAlarmasBtn_Click);
            // 
            // reporteDeEstadisticasBtn
            // 
            this.reporteDeEstadisticasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reporteDeEstadisticasBtn.Location = new System.Drawing.Point(27, 724);
            this.reporteDeEstadisticasBtn.Name = "reporteDeEstadisticasBtn";
            this.reporteDeEstadisticasBtn.Size = new System.Drawing.Size(1225, 125);
            this.reporteDeEstadisticasBtn.TabIndex = 9;
            this.reporteDeEstadisticasBtn.Text = "Reporte de estadisticas";
            this.reporteDeEstadisticasBtn.UseVisualStyleBackColor = true;
            this.reporteDeEstadisticasBtn.Click += new System.EventHandler(this.reporteDeEstadisticasBtn_Click);
            // 
            // PantallaDeInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 885);
            this.Controls.Add(this.reporteDeEstadisticasBtn);
            this.Controls.Add(this.reporteDeAlarmasBtn);
            this.Controls.Add(this.ingresarNuevaFraseBtn);
            this.Controls.Add(this.registrarEntidadesBtn);
            this.Controls.Add(this.registrarSentNegBtn);
            this.Controls.Add(this.crearAlarmaBtn);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.registrarSentPosBtn);
            this.Controls.Add(this.subtitulo);
            this.Name = "PantallaDeInicio";
            this.Text = "Analizador de frases";
            this.Load += new System.EventHandler(this.PantallaDeInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label subtitulo;
        private System.Windows.Forms.Button registrarSentPosBtn;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button crearAlarmaBtn;
        private System.Windows.Forms.Button registrarSentNegBtn;
        private System.Windows.Forms.Button registrarEntidadesBtn;
        private System.Windows.Forms.Button ingresarNuevaFraseBtn;
        private System.Windows.Forms.Button reporteDeAlarmasBtn;
        private System.Windows.Forms.Button reporteDeEstadisticasBtn;
    }
}

