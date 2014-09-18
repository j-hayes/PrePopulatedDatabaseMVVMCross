using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirrious.MvvmCross.ViewModels;
using PrePopulatedDatabase.Core.Entities;
using PrePopulatedDatabase.Core.Services;

namespace PrePopulatedDatabase.Core.ViewModels
{
    public class BowTieDetailsViewModel :MvxViewModel
    {
        private IBowTieService _bowTieService;
        private BowTie _bowTie;

        public BowTie BowTie
        {
            get { return _bowTie; }
            set { _bowTie = value;RaisePropertyChanged(()=>BowTie); }
        }

        public BowTieDetailsViewModel(int id, IBowTieService bowTieService)
        {
            _bowTieService = bowTieService;
            BowTie = _bowTieService.Get(id);
        }
    }
}
