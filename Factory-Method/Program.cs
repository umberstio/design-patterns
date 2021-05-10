using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var Bebida = Creador.CreadorDeBebidas(Creador.CERVEZA);
            Console.WriteLine(Bebida.CuantoMeEnbriagaPorHora());
            Console.ReadKey();
        }
    }
}
