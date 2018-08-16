using BR.KAIQUE.SPORTSCORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BR.KAIQUE.SPORTSCORE.Services
{
    public interface ITeamService
    {
        List<Team> GetTeams();
    }
}
