using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new ServerContext();
            server.State = new DisponibleServerState();
            server.AtenderSolicitud();

            server.State = new SaturadoServerState();
            server.AtenderSolicitud();

            server.State = new CaidoServerState();
            server.AtenderSolicitud();

            server.State = new SuperSaturadoServerState();
            server.AtenderSolicitud();
        }
    }
}
