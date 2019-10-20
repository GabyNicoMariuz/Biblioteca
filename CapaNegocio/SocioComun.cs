using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class SocioComun:Socio
    {
        SocioComun(int id, int nombre, int apellido, int dni, string domicilio, int tel) :
           base(id, nombre, apellido, dni, domicilio, tel)
        {

        }

    }
}
