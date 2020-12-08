using System;

namespace _12_ejercicio_clase_animales
{
    class Program
    {
        static void Main(string[] args)
        {      
            Perro p = new Perro();
            p.Nombre = "Firulais";
            p.Genero = "Masculino";
            p.Patas = 4;
            p.EsDomestico = true;
            p.Comer();
            p.Caminar();
            p.Ladrar();
            p.Tamano();

            Console.WriteLine(p.Nombre);
            Console.WriteLine(p.Patas);

            Gato g = new Gato();
            g.Nombre = "Bigotes";
            g.Genero = "Masculino";
            g.Patas = 4;
            g.Pelaje = "Peludo";
            g.Comer();
            g.Caminar();
            g.Maullar();

            Burro b = new Burro();
            b.Nombre = "Florindo";
            b.Genero = "Masculino";
            b.Patas = 4;
            b.Comer();
            b.Caminar();
            b.Rebuznar();


            Aguila a = new Aguila();
            b.Nombre = "Ciro";
            b.Genero = "Masculino";
            b.Plumaje = "Color gris oscuro uniforme";
            b.Comer();
            b.Volar();
            b.Chillar();

            Loro l = new Loro();
            l.Nombre = "Lucas";
            l.Genero = "Masculino";
            l.Plumaje = "Color verde";
            l.Comer();
            l.Volar();
            l.Hablar();

            Buho b = new Buho();
            b.Nombre = "Lucifer";
            b.Genero = "Masculino";
            b.Plumaje = "Color cafe";
            b.Comer();
            b.Volar();
            b.Chilla();

        }
    }
}