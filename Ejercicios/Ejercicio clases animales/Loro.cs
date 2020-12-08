using System;
public class Loro: Aves // <- Herencia
{
    public bool EsDomestico { get; set; }

    public Loro() // <- Polimorfismo
    {
        EsDomestico = true;
    }

    public Aguila(bool esDomestico) // <- Polimorfismo
    {
        EsDomestico = esDomestico;
    }

    public void Hablar() // <- Abstraccion
    {
        Console.WriteLine("Hola me llamo lucas");
    }

    public void Tamano()
    {
        DescribirTamano();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("Es un loro pequeño");
    }
}