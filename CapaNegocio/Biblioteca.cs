﻿using System;
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

        //Agrega un libro a la lista y sus ejemplares
        public void agrebarlibro(Libro l)
        {
            if (l != null)
                listadoLibros.Add(l);
            for(int i = 0; i < l.Ejemplares; i++)
            {
                Ejemplar ejem = new Ejemplar((i + 1),true, l);
                l.ListadoEjemplares.Add(ejem);
                this.listadoEjemplares.Add(ejem);
            }
        }

        public List<Libro> listaLibros
        {
            get { return this.listadoLibros; }
        }

        public void registrarSocio()
        {

        }

    }
}
