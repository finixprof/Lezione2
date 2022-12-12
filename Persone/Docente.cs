using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione2.Persone
{
    public class Docente : Dipendente
    {
        public string Materia { get; set; }
        //dobbiamo fare l'overrride del metodo abstract
        public override void EsegueIlSuoLavoro()
        {
            Console.WriteLine("Insegna");
        }

        public new string ToString()
        {
            return $"{Nome} {Cognome} {Eta} {Salario:N2} {Materia}";
        }
    }
}
