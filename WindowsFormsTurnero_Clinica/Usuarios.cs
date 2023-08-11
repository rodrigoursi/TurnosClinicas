using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTurnero_Clinica
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            dataGridUsuarios.AutoGenerateColumns = false;
            armarTabla();

            UsuarioNegocio negocio = new UsuarioNegocio();
            dataGridUsuarios.DataSource = negocio.listar();
            dataGridUsuarios.Columns[0].Visible = false;
            
        }
        private void armarTabla()
        {
            dataGridUsuarios.Columns.Add(armarColumna("id", "id"));
            dataGridUsuarios.Columns.Add(armarColumna("nombreYApellido", "Nombre y Apellido"));
            dataGridUsuarios.Columns.Add(armarColumna("emailUsuario", "Correo electronico"));
            dataGridUsuarios.Columns.Add(armarColumna("numeroDeDocumento", "Numero de documento"));
        }
        private DataGridViewColumn armarColumna(string prop, string texto)
        {
            DataGridViewColumn nombreColumn = new DataGridViewTextBoxColumn();
            nombreColumn.DataPropertyName = prop;
            nombreColumn.HeaderText = texto;
            return nombreColumn;
        }

        private void button_agregarUser_Click(object sender, EventArgs e)
        {

            CrearUsuario pantalla = new CrearUsuario();
  
            Principal padre = this.MdiParent as Principal;
            crearPantalla(padre, pantalla);
            //this.Hide();
        }
        public void crearPantalla(Principal padre, CrearUsuario pantalla)
        {
            pantalla = Application.OpenForms.OfType<CrearUsuario>().FirstOrDefault();
            if (pantalla == null)
            {
                pantalla = new CrearUsuario();
                pantalla.MdiParent = padre;
                pantalla.Show();
            }
            else
            {
                MessageBox.Show("NO PUEDES ABRIR ESTA VENTANA SI YA TIENES OTRA IGUAL ABIERTA");
            }
        }
    }
}
