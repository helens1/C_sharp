using System;
public class Aguila: Aves // <- Herencia
{
    public bool EsSalvaje { get; set; }

    public Aguila() // <- Polimorfismo
    {
        EsSalvaje = true;
    }

    public Aguila(bool esSalvaje) // <- Polimorfismo
    {
        EsSalvaje = esSalvaje;
    }

    public void Chillar() // <- Abstraccion
    {
        Console.WriteLine("Chiii Chiii");
    }

    public void Tamano()
    {
        DescribirTamano();
        DescribirRaza();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("Es una aguila mediana");
    }

    private void DescribirRaza() // <- Encapsulamiento
    {
      Console.WriteLine("Es aguila real");
    }
}