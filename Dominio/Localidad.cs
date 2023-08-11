using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Dominio
{
    /*public class Localidad
    {
        public short id { get; set; }
        public string localidad { get; set; }
        public Provincia provincia { get; set; }
        public Localidad() { }
        public Localidad(Provincia provincia, string nombre)
        {
            this.provincia = provincia;
            this.localidad = nombre;
        }
    }*/
    public class Localidad
    {
        public short id { get; set; }
        public string localidad { get; set; }
        public Provincia provincia { get; }
        public Localidad( byte id_prov, string prov ) 
        { 
            provincia = new Provincia(id_prov, prov);
        }
        public Localidad (Provincia provincia)
        {
            this.provincia = provincia;
        }
        public Localidad() { }
    }
}
