using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamsAndPlayers.Models;

namespace TeamsAndPlayers.ViewModels
{
    public class TeamListViewModel
    {
        public IEnumerable<Team> Teams { get; set; }
        public string CurrentLeague { get; set; }
    }
}
