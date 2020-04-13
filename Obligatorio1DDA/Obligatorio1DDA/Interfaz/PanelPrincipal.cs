using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Obligatorio1DDA
{
    public partial class PanelPrincipal : Form
    {
        public PanelPrincipal()
        { 
            InitializeComponent();
            AbrirFormHijo(new PantallaPorDefecto());
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            PanelSubmenu.Visible = false;
            var result = MessageBox.Show("¿Seguro que desea cerrar el programa?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void botonReporteAlarmas_Click(object sender, EventArgs e)
        {
            PanelSubmenu.Visible = false;
            AbrirFormHijo(new PantallaReporteDeAlarmas()); 
        }

        private void botonPalabraPositiva_Click(object sender, EventArgs e)
        {
            PanelSubmenu.Visible = false;
            AbrirFormHijo(new PantallaRegistrarSentPos());
        }

        private void BotonAnadir_Click(object sender, EventArgs e)
        {
            PanelSubmenu.Visible = !PanelSubmenu.Visible;
        }

        private void BotonEntidad_Click(object sender, EventArgs e)
        {
            PanelSubmenu.Visible = false;
            AbrirFormHijo(new PantallaRegistrarEntidades());
        }

        private void BotonPalabraNegativa_Click(object sender, EventArgs e)
        {
            PanelSubmenu.Visible = false;
            AbrirFormHijo(new PantallaRegistrarSentNeg());
        }

        private void BotonAlarma_Click(object sender, EventArgs e)
        {
            PanelSubmenu.Visible = false;
            AbrirFormHijo(new PantallaCrearAlarmas());
        }

        private void BotonIngresarFrase_Click(object sender, EventArgs e)
        {
            PanelSubmenu.Visible = false;
            AbrirFormHijo(new PantallaIngresarNuevaFrase());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraDeTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BotonReporteEstadisticas_Click(object sender, EventArgs e)
        {
            PanelSubmenu.Visible = false;
            AbrirFormHijo(new PantallaReporteEstadisticas());
        }

        private void AbrirFormHijo(object formHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FotoLogo_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new PantallaPorDefecto());
        }
    }
}
