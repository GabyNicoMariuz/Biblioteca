using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Libro
    {
        private int id;
        private int isbn;
        private string nombre;
        private string autor;
        private string genero;
        private List<Ejemplar> listadoEjemplares;

        //Constructor
       Libro(int id, int isbn, string nombre, string autor, string genero, List<Ejemplar> listadoEjemplares)
        {
            this.id = id;
            this.isbn = isbn;
            this.nombre = nombre;
            this.autor = autor;
            this.genero = genero;
            this.listadoEjemplares = listadoEjemplares;
        }




        public int cantEjemplaresDisponibles()
        {
            return this.listadoEjemplares.Count;
        }


        public bool hayEjemplares()
        {
            if (this.listadoEjemplares.Count > 0)
                return true;
            else
                return false;
        }
    }
}
