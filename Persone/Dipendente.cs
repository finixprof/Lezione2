using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione2.Persone
{
    //una classe abstract non può essere istanziata
    //quindi deve essere ereditata altrimenti non ha senso crearla
    //quando viene eridatata, la derivata DEVE implementare i metodi astratti
    public abstract class Dipendente : Persona
    {
        public double Salario { get; set; }

        //abstract non posso implementare e DEVO implementare nelle derivate
        //se una prioprietà o metodo è abstract, la classe deve essere abstract
        public abstract void EsegueIlSuoLavoro();

        //con virtual posso implementare e POSSO fare l'override nelle derivate
        //public virtual void EsegueIlSuoLavoro()
        //{

        //}


    }
}
