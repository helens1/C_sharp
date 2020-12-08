using System;
public class Gato: Mamifero // <- Herencia
{
    public bool EsDomestico { get; set; }

    public Gato() // <- Polimorfismo
    {
        EsDomestico = true;
    }

    public Gato(bool esDomestico) // <- Polimorfismo
    {
        EsDomestico = esDomestico;
    }
    public string Pelaje { get; set; }

    public void Maullar() // <- Abstraccion
    {
        Console.WriteLine("Miau miau miau");
    }

    public void Tamano()
    {
        DescribirTamano();
        DescribirRaza();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("Es un gato pequeño");
    }

    private void DescribirRaza() // <- Encapsulamiento
    {
      Console.WriteLine("Es un gato de raza persa");
    }
}