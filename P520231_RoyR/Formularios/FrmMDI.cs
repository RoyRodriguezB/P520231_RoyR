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

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void LblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void FrmMDI_Load(object sender, EventArgs e)
        {
            //mostrar el usuario logueado

            string InfoUsuario = string.Format("{0}-{1} ({2})",
                                                Globales.MiUsuarioGlobal.UsuarioNombre,
                                                Globales.MiUsuarioGlobal.UsuarioCorreo,
                                                Globales.MiUsuarioGlobal.MiRolTipo.UsuarioRolDescripcion);

            LblUsuario.Text = InfoUsuario;

            switch (Globales.MiUsuarioGlobal.MiRolTipo.UsuarioRolID)
            {
               case 1:
                    break;
               case 2:
                    //usuario normal
                    gestionDeUsuariosToolStripMenuItem.Visible = false;
                    rolesDeUsuarioToolStripMenuItem.Visible = false;
                    tiposDeProveedorToolStripMenuItem.Visible = false;
                    tiposDeCompraToolStripMenuItem.Visible = false;
                    break;

            }



        }

        private void rEGISTRODECOMPRASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiFormRegistroCompra.Visible)
            {
                Globales.MiFormRegistroCompra = new FrmRegistroCompra();
                Globales.MiFormRegistroCompra.Show();
            }
        }
    }
}
