using Demo_Sandalo.Services;
using Demo_Sandalo.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Sandalo.ViewModels
{
    public class MainViewModel: ObservableObject
    {
        private IDataService _dataService;
        private SubCategorieViewModel _subCategorieVM;
        private CategorieViewModel _categorieVM;
        private SandalenViewModel _sandalenVM;
        public MainViewModel()
        {
            _dataService = new MockDataService();
            _subCategorieVM = new SubCategorieViewModel(_dataService);
            _categorieVM = new CategorieViewModel(_dataService);
            _sandalenVM = new SandalenViewModel(_dataService);
        }

        public SubCategorieViewModel SubCategorieVM {
            get { return _subCategorieVM; }
            
        }
        public CategorieViewModel CategorieVM 
        {
            get { return _categorieVM; }

        }
        public SandalenViewModel SandalenVM
        {
            get { return _sandalenVM; }

        }

    }
}
