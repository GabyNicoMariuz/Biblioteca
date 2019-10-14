using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    class SocioComun : Socio
    {
        public SocioComun(int id, int nombre, int apellido, int dni, string domicilio, int tel) :
           base(id, nombre, apellido, dni, domicilio, tel)
        {

        }


    }
}
