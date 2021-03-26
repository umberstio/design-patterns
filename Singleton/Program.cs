using System;

namespace Singleton
{
    class Program
    {
        /*
         * SINGLETON:
         * Solución para casos de instanciación excesiva
         * y reutilizar esta a lo largo del programa  
         *  
         *  DESVENTAJAS:
         *  - Funciona de forma sincrona, por lo que la alta concurrencia podria dar problemas
         *  - Se debe tener cuidado ya que al modificar su estado, este permanecerá cambiado
         *  a lo alrgo del programa.
         */

        static void Main(string[] args)
        {
            var myObj = SingletonPattern.Instance;

            Console.WriteLine(myObj.Message);

            SingletonPattern.Instance.Message = 
                "lo cambio desde afuera, ya no soy el mensaje original";
            
            Console.WriteLine(SingletonPattern.Instance.Message);
        }
    }
}
