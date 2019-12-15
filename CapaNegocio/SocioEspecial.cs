using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class SocioEspecial:Socio
    {
        private static int cantDias = 5;
        private static int cantMaxLibros;

        public SocioEspecial(int id, string nombre, string apellido, int dni, string domicilio, int tel) :
         base(id, nombre, apellido, dni, domicilio, tel)
        {
          
        }


        public override int diasRetirar()
        {
            return cantDias;
        }
    }
}
