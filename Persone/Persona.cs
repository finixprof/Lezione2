

namespace Lezione2.Persone
{
    public class Persona
    {
        //public string Nome { get; set; } 
        public string Nome {
            get {
                if (Nome == null)
                    return "Nessuno";
                return Nome;
            }
            set { Nome = value; } 
        }


        private string _cognome;
        public string Cognome {
            get { 
                return _cognome; 
            }
            set { 
                _cognome = value; 
            }
        }

        //modalità java
        //private int _eta;

        //public int GetEta()
        //{
        //    return _eta;
        //}

        //public void SetEta(int value)
        //{
        //    _eta = value;
        //}
        public int Eta { get; set; }

        //bignorebbe definire che tipo di riscrittura utilizzare new o override
        public string ToString() 
        {
            return $"{Nome} {Cognome} {Eta}";
        }


    }
}
