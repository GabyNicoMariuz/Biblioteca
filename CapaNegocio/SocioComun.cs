using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class SocioComun:Socio
    {
        private static int cantdias = 3;
        private static int cantMaxLibros;
        public SocioComun(int id, string nombre, string apellido, int dni, string domicilio, int tel) :
           base(id, nombre, apellido, dni, domicilio, tel)
        {

        }

        public override int diasRetirar()
        {
            return cantdias;
        }

    }
}
