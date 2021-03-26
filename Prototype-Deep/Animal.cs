using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_Deep
{
    class Animal : ICloneable
    {
        public int Patas { get; set; }
        public string Nombre { get; set; }

        public Detalles Detalles { get; set; }

        public object Clone()
        {
            var retorno = (Animal) this.MemberwiseClone();
            retorno.Detalles = (Detalles) this.Detalles.Clone();
            return retorno;
        }
    }


    class Detalles : ICloneable
    {
        public string Color { get; set; }
        public string Raza { get; set; }

        public object Clone()
        {
            return (Detalles) this.MemberwiseClone();
        }
    }
}
