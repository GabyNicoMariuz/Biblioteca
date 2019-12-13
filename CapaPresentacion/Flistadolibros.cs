﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Flistadolibros : Form
    {
        Biblioteca bi;
        List<Libro> libros;
        Libro l;
        
        public Flistadolibros(Biblioteca biblio)
        {
            InitializeComponent();
            libros = biblio.listaLibros;
            bi = biblio;
            /*dgview.DataSource = null;
            dgview.DataSource = libros;*/
            listBox1.DataSource = null;
            listBox1.DataSource = libros;
           
        }

        //Seleccionar un libro
        public Libro darLibro()
        {
            l = (Libro)listBox1.SelectedItem;
            this.Close();
            return l;
        }


        private void Button1_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

       
    }
}
