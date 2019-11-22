using System.Collections.Generic;
using TeamsAndPlayers.Models;

namespace TeamsAndPlayers.Data
{
    public interface ITeamsRepository
    {
        Team GetTeam(int teamId);

        IEnumerable<Team> GetAllTeams();

        void CreateTeam(string name, IEnumerable<Player> players);

        void DeleteTeam(int teamId);
    }
}
