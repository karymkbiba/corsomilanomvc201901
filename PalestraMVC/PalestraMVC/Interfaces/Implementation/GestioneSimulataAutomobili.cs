using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PalestraMVC.Models;

namespace PalestraMVC.Interfaces.Implementation
{
    public class GestioneSimulataAutomobili : IGestioneAutomobili
    {
        public void AggiornaAutomobile(Automobile AutomobileModificata)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Automobile> CaricaListaAutomobili()
        {
            throw new NotImplementedException();
        }

        public void CreaNuovaAutomobile(Automobile NuovaAutomobile)
        {
            throw new NotImplementedException();
        }

        public void EliminaAutomobile(string Targa)
        {
            throw new NotImplementedException();
        }

        public Automobile RestituisciAutomobilePerTarga(string Targa)
        {
            throw new NotImplementedException();
        }
    }
}