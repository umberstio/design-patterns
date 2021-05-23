using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            EstrategiasDelBorrachoContext oBorracho = new EstrategiasDelBorrachoContext();
            
            Console.WriteLine("Forma 1");
            
            oBorracho.conquistar(EstrategiasDelBorrachoContext.Comportamiento.HacerOjitos);
            oBorracho.conquistar(EstrategiasDelBorrachoContext.Comportamiento.InvitarCerverza);

            Console.WriteLine("Forma 2");

            oBorracho.EstablecerConquiastaOjitos();
            oBorracho.Conquistar();
            oBorracho.EstablecerConquistaCerveza();
            oBorracho.Conquistar();

            Console.ReadKey();
        }

    }
}
