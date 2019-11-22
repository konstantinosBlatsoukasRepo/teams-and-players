using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamsAndPlayers.Models
{
    public class Player
    {
        public int PlayerId { get; set; }

        public string PlayerName { get; set; }

        public int TeamId { get; set; }
    }
}
