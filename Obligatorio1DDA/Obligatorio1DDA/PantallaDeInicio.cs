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

        private void registrarSentPosBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se deberia abrir el panel de Registrar sentimietnos positivos!");
        }

        private void debugInstructionsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
