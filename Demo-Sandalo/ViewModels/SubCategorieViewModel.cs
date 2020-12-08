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

        public SubCategorieViewModel(IDataService dataservice)
        {
            _dataService = dataservice;
            _subcategorieen = new ObservableCollection<Subcategorie>(_dataService.GeefAlleSubCategorieen());
        }
        public ObservableCollection<Subcategorie> Subcategorieen
        {
            get { return _subcategorieen; }
            set { OnPropertyChanged(ref _subcategorieen, value); }
        }

    }
}
