using Demo_Sandalo.Models;
using Demo_Sandalo.Services;
using Demo_Sandalo.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Demo_Sandalo.ViewModels
{
    public class CategorieViewModel: ObservableObject
    {
        private IDataService _dataService;
        private ObservableCollection<Categorie> _categorieen;
        private Categorie _selectedCategorie;
        public CategorieViewModel(IDataService dataservice)
        {
            _dataService = dataservice;
            _categorieen = new ObservableCollection<Categorie>(_dataService.GeefAlleCategorieen());
            if (_categorieen.Count > 0) SelectedCategorie = _categorieen[0];
        }
        public Categorie SelectedCategorie
        {
            get { return _selectedCategorie; }
            set { OnPropertyChanged(ref _selectedCategorie, value); }
        }
        public ObservableCollection<Categorie> Categorieen
        {
            get{ return _categorieen; }
            set { OnPropertyChanged(ref _categorieen, value); }
        }
    }
}
