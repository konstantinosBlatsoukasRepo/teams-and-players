using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeamsAndPlayers.Data;
using TeamsAndPlayers.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TeamsAndPlayers.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamsRepository _teamsRepository;

        public TeamController(ITeamsRepository teamsRepository)
        {
            _teamsRepository = teamsRepository;
        }

        public IActionResult List()
        {
            var teamListViewModel = new TeamListViewModel();
            teamListViewModel.CurrentLeague = "Champions League";
            teamListViewModel.Teams = _teamsRepository.GetAllTeams();
            return View(teamListViewModel);
        }
    }
}
