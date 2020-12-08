using Demo_Sandalo.Models;
using System.Collections.Generic;

namespace Demo_Sandalo.Services
{
    public interface IDataService
    {
        IList<Categorie> GeefAlleCategorieen();
        IList<Sandaal> GeefAlleSandalen();
        IList<Subcategorie> GeefAlleSubCategorieen();
        IList<Sandaal> VerwijderSandaal(Sandaal sandaal);
        IList<Sandaal> VoegSandaalToe(Sandaal nieuwesandaal);
        IList<Sandaal> WijzigSandaal(Sandaal sandaal, Sandaal nieuweSandaal);
    }
}