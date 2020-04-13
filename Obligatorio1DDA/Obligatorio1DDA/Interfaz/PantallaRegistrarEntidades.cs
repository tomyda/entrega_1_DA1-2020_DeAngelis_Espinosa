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

        private void PantallaRegistrarEntidades_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botonContinuar_Click(object sender, EventArgs e)
        {
            if (this.TextBoxEntidadIngresada.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Debe ingresar el nombre de la entidad para poder ingresarla al sistema");
                return;
            }

            var result = MessageBox.Show("¿Seguro que desea agregar: " + this.TextBoxEntidadIngresada.Text + " ,como entidad?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

            }
        }
    }
}
