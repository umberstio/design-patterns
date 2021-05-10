using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class VinoTinto : BebidaEmbriagante
    {
        public override int CuantoMeEnbriagaPorHora()
        {
            return 20;
        }
    }
}
