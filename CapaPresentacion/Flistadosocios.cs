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
    public partial class Flistadosocios : Form
    {
        Biblioteca bi;
        List<Socio> Socios;
        Socio s;
        public Flistadosocios(Biblioteca biblio)
        {
            InitializeComponent();
            Socios = biblio.listaSocios;
            bi = biblio;
            /*dataGridView1.DataSource = null;
            dataGridView1.DataSource = Socios;*/
            listBox1.DataSource = null;
            listBox1.DataSource = Socios;
        }

      

        public Socio darSocio()
        {
            s = (Socio)listBox1.SelectedItem;
            this.Close();
            return s;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
