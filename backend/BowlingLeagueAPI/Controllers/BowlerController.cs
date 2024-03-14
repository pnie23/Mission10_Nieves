using BowlingLeagueAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BowlingLeagueAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;
        public BowlerController(IBowlingRepository temp)
        {
            _bowlingRepository = temp;
        }

        [HttpGet]
        public IEnumerable<Bowler> GetBowlers()
        {
            var bowlerData = _bowlingRepository.Bowlers.ToArray();

            return bowlerData;
        }

        [HttpGet("/Team")]
        public IEnumerable<Team> GetTeams()
        {
            var teamData = _bowlingRepository.Teams.ToArray();

            return teamData;
        }
    }
}
