class EstudiantePrimaria : IEstudiante
{ 
string _nombre = "";
string _apellido = "";
string _institucion = "";
int _CedulaI;

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

    public void Datos(string nombre, string apellido, string institucion, int CedulaI)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.institucion = institucion;
        this.CedulaI = CedulaI;
    }

    public int Precio()
    {   
        return 100 ;
    }

    public void ImprimirDatos()
    {
        Console.WriteLine(" ------------------------------------- ");
        Console.WriteLine(" .....Estudiante de Primaria .....");
        Console.WriteLine("Nombre: "+this.nombre);
        Console.WriteLine("Apellido: "+this.apellido);
        Console.WriteLine("Nombre de la Institución: "+this.institucion);
        Console.WriteLine("Cédula de identidad: "+this.id);
        Console.WriteLine("Valor de la matrícula: "+Precio());
    }
}