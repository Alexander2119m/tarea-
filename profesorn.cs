using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class profesorn : Profesor
    {
        public int sueldo_fijo { set; get; }
        public profesorn(int sueldo, string nombre, string apellido, string direccion, int cedula) : base(nombre, apellido, direccion, cedula)
        {
            this.sueldo_fijo = sueldo;
        }
        public override void imprir_datos()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido " + apellido);
            Console.WriteLine("direccion " + direccion);
            Console.WriteLine("cedula " + cedula_identidad);
            Console.WriteLine("Sueldo fijo " + sueldo_fijo);
        }

        public override void calcular_sueldo()
        {
            do
            {
                Console.WriteLine("INGRESE SUELDO");
                int sueldoa;
                sueldoa = int.Parse(Console.ReadLine());
                sueldo_fijo = sueldoa;

            } while (sueldo_fijo < 1000);

            Console.WriteLine("El sueldo fijo mensual es "+sueldo_fijo);

        }
    }
}
