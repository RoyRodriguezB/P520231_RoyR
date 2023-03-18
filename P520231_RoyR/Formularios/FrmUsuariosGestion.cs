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
    

    public partial class FrmUsuariosGestion : Form
    {

        //usar objetos individuales en la funcion puede provar desorden y
        //complicar mas la lectura del codigo fuente

        //objeto local usuario

        private Logica.Models.Usuario MiUsuarioLocal { get; set; }

        private DataTable ListaUsuarios { get; set; }


        public FrmUsuariosGestion()
        {
            InitializeComponent();

            MiUsuarioLocal = new Logica.Models.Usuario();
            ListaUsuarios = new DataTable();

        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            //definimos el padre mdi
            MdiParent = Globales.MiFormPrincipal;

            CargarListaRoles();

            CargarListaDeUsuarios();
        }

        private void CargarListaDeUsuarios()
        {
            ListaUsuarios = new DataTable();
            if(CboxVerActivos.Checked)
            {
                ListaUsuarios = MiUsuarioLocal.ListarActivos();

            }
            else
            {
                ListaUsuarios = MiUsuarioLocal.ListarInactivos();
            }

            DgLista.DataSource = ListaUsuarios;
                 

        }


        private void CargarListaRoles()
        {
            //crear un obj de tipo usuariorol 
            Logica.Models.Usuario_Rol MiRol = new Logica.Models.Usuario_Rol();

            DataTable dt = new DataTable();
            dt = MiRol.Listar();

            if (dt!= null && dt.Rows.Count > 0)
            {
                CbRolesUsuario.ValueMember = "ID";
                CbRolesUsuario.DisplayMember = "Descrip";
                CbRolesUsuario.DataSource = dt;
                CbRolesUsuario.SelectedIndex = -1;
            } 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtUsuarioDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void DgLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgLista.ClearSelection();
        }

        private void DgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cuando seleccionemos fila del datagrip se debe cargar la info de dicho usuario
            //en el usuario local y 
            if (DgLista.SelectedRows.Count == 1)
            {
                DataGridViewRow MiFila = DgLista.SelectedRows[0];

                //vallor del ip del usuario para realizar consulta y taer datos para llenar el objeto de usuario local
                int IdUsuario = Convert.ToInt32(MiFila.Cells["CUsuarioID"].Value);

                MiUsuarioLocal = new Logica.Models.Usuario();

                //agregamos valor obtenido por la fila al ID del usuario local
                MiUsuarioLocal.UsuarioID = IdUsuario;

                //tengo objeto local con el valor del id,consultar
                //el usuario por ese id
                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorIDRetornaUsuario();

                //validamos el usuario local tenga datos
                if (MiUsuarioLocal != null && MiUsuarioLocal.UsuarioID > 0)
                {
                    //si cargamos correctamente el usuario local llenamos los controles

                    TxtUsuarioID.Text = Convert.ToString(MiUsuarioLocal.UsuarioID);
                    TxtUsuarioNombre.Text = MiUsuarioLocal.UsuarioNombre;
                    TxtUsuarioCedula.Text = MiUsuarioLocal.UsuarioCedula;
                    TxtUsuarioTelefono.Text = MiUsuarioLocal.UsuarioTelefono;
                    TxtUsuarioCorreo.Text = MiUsuarioLocal.UsuarioCorreo;
                    TxtUsuarioDireccion.Text = MiUsuarioLocal.UsuarioDireccion;

                    //combobox
                    CbRolesUsuario.SelectedValue = MiUsuarioLocal.MiRolTipo.UsuarioRolID;

                    //TODO desactivar botones q no son nesecesarios
                }

            }

        }
    }
}
