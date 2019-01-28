using PalestraMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalestraMVC.Interfaces
{
    public interface IGestioneAutomobili
    {
        IEnumerable<Automobile> CaricaListaAutomobili();
        Automobile RestituisciAutomobilePerTarga(string Targa);
        void CreaNuovaAutomobile(Automobile NuovaAutomobile);
        void EliminaAutomobile(string Targa);
        void AggiornaAutomobile(Automobile AutomobileModificata);
    }
}
