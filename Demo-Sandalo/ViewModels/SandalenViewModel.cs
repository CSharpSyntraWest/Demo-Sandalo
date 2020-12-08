using Demo_Sandalo.Models;
using Demo_Sandalo.Services;
using Demo_Sandalo.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Demo_Sandalo.ViewModels
{
    public class SandalenViewModel: ObservableObject
    {
        private IDataService _dataService;
        private ObservableCollection<Sandaal> _sandalen;
        private Sandaal _selectedSandaal;
        public SandalenViewModel(IDataService dataservice)
        {
            _dataService= dataservice;
            _sandalen = new ObservableCollection<Sandaal>(_dataService.GeefAlleSandalen());
            if (_sandalen.Count > 0) SelectedSandaal = _sandalen[0];
        }
        public Sandaal SelectedSandaal 
        {
            get { return _selectedSandaal; }
            set { OnPropertyChanged(ref _selectedSandaal, value); }
        }
        public ObservableCollection<Sandaal> Sandalen
        {
            get { return _sandalen; }
            set { OnPropertyChanged(ref _sandalen, value); }
        }

    }
}
