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
    public partial class FrmRegistroCompra : Form
    {

        //temporal para probar
        //public int IdProveedor { get; set; }

        //public string NombreProv { get; set; }


        //
        public Compra MiCompraLocal { get; set; }

        public DataTable ListaProductos { get; set; }

        public FrmRegistroCompra()
        {
            InitializeComponent();

            MiCompraLocal = new Compra();
            ListaProductos = new DataTable();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtNotas_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnProductoAgregar_Click(object sender, EventArgs e)
        {
            Form MiFormBusquedaItem = new FrmCompraAgregarProducto();

            DialogResult respuesta = MiFormBusquedaItem.ShowDialog();

            if (respuesta == DialogResult.OK)
            {

                DgvLista.DataSource = ListaProductos;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmRegistroCompra_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;

        }

       

        private void BtnProveedorBuscar_Click(object sender, EventArgs e)
        {
            Form FormBusquedaProveedor = new FrmProveedorBuscar();

            DialogResult respuesta = FormBusquedaProveedor.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                TxtProveedorNombre.Text = MiCompraLocal.MiProveedor.ProveedorNombre;
            }


        }
    }
}
