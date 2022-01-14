using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class SuperSaturadoServerState: ServerState
    {
        public override void Respuesta()
        {
            Task.Delay(1000);
            Console.WriteLine("Respuesta 200 Delay de 1000");
        }
    }
}
