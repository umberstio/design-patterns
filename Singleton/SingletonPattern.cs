using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class SingletonPattern
    {
        private static SingletonPattern instance = null;

        public string Message { get; set; }

        protected SingletonPattern()
        {
            Message = "Fui instanciado por que era null";
        }

        /// <summary>
        /// Debe usar esta propiedad para obtener la instancia del objeto
        /// </summary>
        public static SingletonPattern Instance
        {
            get
            {
                if (instance == null)
                    instance = new SingletonPattern();

                return instance;
            }
        }

    }
}
