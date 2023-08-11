using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTurnero_Clinica
{
    internal class HelperInterface
    {
        public bool validarBoxVacio(List<TextBox> listaTextBox)
            {
                bool lleno = listaTextBox.All(box => !string.IsNullOrEmpty(box.Text));
                if(lleno)
                {
                    return false;
                }
                return true;
            }
    }
}
