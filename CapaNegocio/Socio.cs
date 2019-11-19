using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Socio
    {
        private int id;
        private string nombre;
        private string apellido;
        private int dni;
        private string domicilio;
        private int tel;

        //Constructor
        public Socio(int id, string nombre, string apellido, int dni, string domicilio, int tel)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.domicilio = domicilio;
            this.tel = tel;
            //contraseña
        }

        public int Identificacion
        {
            get { return this.id; }

        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public string Apellido
        {
            get { return this.apellido; }
        }

        public int DNI
        {
            get { return this.dni; }
        }

        public string Domicilio
        {
            get { return this.domicilio; }
        }


    }

}
