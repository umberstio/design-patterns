using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    /*
     * Heredamos de ICLonable
     * retornammos el objeto clonado en Clone()
     */
    class Animal : ICloneable
    {
        public int Patas { get; set; }
        public string Nombre { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
