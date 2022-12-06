using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Lezione2.AreaTriangolo
{
    class Program
    {
        static void Main(string[] args)
        {
            //creare un metodo che permetta di inserire un numero positivo
            //controllo delle eccezioni
            var altezzaTriangolo = inserisciNumeroPositivo("l'altezza");
            //int.MinValue 
            //int.MaxValue            
            var baseTriangolo = inserisciNumeroPositivo("Inserisci la base");

            var areaTriangolo = baseTriangolo * altezzaTriangolo / 2.0;

            Console.WriteLine($"Il triangolo con base {baseTriangolo} e altezza {altezzaTriangolo} ha area uguale {areaTriangolo}");
        }

        private static int inserisciNumeroPositivo(string testo)
        {
            do
            {
                Console.WriteLine($"Inserisci {testo}");
                try
                {
                    var numeropositivo = Convert.ToInt32(Console.ReadLine());
                    if (numeropositivo > 0)
                        return numeropositivo;
                    Console.WriteLine("Il numero non è positivo");
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Il testo inserito non è un numero");
                }
                catch (OverflowException oe)
                {
                    Console.WriteLine($"Il numero inserito non è compreso tra 1 e {int.MaxValue}");
                }
            } while (true);
        }
    }
}