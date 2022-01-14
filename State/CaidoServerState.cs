using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class CaidoServerState : ServerState
    {
        public override void Respuesta()
        {
            Console.WriteLine("Respuesta 503");
        }
    }
}
