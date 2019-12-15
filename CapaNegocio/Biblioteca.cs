using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Biblioteca
    {
        private string nombre;
        private List<Libro> listadoLibros;
        private List<Reserva> listadoReservas;
        private List<Prestamo> listadoPrestamos;
        private List<Socio> listadoSocios;
        private List<Ejemplar> listadoEjemplares;

         public Biblioteca()
        {
            this.nombre = "Biblioteca";
            this.listadoLibros = new List<Libro>();
            this.listadoReservas = new List<Reserva>();
            this.listadoPrestamos = new List<Prestamo>();
            this.listadoSocios = new List<Socio>();
            this.listadoEjemplares = new List<Ejemplar>();
        }



        /*
         * 
         * LIBRO
         * 
         */

        //Devuelve true si el libro existe, sino false
        public bool verificarlibro(Libro l)
        {
            int i = 0;
            while (i < this.listadoLibros.Count && this.listadoLibros[i].ID != l.ID)
                i++;
            if(i < this.listadoLibros.Count)
                return true;//lo encontro
            else
                return false;//no lo encontro
        }

       
        public List<Libro> listaLibros
        {
            get { return this.listadoLibros; }
        }



        //Registrar un libro a la lista y sus ejemplares
        public void agrebarlibro(Libro l)
        {
            if (l != null)
                listadoLibros.Add(l);
            for (int i = 0; i < l.Ejemplares; i++)
            {
                Ejemplar ejem = new Ejemplar((i + 1), true, l);
                l.ListadoEjemplares.Add(ejem);
                this.listadoEjemplares.Add(ejem);
            }
        }



        /*
         * 
         * 
         * SOCIO
         * 
         * 
         */


        public List<Socio> listaSocios
        {
            get { return this.listadoSocios; }
        }


        //Registrar un socio
        public void registrarSocio(Socio s)
        {
            if (s != null && !listadoSocios.Contains(s))
                this.listadoSocios.Add(s);
        }


        /*
         * 
         * EJEMPLAR
         * 
         */

        //Cantidad de ejemplares disponibles de un libro
        public int verificarEjemplares(Libro l)
        {
            int cantEjemplares = 0;
            for(int i = 0;i < this.listadoEjemplares.Count; i++)
            {
                if ((listadoEjemplares[i].Libro.ID == l.ID) && (listadoEjemplares[i].Estado == true))
                    cantEjemplares++;
            }
            return cantEjemplares;
        }

        //Obtener un ejemplar
        public Ejemplar obtenerEjemplar(Libro l)
        {
            Ejemplar e = null;
            for (int i = 0; i < this.listadoEjemplares.Count; i++)
            {
                if ((listadoEjemplares[i].Libro.ID == l.ID) && listadoEjemplares[i].Estado == true)
                    e = listadoEjemplares[i];
            }
            return e;

        }


        /*
         * 
         * PRESTAMO
         * 
         */

        //Agregar un prestamo a la lista
        public void agregarPrestamo(Prestamo p)
        {
            listadoPrestamos.Add(p);
        }

        //Da la cantidad de prestamos hechos por un socio
        public int cantPrestamosRealizados(Socio s)
        {
            int cantPrestamos = 0;
            for(int i = 0;i < listadoPrestamos.Count; i++)
            {
                if (s == listadoPrestamos[i].Socio)
                    cantPrestamos++;
            }
            return cantPrestamos;
        }

        //Devuelve una lista con los prestamos que estan vencidos
        public List<Prestamo> cantPrestamosVencidos(Socio s)
        {
           
            List<Prestamo> prestamosVencidos = new List<Prestamo>();
            for(int i = 0; i < listadoPrestamos.Count; i++)
            {
                if (listadoPrestamos[i].Socio == s && listadoPrestamos[i].fechaDev < DateTime.Today)
                    prestamosVencidos.Add(listadoPrestamos[i]);
            }

            return prestamosVencidos;
        }



    }
}
