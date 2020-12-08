using System;

public abstract class Peces: Animal
{
    public int Piel_o_Escamas { get; set; }

    public void Nadar()
    {
        Console.WriteLine("Nadando...");
    }
}