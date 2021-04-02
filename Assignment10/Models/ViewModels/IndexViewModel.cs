using System;
using System.Collections.Generic;

namespace Assignment10.Models.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Bowler> Bowlers { get; set; }

        public PageNumberingInfo PageNumberingInfo { get; set; }

        public string BowlingTeam { get; set; }
    }
}

