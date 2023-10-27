using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiegoManuel_FactoryMethod_Proyecto4
{
    internal class Cerveza : BebidaEmbriagante
    {
        public override int CuantoMeEmbriaga()
        {
            return 5;
        }
    }
}
