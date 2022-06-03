using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class profesorc : Profesor
    {
        public int sueldo_basico { set; get; }
        public int horas_extras { set; get; }
        public int precio_extras { set; get; }
        public profesorc(int sueldob, int horae,int precio, string nombre, string apellido, string direccion, int cedula) : base(nombre, apellido, direccion, cedula)
        {
            this.sueldo_basico= sueldob;
            this.horas_extras = horae;
            this.precio_extras = precio;
        }
        public override void imprir_datos()
        {
            Console.WriteLine("Nombre: "+ nombre);
            Console.WriteLine("Apellido " + apellido);
            Console.WriteLine("direccion " + direccion);
            Console.WriteLine("cedula " + cedula_identidad);
            Console.WriteLine("sueldo basico " + sueldo_basico);
            Console.WriteLine("horas extras " + horas_extras);
        }

        public override void calcular_sueldo()
        {
            int operacion, valor_horas;
            valor_horas = horas_extras * precio_extras;
            operacion = sueldo_basico + valor_horas;

            Console.WriteLine("El sueldo a recibir es "+ operacion);

        }
    }
}
