using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamblingTracker.Domain.Models
{
    public class Account
    {
        public int Id { get; set; }
        public User AccountHolder { get; set; }

        public double Balance { get; set; }

        public IEnumerable<BetTransaction> BetTransactions { get; set; }

        


    }
}
