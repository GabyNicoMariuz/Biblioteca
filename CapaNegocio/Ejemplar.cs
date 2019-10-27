using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Ejemplar
    {
        private int numEjemplar;
        private Boolean estado;
        private Libro libro;


        //constructor
        public Ejemplar(int numEjemplar,bool estado,Libro libro)
        {
            this.numEjemplar = numEjemplar;
            this.estado = estado;
            this.libro = libro;
        }


    }
}
