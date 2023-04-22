using Logica.Models;
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
    public partial class FrmProveedorBuscar : Form
    {
        DataTable DtLista { get; set; }

        Proveedor MiProveedorLocal { get; set; }


        public FrmProveedorBuscar()
        {
            InitializeComponent();

            DtLista = new DataTable();
            MiProveedorLocal = new Proveedor();

        }

        private void FrmProveedorBuscar_Load(object sender, EventArgs e)
        {



        }

        private void LlenarLista()
        {
            DtLista = new DataTable();

            DtLista = MiProveedorLocal.Listar(true, TxtBuscar.Text.Trim());

            DgvLista.DataSource = DtLista;


        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (DgvLista.SelectedRows.Count == 1)
            {
                DataGridViewRow row = DgvLista.SelectedRows[0];

                int IdProveedor = Convert.ToInt32(row.Cells["CProveedorID"].Value);

               string NombreProveedor = Convert.ToString(row.Cells["CProveedorNombre"].Value);

                Globales.MiFormRegistroCompra.MiCompraLocal.MiProveedor.ProveedorNombre = NombreProveedor;
                Globales.MiFormRegistroCompra.MiCompraLocal.MiProveedor.ProveedorID = IdProveedor;

                DialogResult = DialogResult.OK;
            }

            
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscar.Text.Count() > 2 || string.IsNullOrEmpty(TxtBuscar.Text.Trim()))
            {
                LlenarLista();

            }


        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
