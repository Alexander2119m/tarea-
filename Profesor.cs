using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class Profesor
    { 
        public string nombre { set; get; }
        public string apellido { set; get; }
        public string direccion { set; get; }
        public int cedula_identidad { set; get; }

        public Profesor(string nombre, string apellido, string direccion,int cedula)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.cedula_identidad = cedula;
        }

        public virtual void imprir_datos() { }

        public virtual void calcular_sueldo() { }
    }
}
