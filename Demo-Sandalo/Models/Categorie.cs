using Demo_Sandalo.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Sandalo.Models
{
    public class Categorie:ObservableObject
    {
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        public Categorie(string naam, string beschrijving)
        {
            Naam = naam;
            Beschrijving = beschrijving;
        }
    }
}
