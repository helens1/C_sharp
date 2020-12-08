using System;
public class Perro: Mamifero // <- Herencia
{
    public bool EsDomestico { get; set; }

    public Perro() // <- Polimorfismo
    {
        EsDomestico = true;
    }

    public Perro(bool esDomestico) // <- Polimorfismo
    {
        EsDomestico = esDomestico;
    }

    public void Ladrar() // <- Abstraccion
    {
        Console.WriteLine("Gua gua gua");
    }

    public void Tamano()
    {
        DescribirTamano();
        DescribirRaza();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("Es un perro grande");
    }

    private void DescribirRaza() // <- Encapsulamiento
    {
      Console.WriteLine("Es un perro de raza bulldog");
    }
}