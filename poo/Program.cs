using System;

namespace poo
{
    class Program
    {
        static void Main(string[] args)
        {
            // //instanciando un objeto de la clase cars
            // Cars c1 = new Cars();

            // // //llamar los atributos del objeto c1
            // System.Console.WriteLine("La marca del carro es: "+c1.marca);
            // System.Console.WriteLine("El color del carro es: "+c1.color);
            // c1.saludoCars();

            // // System.Console.WriteLine("Digite la nueva marca");
            // // c1.marca = Console.ReadLine();
            // // System.Console.WriteLine("Digite el color nuevo");
            // // c1.color= Console.ReadLine();

            // // System.Console.WriteLine("Nueva marca "+c1.marca);
            // // System.Console.WriteLine("Nuevo color "+c1.color);

            // // Animals animal = new Animals (2012, "Perro", "Doberman");
            // // System.Console.WriteLine(animal.name);
            // // System.Console.WriteLine(animal.raza);

            // // animal.name = "firulais";
            // // System.Console.WriteLine("Nuevo nombre animal"+animal.name);

            // // animal.setcolor ("amarillo");
            // // System.Console.WriteLine("Nuevo color"+animal.getcolor());

            // Fruta f1 = new Fruta();
            // f1.Nombre = "pera";
            // System.Console.WriteLine("Nombre de la fruta: "+f1.Nombre);

            // f1.Peso = 25;
            // System.Console.WriteLine("Peso de la fruta: "+f1.Peso);

            // f1.Textura = "Rugosa";
            // System.Console.WriteLine("Textura de la fruta: "+f1.Textura);


            // Ford ford1 = new Ford();
            // System.Console.WriteLine(ford1.marca);
            // ford1.saludoCars();

            //creacion de un objeto tipo persona
            Persona person = new Persona("Joe", "Arroyo", 30);
            System.Console.WriteLine($"Su nombre completo es {person.name} {person.lastname}");
            person.saludoPersona ();

            Cliente cliente01 = new Cliente("Mike", "Tyson", 53, 123456);
            //cliente01.Id = 123456;
            cliente01.saludoPersona();
        }
    }
}
