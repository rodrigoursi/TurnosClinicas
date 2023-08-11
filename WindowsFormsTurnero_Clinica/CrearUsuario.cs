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
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            completarBoxes();
        }
        private void completarBoxes()
        {
            dropList_loc();
            dropList_rol();
            dropList_esp();
        }
        private void dropList_loc()
        {
            try
            {
                LocalidadNegocio negocioLoc = new LocalidadNegocio();
                comboBox_loc.DisplayMember = "localidad";
                comboBox_loc.ValueMember = "id";
                List<Localidad> listLoc = negocioLoc.listar();
                listLoc.Insert(0, new Localidad { id = 0, localidad = "Selecciona una localidad" });
                listLoc.Add(new Localidad { id = -1, localidad = "Agregar Nueva" });
                comboBox_loc.DataSource = listLoc;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void dropList_rol()
        {
            try
            {
                RolNegocio negocioRol = new RolNegocio();
                comboBox_rol.DisplayMember = "rol";
                comboBox_rol.ValueMember = "id";
                List<Rol> listRol = negocioRol.listar();
                listRol.Insert(0, new Rol { id = 0, rol = "Selecciona un rol" });
                comboBox_rol.DataSource = listRol;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void dropList_esp()
        {
            try
            {
                EspecialidadNegocio negocioEsp = new EspecialidadNegocio();
                comboBox_esp.DisplayMember = "especialidad";
                comboBox_esp.ValueMember = "id";
                List<Especialidad> listEsp = negocioEsp.listar();
                listEsp.Insert(0, new Especialidad { id = 0, especialidad = "Selecciona una especialidad" });
                comboBox_esp.DataSource = listEsp;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void comboBox_loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Localidad locElegida = (Localidad)comboBox_loc.SelectedItem;
            if (locElegida.id == -1)
            {
                FormModalLoc modal = new FormModalLoc();
                if(modal.ShowDialog() == DialogResult.OK)
                {
                    dropList_loc();
                    // ESTO BUSCA EL INDEX DEL VALUE(id) QUE LE MANDO.
                    int index = buscarValorCombo(comboBox_loc, modal.id);
                    comboBox_loc.SelectedIndex = index;
                }
            }
        }
        private int buscarValorCombo(ComboBox combo, int id)
        {
            for(int i = 0; i < comboBox_loc.Items.Count; i++)
            {
                if (((Localidad)combo.Items[i]).id == id) return i;
            }
            return 0;
        }
    }
}
