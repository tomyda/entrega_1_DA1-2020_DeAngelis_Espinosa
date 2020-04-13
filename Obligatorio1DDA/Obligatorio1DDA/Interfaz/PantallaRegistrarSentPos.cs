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
    public partial class PantallaRegistrarSentPos : Form
    {
        public PantallaRegistrarSentPos()
        {
            InitializeComponent();
        }

        private void botonContinuar_Click(object sender, EventArgs e)
        {
            if(this.TextBoxPalabraIngresada.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Debe ingresar su frase u oración positiva para poder ingresarla al sistema");
                return;
            }

            var result = MessageBox.Show("¿Seguro que desea agregar: " + this.TextBoxPalabraIngresada.Text + " ,como sentimiento positivo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                
            }
        }
    }
}
