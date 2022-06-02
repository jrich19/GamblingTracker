using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamblingTracker.ViewModels
{
    public class ActiveGamesListedItemViewModel : ViewModelBase
    {
        public string GameID { get; set; }
        //public string GameName { get; }
        //public ICommand RemoveGame { get; set; }
        //public ICommand GameOptions { get; }

        public ActiveGamesListedItemViewModel(string gameID)
        {
            GameID = gameID;
            //GameName = gameName;
        }
    }
}
