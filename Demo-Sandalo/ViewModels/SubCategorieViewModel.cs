using Demo_Sandalo.Models;
using Demo_Sandalo.Services;
using Demo_Sandalo.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Demo_Sandalo.ViewModels
{
    public class SubCategorieViewModel: ObservableObject
    {
        private IDataService _dataService;
        private ObservableCollection<Subcategorie> _subcategorieen;
        private Subcategorie _selectedSubcategorie;

        public SubCategorieViewModel(IDataService dataservice)
        {
            _dataService = dataservice;
            _subcategorieen = new ObservableCollection<Subcategorie>(_dataService.GeefAlleSubCategorieen());
            if (_subcategorieen.Count > 0) _selectedSubcategorie = _subcategorieen[0];
        }
        public Subcategorie SelectedSubcategorie
        {
            get { return _selectedSubcategorie; }
            set { OnPropertyChanged(ref _selectedSubcategorie, value); }
        }
        public ObservableCollection<Subcategorie> Subcategorieen
        {
            get { return _subcategorieen; }
            set { OnPropertyChanged(ref _subcategorieen, value); }
        }

    }
}
