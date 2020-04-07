using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obligatorio1DDA
{
    public partial class PantallaCrearAlarmas : Form
    {
        public PantallaCrearAlarmas()
        {
            InitializeComponent();
        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantallaDeInicio pantallaInicio = new PantallaDeInicio();
            pantallaInicio.ShowDialog();
            this.Close();
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantallaDeInicio pantallaInicio = new PantallaDeInicio();
            pantallaInicio.ShowDialog();
            this.Close();
        }

        private void PantallaCrearAlarmas_Load(object sender, EventArgs e)
        {

        }
    }
}
