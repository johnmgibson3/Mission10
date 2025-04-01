using backend.Data;
using Microsoft.AspNetCore.Mvc;


namespace backend.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class BowlingController : ControllerBase
    {

        private BowlingDbContext _bowlingContext;

        public BowlingController(BowlingDbContext temp)
        {
            _bowlingContext = temp;
        }
        
        [HttpGet(Name = "GetBowling")]
        // iterates
        public IEnumerable<Bowlers> Get()
        {
            var bowlersList = _bowlingContext.Bowlers.ToList();
            
            return (bowlersList);
        }
    }
}