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
        private int cantEjemplares;
        private List<Ejemplar> listadoEjemplares;

        //Constructor
    

        public Libro(int id, string nom, int isbn, string autor, string genero, int cant)
        {
            this.id = id;
            this.isbn = isbn;
            this.autor = autor;
            this.genero = genero;
            this.cantEjemplares = cant;
            listadoEjemplares = new List<Ejemplar>();
        }

        public int cantEjemplaresDisponibles()
        {
            return this.listadoEjemplares.Count;
        }

        public List<Ejemplar> ListadoEjemplares
        {
            get { return this.listadoEjemplares; }
            set { this.listadoEjemplares = value; }
        }
        public int CantEjemplares
        {
            get { return this.cantEjemplares; }
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
