using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission10API.Data;

namespace Mission10API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BowlersController : ControllerBase
    {
        private readonly IBowlerRepository _bowlerRepository;

        public BowlersController(IBowlerRepository bowlerRepository)
        {
            _bowlerRepository = bowlerRepository;
        }

        [HttpGet]
        public IEnumerable<object> GetBowlersWithTeams()
        {
            return _bowlerRepository.GetBowlersWithTeams();
        }
    }

}
