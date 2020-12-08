using System;
public class PezGlobo: Aves // <- Herencia
{
    public bool EsSalvaje { get; set; }

    public PezGlobo() // <- Polimorfismo
    {
        EsSalvaje = true;
    }

    public PezGlobo(bool esSalvaje) // <- Polimorfismo
    {
        EsSalvaje = esSalvaje;
    }

    public void Inflarse() // <- Abstraccion
    {
        Console.WriteLine("Se infla");
    }

    public void Tamano()
    {
        DescribirTamano();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("Es un pez pequeño");
    }
}