namespace CursoCSharp;

public class Persona
{
    private string nombre;
    private int edad;
    private string fechaNacimiento;

    public string Nombre { get => nombre; set => nombre = value; }
    public int Edad { get => edad; set => edad = value; }
    public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }


    public void crearPersona(string _nombre, int _edad, string _fechaVencimiento)
    {
        nombre = _nombre;
        edad = _edad;
        fechaNacimiento= _fechaVencimiento;
    }

}
