using System.Collections.Generic;
using System.Linq;
using TeamsAndPlayers.Models;

namespace TeamsAndPlayers.Data
{
    public class MockPlayerRepository : IPlayerRepository
    {
        private IList<Player> _players;

        public MockPlayerRepository()
        {

            _players = new List<Player>();
            var giovanni = new Player {PlayerId = 1, PlayerName = "Giovanni Silva De Oliveira", TeamId = 1};
            var galletti = new Player { PlayerId = 2, PlayerName = "Luciano Galletti", TeamId = 1 };
            var benzema = new Player { PlayerId = 3, PlayerName = "Karim Benzema", TeamId = 2 };
            var ramos = new Player { PlayerId = 4, PlayerName = "Sergio Ramos", TeamId = 2 };
            var sudani = new Player { PlayerId = 5, PlayerName = "Hillal Soudani", TeamId = 2 };

            _players.Add(giovanni);
            _players.Add(galletti);
            _players.Add(benzema);
            _players.Add(ramos);
            _players.Add(sudani);
        }

        public IEnumerable<Player> AllPlayers() => _players;

        public Player GetPlayer(int playerId) => _players.First(player => player.PlayerId == playerId);

        public void CreatePlayer(int playerId, string playerName, int teamId)
        {
            var newPlayer = new Player {PlayerId = playerId, PlayerName = playerName, TeamId = teamId};
            _players.Add(newPlayer);
        }

        public void UpdatePlayerName(int playerId, string playerName)
        {
            var player = GetPlayer(playerId);
            player.PlayerName = playerName;
        }

        public void DeletePlayer(int playerId, string playerName)
        {
            int index = _players.IndexOf(GetPlayer(playerId));
            _players.RemoveAt(index);
        }
    }

}
