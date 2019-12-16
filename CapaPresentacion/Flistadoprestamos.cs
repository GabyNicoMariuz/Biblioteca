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
    public partial class Flistadoprestamos : Form
    {
        Biblioteca biblio;
        Prestamo p;

        public Flistadoprestamos(Biblioteca b)
        {
            InitializeComponent();
            biblio = b;
            listBox1.DataSource = null;
            listBox1.DataSource = biblio.listaPrestamo;
        }


        //Seleccionar un prestamo
        public Prestamo darPrestamo()
        {
            p = (Prestamo)listBox1.SelectedItem;
            this.Close();
            return p;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
