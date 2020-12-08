using Demo_Sandalo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_Sandalo.Services
{
    public class MockDataService : IDataService
    {
        private IList<Sandaal> _sandalen;
        private IList<Categorie> _categorieen;
        private IList<Subcategorie> _subcategorieen;
        public MockDataService()
        {
            InitLijsten();
        }
        private void InitLijsten()
        {
            InitCategorieen();
            InitSubCategorieen();
            InitSandalen();
        }
        private void InitSandalen()
        {
            _sandalen = new List<Sandaal>();
            _sandalen.Add(new Sandaal(1, "strandslipper", "teenslipper met dunne zool", "strandslipper.jpg", 12.5f, "zwart", _subcategorieen[0], "ook in wit en rood verkrijgbaar"));
            _sandalen.Add(new Sandaal(2, "partytime", "ideaal om mee te dansen", "partytime.jpg", 86.55f, "zwart", _subcategorieen[1], "glittert in het donker"));
            _sandalen.Add(new Sandaal(3, "Gladiator", "Romeinse sandaal", "gladiator.jpg", 50.5f, "lichtbruin", _subcategorieen[2], "niet in andere kleuren verkrijgbaar"));
            _sandalen.Add(new Sandaal(4, "Plateau", "jaren 60", "plateau.jpg", 150.0f, "rood", _subcategorieen[2], "enkel in blauw en rood verkrijgbaar"));
            _sandalen.Add(new Sandaal(5, "Zori", "Japanse sandaal", "zori.jpg", 1199.99f, "zwart", _subcategorieen[3], "enkel in zwart verkrijgbaar"));
        }
        private void InitSubCategorieen()
        {
            _subcategorieen = new List<Subcategorie>();
            _subcategorieen.Add(new Subcategorie("strand", "waterdicht en zoutbestendig", _categorieen[1]));
            _subcategorieen.Add(new Subcategorie("party", "....", _categorieen[1]));
            _subcategorieen.Add(new Subcategorie("retro", "uit de jaren stillekes", _categorieen[0]));
            _subcategorieen.Add(new Subcategorie("exclusief", "unieke design", _categorieen[0]));
        }
        private void InitCategorieen()
        {
            _categorieen = new List<Categorie>();
            _categorieen.Add(new Categorie("Business", "Voor werkomgeving"));
            _categorieen.Add(new Categorie("Casual", "Voor vrijetijd"));
        }

        public IList<Sandaal> GeefAlleSandalen()
        {
            return _sandalen;
        }

        public IList<Categorie> GeefAlleCategorieen()
        {
            return _categorieen;
        }
        public IList<Subcategorie> GeefAlleSubCategorieen()
        {
            return _subcategorieen;
        }

        public IList<Sandaal> VoegSandaalToe(Sandaal sandaal)
        {
            _sandalen.Add(sandaal);
            return _sandalen;
        }
        public IList<Sandaal> WijzigSandaal(Sandaal sandaal, Sandaal nieuweSandaal)
        {
            // _sandalen.Single(s => s.Id==nieuweSandaal.Id);later met SQL database: opzoeken op Id via Linq
            int indexSandaal = _sandalen.IndexOf(sandaal);
            if (indexSandaal >= 0) _sandalen[indexSandaal] = nieuweSandaal;
            return _sandalen;
        }
        public IList<Sandaal> VerwijderSandaal(Sandaal sandaal)
        {
            _sandalen.Remove(sandaal);
            return _sandalen;
        }
    }
}
