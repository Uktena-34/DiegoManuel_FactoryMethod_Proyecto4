using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiegoManuel_FactoryMethod_Proyecto4
{
    public class Creador
    {
        public const int Vino_tinto = 1;
        public const int Cerveza = 2;

        public static BebidaEmbriagante CreadorBebida (int tipo)
        {
            switch (tipo)
            {
                case Vino_tinto:
                    return new VinoTinto();
                case Cerveza:
                    return new Cerveza();
                default: return null;

            }
        }
            
    }
}
