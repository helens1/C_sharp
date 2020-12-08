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
            g.EsDomestico = true;
            g.Pelaje = "Peludo";
            g.Comer();
            g.Caminar();
            g.Maullar();

            Burro b = new Burro();
            b.Nombre = "Florindo";
            b.Genero = "Masculino";
            b.Patas = 4;
            b.EsDomestico = true;
            b.Comer();
            b.Caminar();
            b.Rebuznar();


            Aguila a = new Aguila();
            a.Nombre = "Ciro";
            a.Genero = "Masculino";
            a.Plumaje = "Color gris oscuro uniforme";
            a.EsSalvaje = true;
            a.Comer();
            a.Volar();
            a.Chillar();

            Loro l = new Loro();
            l.Nombre = "Lucas";
            l.Genero = "Masculino";
            l.Plumaje = "Color verde";
            l.EsDomestico = true;
            l.Comer();
            l.Volar();
            l.Hablar();

            Buho buho = new Buho();
            buho.Nombre = "Lucifer";
            buho.Genero = "Masculino";
            buho.Plumaje = "Color cafe";
            buho.EsSalvaje = true;
            buho.Comer();
            buho.Volar();
            buho.Chilla();

            PezGlobo pez = new PezGlobo();
            pez.Nombre = "Globito";
            pez.Genero = "Masculino";
            pez.Piel_o_Escamas = "No posee escamas. Su piel es aspera";
            pez.EsSalvaje = true;
            pez.Comer();
            pez.Nadar();
            pez.Inflarse();

        }
    }
}