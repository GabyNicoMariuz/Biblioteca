using System;
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
    public partial class FPrincipal : Form
    {
        private Biblioteca biblioteca;
        private Libro l;
        private Socio s;
        
        public FPrincipal()
        {
            InitializeComponent();
            if (biblioteca == null)
                biblioteca = new Biblioteca();
        }

        //Se cierra la aplicacion
        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta saliendo de la aplicacion");
            this.Close();
        }




        //Agregar nuevo libro
        private void DarDeAltaUnLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAgregarLibro al = new FAgregarLibro();
            al.ShowDialog();
            l = al.devolverLibro();
            if (l != null)
            {
                if (biblioteca.verificarlibro(l) == false)
                {
                    biblioteca.agrebarlibro(l);
                    MessageBox.Show("El libro fue agregado con éxito");
                }
                else
                    MessageBox.Show("Ya existe ese libro");
            }
        }

        //Listar todos los libros
        private void ListadoDeLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Flistadolibros listlibros = new Flistadolibros(biblioteca);
            listlibros.ShowDialog();
        }

        //Agregar un socio
        private void DarDeAltaUnClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarSocio as = new AgregarSocio();

        }
    }
}
