using System;

public abstract class Aves: Animal
{
    public int Plumaje { get; set; }

    public void Volar()
    {
        Console.WriteLine("Volando...");
    }
}