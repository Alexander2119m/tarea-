using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Profesor profesorh = new profesorh(10, 24, "Juan", "machuca", "Centro", 123456798);
            profesorh.imprir_datos();
            profesorh.calcular_sueldo();

            Profesor profesorm = new profesorn(400,  "walter", "zambrano", "Altamira", 345233223);
            profesorm.imprir_datos();
            profesorm.calcular_sueldo();

            Profesor profesorc = new profesorc(400, 399, 50, "Solange", "Vasquez", "CostaAzul", 564322442);
            profesorc.imprir_datos();
            profesorc.calcular_sueldo();

        }
    }
}
