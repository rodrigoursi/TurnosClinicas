using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace WindowsFormsTurnero_Clinica
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            agregarOpcionesMenuUser();
            
        }
        protected void agregarOpcionesMenuUser()
        {
            RolNegocio negocio = new RolNegocio();
            List<Rol> lista = negocio.listar();
            var items = lista.Select(rol => new ToolStripMenuItem(rol.rol) { Tag = rol.id }).ToArray();
            usuariosToolStrip.DropDownItems.AddRange(items);
            agregarEvento(items);
        }
        protected void agregarEvento(ToolStripMenuItem[] items)
        {
            // Asignamos el evento de clic (Click) a cada elemento del menú
            foreach (var item in items)
            {
                item.Click += MenuItem_Click;
            }
        }
        private void MenuItem_Click(object sender, EventArgs e)
        {
            FormUsuarios pantalla = new FormUsuarios();
            crearPantalla(this, pantalla);
        }
        public void crearPantalla(Principal padre, FormUsuarios pantalla)
        {
            pantalla = Application.OpenForms.OfType<FormUsuarios>().FirstOrDefault();
            if (pantalla == null)
            {
                pantalla = new FormUsuarios();
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
