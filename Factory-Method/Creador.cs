using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class Creador
    {
        public const int VINO_TINTO = 1;
        public const int CERVEZA = 2;
        public static BebidaEmbriagante CreadorDeBebidas(int tipo)
        {
            switch (tipo)
            {
                case VINO_TINTO:
                    return new VinoTinto();
                   
                case CERVEZA:
                    return new Cerveza();
                default:
                    return null;
            }
        }
    }
}
