using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione2.Persone
{
    public class Docente : Dipendente
    {
        //dobbiamo fare l'overrride del metodo abstract
        public override void EsegueIlSuoLavoro()
        {
            Console.WriteLine("Insegna");
        }
    }
}
