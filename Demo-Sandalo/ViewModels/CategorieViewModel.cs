using Demo_Sandalo.Services;
using Demo_Sandalo.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Sandalo.ViewModels
{
    public class CategorieViewModel: ObservableObject
    {
        private IDataService _dataService;
       

        public CategorieViewModel(IDataService dataservice)
        {
            _dataService = dataservice;
        }

    }
}
