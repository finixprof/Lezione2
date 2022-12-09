using System.Linq;

namespace Lezione2.Persone
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona = new Persona(); // prima istanza della classe Persona
            persona.Cognome = "Finix";
            persona.Nome = "Salvo";
            persona.Eta = 18;
            Console.WriteLine(persona.ToString());

        }
    }
}