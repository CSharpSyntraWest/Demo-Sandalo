using Demo_Sandalo.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Sandalo.Models
{
    public class Subcategorie: ObservableObject
	{
        public string Naam { get; set; }
        public string Beschrijving { get; set; }

        public Categorie Categorie { get; set; }
		public Subcategorie(string naam, string beschrijving, Categorie categorie)
		{
			Naam = naam;
			Beschrijving = beschrijving;
			Categorie = categorie;
		}

		public override string ToString()
		{
			return this.Naam;
			//return string.Format("{0}; {1}; {2}",
			//	this.Naam, this.Beschrijving, this.Categorie);
		}
	}
}
