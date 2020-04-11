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
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {

        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonReporteAlarmas_Click(object sender, EventArgs e)
        {

        }

        private void botonPalabraPositiva_Click(object sender, EventArgs e)
        {
            PanelSubmenu.Visible = false;
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSubmenu_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void BotonAnadir_Click(object sender, EventArgs e)
        {
            PanelSubmenu.Visible = !PanelSubmenu.Visible;
        }

        private void BotonEntidad_Click(object sender, EventArgs e)
        {
            PanelSubmenu.Visible = false;
        }

        private void BotonPalabraNegativa_Click(object sender, EventArgs e)
        {
            PanelSubmenu.Visible = false;
        }

        private void BotonAlarma_Click(object sender, EventArgs e)
        {
            PanelSubmenu.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BarraDeTitulo_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
