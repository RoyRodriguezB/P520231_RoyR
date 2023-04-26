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
    public partial class FrmProveedorGestion : Form
    {

        private Logica.Models.Proveedor MiProveedorLocal { get; set; }

        private DataTable ListaProveedor { get; set; }


        public FrmProveedorGestion()
        {
            InitializeComponent();

            MiProveedorLocal = new Logica.Models.Proveedor();
            ListaProveedor = new DataTable();
        }

        private void FrmProveedorGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;

            CargarListaTipoProveedor();

            CargarListaDeProveedor();
        }

       private void CargarListaDeProveedor()
        {
            ListaProveedor = new DataTable();

            //si en el cuadro de texto de busqueda hay 3 o mas caracteres se filtra la lista
            string FiltroBusqueda = "";
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()) && TxtBuscar.Text.Count() >= 3)
            {
                FiltroBusqueda = TxtBuscar.Text.Trim();
            }

            if (CboxVerActivos.Checked)
            {

                ListaProveedor = MiProveedorLocal.Listar( true,FiltroBusqueda);

            }
            else
            {
                ListaProveedor = MiProveedorLocal.Listar(false,FiltroBusqueda);
            }

            DgLista.DataSource = ListaProveedor;
        }

        private void CargarListaTipoProveedor()
        {
            Logica.Models.TipoProveedor MiTipo = new Logica.Models.TipoProveedor();

            DataTable dt = new DataTable();
            dt = MiTipo.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                CbTiposProveedor.ValueMember = "ID";
                CbTiposProveedor.DisplayMember = "Descrip";
                CbTiposProveedor.DataSource = dt;
                CbTiposProveedor.SelectedIndex = -1;
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DgLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgLista.ClearSelection();
        }

        private void DgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgLista.SelectedRows.Count == 1)
            {
                DataGridViewRow MiFila = DgLista.SelectedRows[0];

                int ProveedorID = Convert.ToInt32(MiFila.Cells["CProveedorID"].Value);

                MiProveedorLocal = new Logica.Models.Proveedor();

                MiProveedorLocal.ProveedorID = ProveedorID;
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            TxtProveedorID.Clear();
            TxtProveedorNombre.Clear();
            TxtProveedorCedula.Clear();
            TxtProveedorEmail.Clear();
            TxtProveedorNotas.Clear();

            CbTiposProveedor.SelectedIndex = -1;

            TxtProveedorDireccion.Clear();
        }



        private bool ValidarDatosDigitados()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtProveedorNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProveedorCedula.Text.Trim()) &&
                
                !string.IsNullOrEmpty(TxtProveedorEmail.Text.Trim()) &&

                CbTiposProveedor.SelectedIndex > -1)
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(TxtProveedorNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un nombre para el Proveedor", "error de validacion", MessageBoxButtons.OK);
                    TxtProveedorNombre.Focus();
                    return false;
                }
                //cedula
                if (string.IsNullOrEmpty(TxtProveedorCedula.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una cedula para el Proveedor", "error de validacion", MessageBoxButtons.OK);
                    TxtProveedorCedula.Focus();
                    return false;
                }
                //
                if (string.IsNullOrEmpty(TxtProveedorEmail.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un correo para el Proveedor", "error de validacion", MessageBoxButtons.OK);
                    TxtProveedorEmail.Focus();
                    return false;
                }

                


                if (CbTiposProveedor.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un tipo para el Proveedor", "error de validacion", MessageBoxButtons.OK);
                    CbTiposProveedor.Focus();
                    return false;
                }

            }

            return R;
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
          if (ValidarDatosDigitados())
         {

            

            bool CedulaOK;
            bool EmailOK;

            MiProveedorLocal = new Logica.Models.Proveedor();
            //
            MiProveedorLocal.ProveedorNombre = TxtProveedorNombre.Text.Trim();
            MiProveedorLocal.ProveedorCedula = TxtProveedorCedula.Text.Trim();
            MiProveedorLocal.ProveedorEmail = TxtProveedorEmail.Text.Trim();
            MiProveedorLocal.ProveedorNotas = TxtProveedorNotas.Text.Trim();
            //composicion del rol
            MiProveedorLocal.MiTipoProveedor.ProveedorTipo = Convert.ToInt32(CbTiposProveedor.SelectedValue);
            MiProveedorLocal.ProveedorDireccion = TxtProveedorDireccion.Text.Trim();

          
            CedulaOK = MiProveedorLocal.ConsultarPorCedula(MiProveedorLocal.ProveedorCedula);

            //paso 1.4 y 1.4.6
            EmailOK = MiProveedorLocal.ConsultarPorEmail(MiProveedorLocal.ProveedorEmail);

            if (CedulaOK == false && EmailOK == false)
            {

                string msg = string.Format("¿Esta seguro que desee agregar al proveedor¨{0}?", MiProveedorLocal.ProveedorNombre);


                DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    bool ok = MiProveedorLocal.Agregar();

                    if (ok)
                    {
                        MessageBox.Show("Proveedor guardado correctamente!", ":)", MessageBoxButtons.OK);

                        LimpiarFormulario();

                        CargarListaDeProveedor();
                    }
                    else
                    {
                        MessageBox.Show("El Proveedor no se ha guardado!", ":/)", MessageBoxButtons.OK);
                    }

                }

            }
            else
            {


                if (CedulaOK)
                {
                    MessageBox.Show("Ya existe un Proveedor con la cedula digitada", "Error de validacion", MessageBoxButtons.OK);
                    return;
                }
                if (EmailOK)
                {
                    MessageBox.Show("Ya existe un Proveedor con el email digitado", "Error de validacion", MessageBoxButtons.OK);
                    return;
                }
            }

        }

    }

        private void DgLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
