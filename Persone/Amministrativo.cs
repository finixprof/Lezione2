using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione2.Persone
{
    public class Amministrativo : Dipendente
    {
        public string Tipo { get; set; }
        //override -> polimorfismo tra classi
        public override void EsegueIlSuoLavoro()
        {
            Console.WriteLine("Gestisce");
        }

        //overload -> polimorfismo all'interno della classe
        public void EsegueIlSuoLavoro(string tipo = "")
        {
            Console.WriteLine($"Gestisce {tipo}");
        }

        public new string ToString()
        {
            return $"{Nome} {Cognome} {Eta} {Salario:N2} {Tipo}";
        }
    }
}
