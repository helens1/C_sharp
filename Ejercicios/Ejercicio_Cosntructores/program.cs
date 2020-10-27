using System;
					
namespace propiedades
{
	
	class Program
	{
		
		static void Main (string [] args)
		{
			Alumno a = new Alumano();			
			a.PrimerNombre = "Juan";
			a.SegundoNombre = "Perez";
			
			Alumno b = new Alumano();
			b.Id = 2;
			b.PrimerNombre = "Maria";
			b.SegundoNombre = "Martinez";

            Alumno c = new Alumno(3);
            b.PrimerNombre = "Pedro";
			
		
			Console.WriteLine(a.Id); 
            Console.WriteLine(b.Id); 
            Console.WriteLine(c.Id); 
		}
	}
}	