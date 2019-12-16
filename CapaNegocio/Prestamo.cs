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

        public override string ToString()
        {
            return ("Nombre: " + this.ejemplar.Libro.Nombre + ", Fecha prestamo: " + this.fechaPrestamo + ", Fecha devolución: " + this.fechaDevolucion + ", Socio: " + this.socio.Nombre);
        }


        public DateTime fechaDev
        {
            get { return this.fechaDevolucion; }
        }

        public DateTime fechaprestamo
        {
            get { return this.fechaPrestamo; }
        }

        public Socio Socio
        {
            get { return this.socio; }
        }

        public int numero
        {
            get { return this.id; }
        }

        public Ejemplar ejemp
        {
            get { return this.ejemplar; }
        }


    }
}