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
    public partial class PantallaRegistrarSentNeg : Form
    {
        public PantallaRegistrarSentNeg()
        {
            InitializeComponent();
        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }

        private void titulo_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxPalabraIngresada_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonContinuar_Click(object sender, EventArgs e)
        {
            if (this.TextBoxPalabraIngresada.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Debe ingresar su frase u oración negativa para poder ingresarla al sistema");
                return;
            }

            var result = MessageBox.Show("¿Seguro que desea agregar: " + this.TextBoxPalabraIngresada.Text + " ,como sentimiento negativo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

            }
        }
    }
}
