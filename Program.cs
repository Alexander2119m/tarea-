using System;
namespace Examen1erparcialAdonis
{
    class Program
    {
        public static void Main(string [] args)
        {
            EstudiantePrimaria primaria = new EstudiantePrimaria();
            primaria.Datos("Raul ","Cevallos Vera","Fe alegria #2 ",131675482);
            primaria.ImprimirDatos();

            EstudianteSecundaria Secundaria = new EstudianteSecundaria();
            Secundaria.Datos("Pedro Anthonio","Intriago chavez","Pedro Fermin ",1316452874);
            Secundaria.DatosExtra(3);
            Secundaria.ImprimirDatos();

            EstudianteUniversitario Universitario = new EstudianteUniversitario();
            Universitario.Datos("Carlos Alberto","Cedeño Intriago","ULEAM",1316465827);
            Universitario.DatosEx(5);
            Universitario.ImprimirDatos();
        }
    }
}