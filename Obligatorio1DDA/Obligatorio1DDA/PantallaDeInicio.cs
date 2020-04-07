using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Obligatorio1DDA
{
    public partial class PantallaDeInicio : Form
    {
        public PantallaDeInicio()
        {
            InitializeComponent();
        }


        private void debugInstructionsLabel_Click(object sender, EventArgs e)
        {

        }

        private void ingresarNuevaFraseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantallaIngresarNuevaFrase pantallaIngresarFrase = new PantallaIngresarNuevaFrase();
            pantallaIngresarFrase.ShowDialog();
            this.Close();
        }

        private void registrarSentNegBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantallaRegistrarSentNeg pantallaRegSentneg = new PantallaRegistrarSentNeg();
            pantallaRegSentneg.ShowDialog();
            this.Close();
        }

        private void crearAlarmaBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantallaCrearAlarmas pantallaCrearAlarmas = new PantallaCrearAlarmas();
            pantallaCrearAlarmas.ShowDialog();
            this.Close();
        }

        private void registrarEntidadesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantallaRegistrarEntidades pantallaRegEnt = new PantallaRegistrarEntidades();
            pantallaRegEnt.ShowDialog();
            this.Close();
        }

        private void reporteDeAlarmasBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantallaReporteDeAlarmas pantallaReporteAlarmas = new PantallaReporteDeAlarmas();
            pantallaReporteAlarmas.ShowDialog();
            this.Close();
        }

        private void reporteDeEstadisticasBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantallaReporteEstadisticas pantallaReporteEstadisticas = new PantallaReporteEstadisticas();
            pantallaReporteEstadisticas.ShowDialog();
            this.Close();
        }

        private void registrarSentPosBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantallaRegistrarSentPos pantallaRegSentPos = new PantallaRegistrarSentPos();
            pantallaRegSentPos.ShowDialog();
            this.Close();
        }

        private void PantallaDeInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
