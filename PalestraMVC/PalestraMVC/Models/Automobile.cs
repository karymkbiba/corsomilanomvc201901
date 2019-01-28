using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PalestraMVC.Models
{
    public class Automobile
    {
        public string Targa { get; set; }
        public string Proprietario { get; set; }
        public DateTime DataAcquisto { get; set; }
        public bool Assicurata { get; set; }
        public int PrezzoAcquisto { get; set; }
        public string Modello { get; set; }
        public string ClasseAmbientale { get; set; }
        public bool NeoPatentati { get; set; }
    }
}