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

         Biblioteca(string nombre, List<Libro> listLibros, List<Reserva> listReserv, List<Prestamo> listPresta, List<Socio> listSocios, List<Ejemplar> listEjemp)
        {
            this.nombre = nombre;
            this.listadoLibros = listLibros;
            this.listadoReservas = listReserv;
            this.listadoPrestamos = listPresta;
            this.listadoSocios = listSocios;
            this.listadoEjemplares = listEjemp;
        }


        public void registrarSocio()
        {

        }

    }
}
