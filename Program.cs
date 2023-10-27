using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiegoManuel_FactoryMethod_Proyecto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BebidaEmbriagante oBebida = Creador.CreadorBebida(Creador.Cerveza);
            Console.WriteLine(oBebida.CuantoMeEmbriaga());

        }
    }
}
