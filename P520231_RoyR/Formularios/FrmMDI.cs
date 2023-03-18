using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P520231_RoyR.Formularios
{
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void FrmMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MnuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MnuGestiones_Click(object sender, EventArgs e)
        {

        }

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Globales.MiFormGestionUsuarios.Visible)
            {
                Globales.MiFormGestionUsuarios = new FrmUsuariosGestion();
                Globales.MiFormGestionUsuarios.Show();
            }

        }
    }
}
