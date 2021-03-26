using System;

namespace Prototype
{
    class Program
    {
        /*
         * PROTOTYPE:
         * 
         * Utilizado para clonar un objeto. ( clonacion superficial, de los atributos del objeto)
         * 
         */
        static void Main(string[] args)
        {
            var animal1 = new Animal
            {
                Patas = 4,
                Nombre = "Animalito"
            };

            var animalClonado = (Animal) animal1.Clone();
            animalClonado.Nombre = "se le cambio el nombre";

            Console.WriteLine("Animal 1:");
            Console.WriteLine(animal1.Patas);
            Console.WriteLine(animal1.Nombre);

            Console.WriteLine("\n");
            Console.WriteLine("Animal 2:");
            Console.WriteLine(animalClonado.Patas);
            Console.WriteLine(animalClonado.Nombre);

            Console.WriteLine("\n");
            Console.WriteLine("Animal 1 again:");
            Console.WriteLine("Animal 1:");
            Console.WriteLine(animal1.Patas);
            Console.WriteLine(animal1.Nombre);

        }
    }
}
