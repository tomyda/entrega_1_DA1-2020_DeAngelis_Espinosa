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
        private int indiceActualTipoAlarma = 0;
        private int indiceActualDiaUHora = 0;


        public PantallaCrearAlarmas()
        {
            InitializeComponent();
            LLenarLosComboBox();
        }

        private void LLenarLosComboBox()
        {
            this.ComboBoxCantidadTiempo.Enabled = false;
            this.ComboBoxCantPosts.Enabled = false;


            this.ComboBoxEntidadRelacionada.Items.Add("...");
            this.ComboBoxTipoAlarma.Items.Add("...");
            this.ComboBoxCantPosts.Items.Add("...");
            this.ComboBoxDiasUHoras.Items.Add("...");
            this.ComboBoxCantidadTiempo.Items.Add("...");

            this.ComboBoxEntidadRelacionada.SelectedIndex = 0;
            this.ComboBoxTipoAlarma.SelectedIndex = 0;
            this.ComboBoxCantPosts.SelectedIndex = 0;
            this.ComboBoxDiasUHoras.SelectedIndex = 0;
            this.ComboBoxCantidadTiempo.SelectedIndex = 0;

            this.ComboBoxTipoAlarma.Items.Add("Positiva");
            this.ComboBoxTipoAlarma.Items.Add("Negativa");

            this.ComboBoxDiasUHoras.Items.Add("Días");
            this.ComboBoxDiasUHoras.Items.Add("Horas");


        }

        private void PantallaCrearAlarmas_Load(object sender, EventArgs e)
        {

        }

        private void textBoxIngresarFrase_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonContinuar_Click(object sender, EventArgs e)
        {
            if(NoSeSeleccionoAlgunComboBox())
            {
                System.Windows.Forms.MessageBox.Show("Debe llenar todos los campos marcados con *");
                return;
            }

        }

        private bool NoSeSeleccionoAlgunComboBox()
        {
            return (this.ComboBoxEntidadRelacionada.SelectedIndex == 0 ||
                    this.ComboBoxTipoAlarma.SelectedIndex == 0 ||
                    this.ComboBoxCantPosts.SelectedIndex == 0 ||
                    this.ComboBoxDiasUHoras.SelectedIndex == 0 ||
                    this.ComboBoxCantidadTiempo.SelectedIndex == 0);
        }

        private void ComboBoxDiasUHoras_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSeleccionado = this.ComboBoxDiasUHoras.SelectedIndex;
            if (indiceSeleccionado == indiceActualDiaUHora) return;
            indiceActualDiaUHora = indiceSeleccionado;

            int cantidad = 0;
            switch (indiceSeleccionado)
            {
                case 0:
                    this.ComboBoxCantidadTiempo.Items.Clear();
                    this.ComboBoxCantidadTiempo.Items.Add("...");
                    this.ComboBoxCantidadTiempo.Enabled = false;
                    return;
                case 1:
                    this.ComboBoxCantidadTiempo.Items.Clear();
                    this.ComboBoxCantidadTiempo.Items.Add("1 Día");
                    cantidad = 5;
                    break;
                case 2:
                    this.ComboBoxCantidadTiempo.Items.Clear();
                    this.ComboBoxCantidadTiempo.Items.Add("1 Hora");
                    cantidad = 48;
                    break;
            }
            for (int i = 2; i <= cantidad; i++)
            {
                this.ComboBoxCantidadTiempo.Items.Add(i + " " + this.ComboBoxDiasUHoras.SelectedItem);
            }
            this.ComboBoxCantidadTiempo.SelectedIndex = 0;
            this.ComboBoxCantidadTiempo.Enabled = true;
        }

        private void ComboBoxTipoAlarma_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSeleccionado = this.ComboBoxTipoAlarma.SelectedIndex;
            if (indiceSeleccionado == indiceActualTipoAlarma) return;
            indiceActualTipoAlarma = indiceSeleccionado;

            if (indiceSeleccionado == 0) {
                this.ComboBoxCantPosts.Items.Clear();
                this.ComboBoxCantPosts.Items.Add("...");
                this.ComboBoxCantPosts.Enabled = false;
                return;
            }
            this.ComboBoxCantPosts.Items.Clear();
            for (int i = 1; i <= 50; i++)
            {
                this.ComboBoxCantPosts.Items.Add(i);
            }
            this.ComboBoxCantPosts.SelectedIndex = 0;
            this.ComboBoxCantPosts.Enabled = true;
        }
    }
}
