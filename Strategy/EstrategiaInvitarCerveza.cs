using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class EstrategiaInvitarCerveza : IBorracho
    {
        public void Conquistar()
        {
            Console.WriteLine("Invito Cerveza");
        }
    }
}
