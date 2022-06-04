class EstudianteUniversitario : IEstudiante
{ string _nombre = "";
string _apellido = "";
string _institucion = "";
int _CedulaI;
int _credito;
int total;
int precio = 7;
string nombre
{
    get { return _nombre;}
    set { _nombre = value;}
}
string apellido
{
    get { return _apellido;}
    set { _apellido = value;}
}
string institucion
{
    get { return _institucion;}
    set { _institucion = value;}
}
int CedulaI
    {
    get { return _CedulaI; }
    set { _CedulaI = value;}
}
int credito
{
    get { return _credito;}
    set { _credito = value;}
}
    public void Datos(string nombre, string apellido, string institucion, int CedulaI)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.institucion = institucion;
        this.CedulaI = CedulaI;
    }
    public void DatosEx(int credito)
    {
        this.credito = credito;
    }
    public int CalculoPrecio()
    {   
        total = credito*precio;
        return total ;
    }
    public override void ImprimirDatos()
    {
        Console.WriteLine("  ");
        Console.WriteLine(" .....Estudiante Universitario .....");
        Console.WriteLine("Nombre: "+this.nombre);
        Console.WriteLine("Apellido: "+this.apellido);
        Console.WriteLine("Nombre de la Institución: "+this.institucion);
        Console.WriteLine("Cédula de identidad: "+this.CedulaI);
        Console.WriteLine("El valor de la matricula por "+this.credito+" créditos es de: "+CalculoPrecio()+" $");
    }
}