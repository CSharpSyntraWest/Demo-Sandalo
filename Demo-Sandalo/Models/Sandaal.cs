using Demo_Sandalo.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Sandalo.Models
{
    public class Sandaal: ObservableObject
	{
		public int Id { get; set; }
		public string Naam { get; set; }
		public string Beschrijving { get; set; }
		public string Afbeelding { get; set; }
		public float Prijs { get; set; }
		public string Kleur { get; set; }
		public Subcategorie Subcategorie { get; set; }
		public string Commentaar { get; set; }
		public Sandaal(int id, string naam, string beschrijving, string afbeelding, float prijs, string kleur, Subcategorie subcategorie, string commentaar)
		{
			Id = id;
			Naam = naam;
			Beschrijving = beschrijving;
			Afbeelding = afbeelding;
			Prijs = prijs;
			Kleur = kleur;
			Subcategorie = subcategorie;
			Commentaar = commentaar;
		}



		public override string ToString()
		{
			return string.Format("{0}; {1}; {2}; {3}; {4}; {5}; {6}",
				this.Naam, this.Beschrijving, this.Afbeelding, this.Prijs, this.Kleur, this.Subcategorie, this.Commentaar);
		}
	}
}
