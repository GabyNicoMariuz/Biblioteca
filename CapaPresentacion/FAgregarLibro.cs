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
    public partial class FAgregarLibro : Form
    {

        Libro l = null;
        Random r = new random();

        public FAgregarLibro()
        {
            InitializeComponent();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = tbNom.Text;
                int isbn = int.Parse(tbISBN.Text);
                string autor = tbAutor.Text;
                string genero = tbGenero.Text;
                int cant = int.Parse(tbCantEjem.Text);
                int id = r.Next(); //id aleatorio no negativo
                l = new Libro(id, nom, isbn, autor, genero, cant);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Complete todos los campos con datos válidos");
            }
        }

        public Libro devolverLibro()
        {
            return l;
        }



    }


}
