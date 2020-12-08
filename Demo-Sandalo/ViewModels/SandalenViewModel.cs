using Demo_Sandalo.Services;
using Demo_Sandalo.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Sandalo.ViewModels
{
    public class SandalenViewModel: ObservableObject
    {
        private IDataService _dataService;


        public SandalenViewModel(IDataService dataservice)
        {
            _dataService= dataservice;
        }
    }
}
