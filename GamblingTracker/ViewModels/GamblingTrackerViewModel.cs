using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GamblingTracker.ViewModels
{
    public class GamblingTrackerViewModel : ViewModelBase
    {
        
        public ActiveGamesViewModel ActiveGamesViewModel { get; }
        public ActiveGameLinesViewModel ActiveGameItemsViewModel { get; }
     
        public ICommand UpdateActiveGamesCommand { get; }

        public GamblingTrackerViewModel()
        {
            ActiveGamesViewModel = new ActiveGamesViewModel();
            ActiveGameItemsViewModel = new ActiveGameLinesViewModel();
        }
    }
}
