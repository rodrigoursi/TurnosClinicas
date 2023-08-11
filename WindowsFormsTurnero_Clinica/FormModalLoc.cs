using Dominio;
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
    public partial class FormModalLoc : Form
    {
        public int id {  get; set; }
        public FormModalLoc()
        {
            InitializeComponent();
        }

        private void FormModalLoc_Load(object sender, EventArgs e)
        {
            try
            {
                ProvinciaNegocio negocioProv = new ProvinciaNegocio();
                comboModal_prov.DisplayMember = "provincia";
                comboModal_prov.ValueMember = "id";
                List<Provincia> listProv = negocioProv.listar();
                listProv.Insert(0, new Provincia { id = 0, provincia = "Selecciona una provincia" });
                comboModal_prov.DataSource = listProv;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void button_agregarUser_Click(object sender, EventArgs e)
        {
            HelperInterface helper = new HelperInterface();
            List<TextBox> list = new List<TextBox>();
            list.Add(textModal_nombre);
            if(helper.validarBoxVacio(list))
            {
                MessageBox.Show("Campo localidad vacio...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Provincia provincia = (Provincia)comboModal_prov.SelectedItem;
            if (provincia.id < 1)
            {
                MessageBox.Show("Debe elegir una provincia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string mensaje = "ERROR...! No se pudo realizar la operacion.";
            try
            {
                LocalidadNegocio negLoc = new LocalidadNegocio();
                id = negLoc.agregarConDevId(agregarLocalidad(provincia));
                if (id > 0)
                {
                    mensaje = "Localidad guardada exitosamente.";
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                MessageBox.Show(mensaje, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(this.DialogResult == DialogResult.OK) this.Close();
            }
        }
        private Localidad agregarLocalidad(Provincia provincia)
        {
            Localidad localidad = new Localidad(provincia);
            localidad.localidad = textModal_nombre.Text;
            return localidad;
        }
    }
}
