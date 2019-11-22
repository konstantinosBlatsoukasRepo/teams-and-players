using System.Collections.Generic;
using TeamsAndPlayers.Models;

namespace TeamsAndPlayers.Data
{
    public interface IPlayerRepository
    {
        IEnumerable<Player> AllPlayers();

        Player GetPlayer(int playerId);

        void CreatePlayer(int playerId, string playerName, int teamId);

        void UpdatePlayerName(int playerId, string playerName);

        void DeletePlayer(int playerId, string playerName);
    }
}
