using System;
using System.Collections.Generic;
using System.Linq;
using TeamsAndPlayers.Models;

namespace TeamsAndPlayers.Data
{
    public class MockTeamsRepository : ITeamsRepository
    {
        private IList<Team> _teams;
        private readonly IPlayerRepository _playerRepository;

        private const int OlympiacosId = 1;
        private const int RealId = 2;

        public MockTeamsRepository(IPlayerRepository playerRepository)
        {
            _teams = new List<Team>();
            _playerRepository = playerRepository;

            var olympiacosPlayers = _playerRepository.AllPlayers().Where(player => player.TeamId == OlympiacosId);
            var realMadridPlayers = _playerRepository.AllPlayers().Where(player => player.TeamId == RealId);

            var osfp = new Team() { Players = olympiacosPlayers, TeamId = OlympiacosId, TeamName = "Olympiacos" };
            var realMadrid = new Team() { Players = realMadridPlayers, TeamId = RealId, TeamName = "Real Madrid" };

            _teams.Add(osfp);
            _teams.Add(realMadrid);
        }


        public Team GetTeam(int teamId) => _teams.First(team => team.TeamId == teamId);

        public IEnumerable<Team> GetAllTeams() => _teams;

        public void CreateTeam(string name, IEnumerable<Player> players)
        {
            var newTeamId = _teams.Count - 1;
            var newTeam = new Team() { Players = players, TeamId = newTeamId, TeamName = name };
            _teams.Add(newTeam);
        }

        public void DeleteTeam(int teamId)
        {
            int index = _teams.IndexOf(GetTeam(teamId));
            _teams.RemoveAt(index);
        }
    }
}
