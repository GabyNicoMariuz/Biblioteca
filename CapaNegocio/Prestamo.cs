using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Prestamo
    {
        private int id;
        private Ejemplar ejemplar;
        private DateTime fechaPrestamo;
        private DateTime fechaDevolucion;
        private Socio socio;




        public Prestamo(Ejemplar ej, DateTime fp, Socio s, int np)
        {
            ejemplar = ej;
            fechaPrestamo = fp;
            fechaDevolucion = fechaPrestamo.AddDays(s.diasRetirar());
            socio = s;
            id = np;
        }

        public DateTime fechaDev
        {
            get { return this.fechaDevolucion; }
        }
        public Socio Socio
        {
            get { return this.socio; }
        }

        public Ejemplar ejemp
        {
            get { return this.ejemplar; }
        }


    }
}