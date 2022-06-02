using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamblingTracker.ViewModels
{
    public class ActiveGamesViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ActiveGamesListedItemViewModel> _activeGamesListedItemViewModels;
        public IEnumerable<ActiveGamesListedItemViewModel> ActiveGamesListedItem => _activeGamesListedItemViewModels;

        public ActiveGamesViewModel()
        {
            _activeGamesListedItemViewModels = new ObservableCollection<ActiveGamesListedItemViewModel>();
            _activeGamesListedItemViewModels.Add(new ActiveGamesListedItemViewModel("Game 1"));
            _activeGamesListedItemViewModels.Add(new ActiveGamesListedItemViewModel("Game 2"));
            _activeGamesListedItemViewModels.Add(new ActiveGamesListedItemViewModel("Game 3"));


        }
    }
}
