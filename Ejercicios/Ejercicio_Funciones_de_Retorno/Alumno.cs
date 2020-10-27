
public class Alumno
{
    public int Id {get; set; }

    public string PrimerNombre {get; set; }

    public string SegundoNombre {get; set; }

    public Alumno (int id, string primerNombre, string segundoNombre){
        Id = id;
        PrimerNombre = primerNombreNombre;
        SegundoNombre = segundoNombre;
    }

    public string nombreCompleto(){
        return PrimerNombre + " " + SegundoNombre;
    }
}