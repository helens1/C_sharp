using System;
public abstract class Animal
{
    public string Nombre { get; set; }
    public string Genero { get; set; }

    public void Comer()
    {
        Console.WriteLine("Comiendo...");
    }
}