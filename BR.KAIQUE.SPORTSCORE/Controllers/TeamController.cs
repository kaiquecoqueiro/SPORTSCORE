using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BR.KAIQUE.SPORTSCORE.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BR.KAIQUE.SPORTSCORE.Controllers
{
    public class TeamController : Controller
    {
        ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public IActionResult Index()
        {
            var teams = _teamService.GetTeams();

            return View(teams);
        }
    }
}