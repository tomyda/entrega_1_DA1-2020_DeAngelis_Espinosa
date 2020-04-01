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
            MessageBox.Show("Se deberia abrir el panel de Ingresar nueva frase!");
        }

        private void registrarSentNegBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se deberia abrir el panel de Registrar Sentimientos regativos!");
        }

        private void crearAlarmaBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se deberia abrir el panel de crear alarma!");
        }

        private void registrarEntidadesBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se deberia abrir el panel de registrar entidades!");
        }

        private void reporteDeAlarmasBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se deberia abrir el panel de reporte de alarmas!");
        }

        private void reporteDeEstadisticasBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se deberia abrir el panel de reportes estadisticos!");
        }

        private void registrarSentPosBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se deberia abrir el panel de Registrar sentimietnos positivos!");
        }
    }
}
