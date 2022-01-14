using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class DisponibleServerState : ServerState
    {
        public override void Respuesta()
        {
            Console.WriteLine("Respuesta 200 normal");
        }
    }
}
