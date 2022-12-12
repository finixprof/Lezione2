using System.Linq;

namespace Lezione2.Persone
{
    class Program
    {
        static void Main(string[] args)
        {
            //var persona = new Persona(); // prima istanza della classe Persona
            //persona.Cognome = "Finix";
            //persona.Nome = "Salvo";
            //persona.Eta = 18;
            //costruttore dinamico suggerico da VS
            var persona = new Persona
            {
                Cognome = "Finix",
                Nome = "Salvo",
                Eta = 18
            }; // prima istanza della classe Persona
            Console.WriteLine(persona.ToString());

            var docenti = new List<Docente>();

            var docente1 = new Docente()
            {
                Cognome = "C1",
                Nome = "N1",
                Eta = 35,
                Salario = 27000.50
            };

            docenti.Add(docente1);
            //Console.WriteLine(docente1.ToString());
            //docente1.EsegueIlSuoLavoro();

            var docente2 = new Docente()
            {
                Cognome = "C2",
                Nome = "N2",
                Eta = 45,
                Salario = 32000.99
            };
            docenti.Add(docente2);
            //Console.WriteLine(docente2.ToString());
            //docente2.EsegueIlSuoLavoro();

            foreach (var item in docenti)
            {
                Console.WriteLine(item.ToString());
                item.EsegueIlSuoLavoro();
            }
            var amministrativo1 = new Amministrativo
            {
                Cognome = "C3",
                Nome = "N3",
                Eta = 55,
                Salario = 22000.49
            };

            var dipendenti = new List<Dipendente>();
            dipendenti.Add(amministrativo1);
            dipendenti.AddRange(docenti);

            var persone = new List<Persona>();
            persone.Add(amministrativo1);
            persone.AddRange(docenti);

            foreach (var item in dipendenti)
            {
                Console.WriteLine(item.ToString());
                item.EsegueIlSuoLavoro();
            }

            foreach (var item in persone)
            {
                Console.WriteLine(item.ToString());
                ((Dipendente)item).EsegueIlSuoLavoro();
            }

        }
    }
}