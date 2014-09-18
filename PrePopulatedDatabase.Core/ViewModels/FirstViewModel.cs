using System.Collections.Generic;
using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;
using PrePopulatedDatabase.Core.Entities;
using PrePopulatedDatabase.Core.Services;

namespace PrePopulatedDatabase.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private readonly IBowTieService _bowTieService;

        private List<BowTie> _bowTies;
        public List<BowTie> BowTies

        {
            get { return _bowTies; }
            set
            {
                _bowTies = value;
                RaisePropertyChanged(() => BowTies);
            }
        }

        public FirstViewModel(IBowTieService bowTieService)
        {
            _bowTieService = bowTieService;
        }



        private Cirrious.MvvmCross.ViewModels.MvxCommand _getBowTiesCommand;
        public ICommand GetBowtiesCommand
        {
            get
            {
                _getBowTiesCommand = _getBowTiesCommand ?? new Cirrious.MvvmCross.ViewModels.MvxCommand(getBowTies);
                return _getBowTiesCommand;
            }
        }

   

        public BowTie SelectedBowTie
        {
            get { return new BowTie(); }
            set
            {
                ShowViewModel<BowTieDetailsViewModel>(value.ID);
            }
        }

        private void getBowTies()
        {
            BowTies = _bowTieService.GetAll();
        }
    }
}
