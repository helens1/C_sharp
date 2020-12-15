public class Empleado: Persona
{
    public string CodigoEmpleado { get; set; }

    public Empleado(int codigo, string nombre, string codigoEmpleado)
    {
        Codigo = codigo;
        Nombre = nombre;
        CodigoEmpleado = codigoEmpleado;
    }
}