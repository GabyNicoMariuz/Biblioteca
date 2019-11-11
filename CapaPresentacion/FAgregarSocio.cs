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
    public partial class AgregarSocio : Form
    {

        Socio s;
        readonly Random r = new random();
        public AgregarSocio()
        {
            InitializeComponent();
        }


        public Socio darSocio()
        {
            return s;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            s = null;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = tbNombre.Text;
                string ape = tbApellido.Text;
                int dni = int.Parse(tbDNI.Text);
                string domi = tbDireccion.Text;
                int tel = int.Parse(tbTel.Text);
                int id = r.Next();
                if (rbComun.Checked == true)
                    s = new SocioComun(id,nom,ape,dni,domi,tel); 
                else
                    if (rbEspecial.Checked == true)
                    s = new SocioEspecial(id,nom,ape,dni,domi,tel); 
                else
                    throw new Exception("No se selecciono un tipo de socio");

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Complete todos los datos con valores correctos");
            }

        }




    }
}
