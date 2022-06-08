using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamblingTracker.Domain.Models
{
    public class BetTransaction
    {
        public int Id { get; set; }
        public Account Account { get; set; }
        public bool IsBet { get; set; }

        public Bet bet { get; set; }

        public double Units { get; set; }

    }
}
