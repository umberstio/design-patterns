using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class EstrategiasDelBorrachoContext
    {
        private IBorracho oBorracho;

        public enum Comportamiento
        {
            HacerOjitos,
            InvitarCerverza
        }


        // Forma 1
        public void conquistar(Comportamiento option)
        {
            switch (option)
            {
                case Comportamiento.HacerOjitos:
                    oBorracho = new EstrategiaOjitos();
                    break;
                case Comportamiento.InvitarCerverza:
                    oBorracho = new EstrategiaInvitarCerveza();
                    break;
            }

            oBorracho.Conquistar();
        }

        // Forma 2
        public EstrategiasDelBorrachoContext()
        {
            //Estrategia por defecto
            this.oBorracho = new EstrategiaOjitos();
        }
        public void EstablecerConquiastaOjitos()
        {
            this.oBorracho = new EstrategiaOjitos();
        }

        public void EstablecerConquistaCerveza()
        {
            this.oBorracho = new EstrategiaInvitarCerveza();
        }

        public void Conquistar()
        {
            this.oBorracho.Conquistar();
        }
    }
}
