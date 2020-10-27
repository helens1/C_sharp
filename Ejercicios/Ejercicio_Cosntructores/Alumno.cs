public class Alumno
{
    public in Id {get; set; }

    public string PrimerNombre {get; set; }

    public string SegundoNombre {get; set; }

    public Alumno(){
        Id = 1;
    }
    public Alumno (int id){
        Id = id;
    }
}