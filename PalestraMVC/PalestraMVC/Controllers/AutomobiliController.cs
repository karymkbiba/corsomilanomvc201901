using PalestraMVC.Interfaces;
using PalestraMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PalestraMVC.Controllers
{
    public class AutomobiliController : Controller
    {
        private readonly IGestioneAutomobili _gestione;

        // GET: Automobili
        public AutomobiliController(IGestioneAutomobili gestione)
        {
            _gestione = gestione;
        }
        public ActionResult Index(string Modello)
        {
            return View(_gestione.CaricaListaAutomobili());
        }
        public ActionResult Details(string id)
        {
            var Auto = _gestione.RestituisciAutomobilePerTarga(id);
            return View(Auto);
        }
        //private List<Automobile> CaricaAuto(string Modello) {

        //    return new List<Automobile> { new Automobile {Assicurata = true,
        //        DataAcquisto = DateTime.Today.AddDays(-2),
        //        PrezzoAcquisto = 21000,
        //        Proprietario = "Giorgio Vecchi",
        //        Targa = "EF324GJ",
        //        Modello = Modello,
        //        ClasseAmbientale = "Euro 4",
        //        NeoPatentati = false },
        //    new Automobile{Assicurata = false,
        //        DataAcquisto = DateTime.Today.AddDays(-2),
        //        PrezzoAcquisto = 60000,
        //        Proprietario = "Salvatore Sorrentino",
        //        Targa = "EG836FG",
        //        Modello = Modello,
        //        ClasseAmbientale = "Euro 5",
        //        NeoPatentati = false}};
        //}
        
    }
}