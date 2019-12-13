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
    public partial class FPrestamoLibro : Form
    {
        Socio s;
        Libro l;
        Ejemplar ejemplar;
        Biblioteca b;
        Prestamo prestamo;

        public FPrestamoLibro(Biblioteca biblio)
        {
            b = biblio;
            InitializeComponent();

           
        }




        //Devolver prestamo
        public Prestamo darPrestamo()
        {
            return prestamo;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //seleccionar libro
        private void Button1_Click(object sender, EventArgs e)
        {
            Flistadolibros flistlibro = new Flistadolibros(b);
            flistlibro.ShowDialog();
            l = flistlibro.darLibro(); //el libro elegido lo guardo en l
            if(l != null)
            {
                tbAutor.Text = l.Autor;
                tbGenero.Text = l.Genero;
                tbTitulo.Text = l.Nombre;
                int cantEjemplares = b.verificarEjemplares(l);
                if (cantEjemplares > 0)
                {
                    ejemplar = b.obtenerEjemplar(l);
                    tbEjemplares.Text = cantEjemplares.ToString();
                }
                //else if
                    

            }
        }


        //Seleccionar socio



    }
}
