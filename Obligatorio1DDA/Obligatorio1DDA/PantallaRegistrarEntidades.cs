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
    public partial class PantallaRegistrarEntidades : Form
    {
        public PantallaRegistrarEntidades()
        {
            InitializeComponent();
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantallaDeInicio pantallaInicio = new PantallaDeInicio();
            pantallaInicio.ShowDialog();
            this.Close();
        }
    }
}
