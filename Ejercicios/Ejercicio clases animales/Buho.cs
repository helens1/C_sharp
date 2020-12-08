using System;
public class Buho: Aves // <- Herencia
{
    public bool EsSalvaje { get; set; }

    public Buho() // <- Polimorfismo
    {
        EsSalvaje = true;
    }

    public Buho(bool esSalvaje) // <- Polimorfismo
    {
        EsSalvaje = esSalvaje;
    }

    public void Chilla() // <- Abstraccion
    {
        Console.WriteLine("Buu Buu Buu");
    }

    public void Tamano()
    {
        DescribirTamano();
        DescribirEspecie();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("Es un buho mediana");
    }

    private void DescribirEspecie() // <- Encapsulamiento
    {
      Console.WriteLine("Es buho nival");
    }
}