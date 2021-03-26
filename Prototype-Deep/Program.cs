using System;

namespace Prototype_Deep
{
    /*
     * PROTOTYPE DEEP:
     * 
     * Clona los objetos dentro de nuestro objeto
     */

    class Program
    {
        static void Main(string[] args)
        {

            var animal1 = new Animal
            {
                Patas = 4,
                Nombre = "Animalito",
                Detalles = new Detalles
                {
                    Raza  = "Cacri",
                    Color = "Negro"
                }
            };

            var animalClonado = (Animal)animal1.Clone();
            animalClonado.Nombre = "se le cambio el nombre";
            animalClonado.Detalles.Color = "le cambio el color";

            Console.WriteLine("Animal 1:");
            Console.WriteLine(animal1.Patas);
            Console.WriteLine(animal1.Nombre); 
            Console.WriteLine(animal1.Detalles.Color);

            Console.WriteLine("\n");
            Console.WriteLine("Animal 2:");
            Console.WriteLine(animalClonado.Patas);
            Console.WriteLine(animalClonado.Nombre);
            Console.WriteLine(animalClonado.Detalles.Color);

            Console.WriteLine("\n");
            Console.WriteLine("Animal 1 again:");
            Console.WriteLine("Animal 1:");
            Console.WriteLine(animal1.Patas);
            Console.WriteLine(animal1.Nombre);
            Console.WriteLine(animal1.Detalles.Color);
        }
    }
}
