using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class profesorh:Profesor
    {
        public int preciohora { set; get; }
        public int cantidadhora { set; get; }
        public profesorh(int preciohora, int cantidadH,string nombre, string apellido, string direccion, int cedula) : base(nombre, apellido, direccion, cedula)
        {
            this.preciohora = preciohora;
            this.cantidadhora = cantidadH;
        }
        public override void imprir_datos()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido " + apellido);
            Console.WriteLine("direccion " + direccion);
            Console.WriteLine("cedula " + cedula_identidad);
            Console.WriteLine("Precio por hora " + preciohora);
            Console.WriteLine("Horas trabajadas " + cantidadhora);
        }

        public override void calcular_sueldo()
        {
            int valor_horas;
            valor_horas = preciohora * cantidadhora;

            Console.WriteLine("El sueldo a recibir es " + valor_horas);
        }
    }
}
