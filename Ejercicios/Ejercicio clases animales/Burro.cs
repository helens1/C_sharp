using System;
public class Burro: Mamifero // <- Herencia
{
    public bool EsDomestico { get; set; }

    public Burro() // <- Polimorfismo
    {
        EsDomestico = true;
    }

    public Burro(bool esDomestico) // <- Polimorfismo
    {
        EsDomestico = esDomestico;
    }

    public void Rebuznar() // <- Abstraccion
    {
        Console.WriteLine("jija jija jija");
    }

    public void Tamano()
    {
        DescribirTamano();
       
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("Es un Burro grande");
    }
}