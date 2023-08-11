using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Provincia
    {
        public byte id { get; set; }
        public string provincia { get; set; }
        public Provincia() { }
        public Provincia(byte id, string provincia)
        {
            this.id = id;
            this.provincia = provincia;
        }
    }
}
