using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamblingTracker.Domain.Models
{
    public class Bet
    {
        public string League { get; set; }
        public string game { get; set; }
        public double odds { get; set; }
    }
}
