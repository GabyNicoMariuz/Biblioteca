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
    public partial class FDevolucionLibro : Form
    {
        Biblioteca biblioteca;
        Prestamo prest;
        Prestamo devolucion;

        public FDevolucionLibro(Biblioteca b)
        {
            biblioteca = b;
            InitializeComponent();
            tbFActual.Text = DateTime.Now.ToString();
            lAviso.Visible = false;

        }

        private void Bprestamo_Click(object sender, EventArgs e)
        {
            Flistadoprestamos listprest = new Flistadoprestamos(biblioteca);
            listprest.ShowDialog();
            prest = listprest.darPrestamo();
            if(prest != null)
            {
                tbNum.Text = prest.numero.ToString();
                tbFD.Text = prest.fechaDev.ToString();
                tbFP.Text = prest.fechaprestamo.ToString();
                if (prest.fechaDev < DateTime.Now)
                    lAviso.Visible = true;

                //datos socio
                tbApellido.Text = prest.Socio.Apellido;
                tbDNI.Text = prest.Socio.DNI.ToString();
                tbNombre.Text = prest.Socio.Nombre;

                //datos libro
                tbTitulo.Text = prest.ejemp.Libro.Nombre;
                tbGenero.Text = prest.ejemp.Libro.Genero;
                tbAutor.Text = prest.ejemp.Libro.Autor;
            }
            

        }



        public Prestamo darPrestamo()
        {
            return devolucion;
        }

        //Registrar devolución
        private void Button1_Click(object sender, EventArgs e)
        {
            
            devolucion = prest;
            if (devolucion != null)
                this.Close();
            else
                MessageBox.Show("Complete los campos obligatorios");
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
