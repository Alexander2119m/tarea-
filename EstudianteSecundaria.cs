class EstudianteSecundaria : IEstudiante
{ 
string _nombre = "";
string _apellido = "";
string _institucion = "";
int _CedulaI;
int _nivel; 
int matricula = 20;
int total;

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
int nivel
{
    get { return _nivel;}
    set { _nivel = value;}
}

    public void DatosExtra(int nivel)
    {
        this.nivel = nivel;
    }

    public void Datos(string nombre, string apellido, string institucion, int CedulaI)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.institucion = institucion;
        this.CedulaI = CedulaI;
    }
    public int CalculoPrecio()
    {
        total = matricula* nivel;
        return total ;
    }
    public override void ImprimirDatos()
    {
         Console.WriteLine("-------------------------------------");
        Console.WriteLine(" .....Estudiante de Secundaria.....");
        Console.WriteLine("Nombre: "+this.nombre);
        Console.WriteLine("Apellido: "+this.apellido);
        Console.WriteLine("Nombre de la Institución: "+this.institucion);
        Console.WriteLine("Cédula de identidad: "+this.CedulaI);
        Console.WriteLine("El valor de la matricula por "+this.nivel+" niveles es de: "+CalculoPrecio()+" $");
    }  
}