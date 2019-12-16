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
        private Socio so;
        private Prestamo p;
        
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

        //Listar todos los socios
        private void ListadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Flistadosocios listsocios = new Flistadosocios(biblioteca);
            listsocios.ShowDialog();
        }


        //Agregar un socio
        private void DarDeAltaUnClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarSocio agregarsocio = new AgregarSocio();
            agregarsocio.ShowDialog();
            so = agregarsocio.darSocio();
            if (so != null)
            {
                biblioteca.registrarSocio(so);
                MessageBox.Show("El socio fue registrado con éxito");
            }
            else
                MessageBox.Show("El socio no pudo ser registrado");


        }

        //Registrar un prestamo
        private void BPrestamoLibro_Click(object sender, EventArgs e)
        {
            FPrestamoLibro prestlibro = new FPrestamoLibro(biblioteca);
            prestlibro.ShowDialog();

            p = prestlibro.darPrestamo();
            if (p != null)
            {
                p.ejemp.estadoPrestamo();
                biblioteca.agregarPrestamo(p);
                MessageBox.Show("El prestamo fue realizado con éxito");
            }
            else
                MessageBox.Show("No se pudo realizar el prestamo");

        }

        //Registrar devolucion de un libro
        private void BDevolucionLibro_Click(object sender, EventArgs e)
        {
            FDevolucionLibro registrarDevolucion = new FDevolucionLibro(biblioteca);
            registrarDevolucion.ShowDialog();
            p = registrarDevolucion.darPrestamo();
            if (p != null)
            {
                p.ejemp.estadoDisponible();
                biblioteca.eliminarPrestamo(p);
                MessageBox.Show("La devolución fue registrada correctamente");
            }
            else
                MessageBox.Show("No se ha registrado la devolución");

        }

        //Listado de los prestamos
        private void ListadoDePrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Flistadoprestamos listadoPrestamos = new Flistadoprestamos(biblioteca);
            listadoPrestamos.ShowDialog();
            
        }

        private void BReservarLibro_Click(object sender, EventArgs e)
        {

        }
    }
}
