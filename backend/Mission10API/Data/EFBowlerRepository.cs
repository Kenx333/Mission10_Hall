
using Microsoft.AspNetCore.Mvc;

namespace Mission10API.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private readonly BowlerContext _context;

        public EFBowlerRepository(BowlerContext context)
        {
            _context = context;
        }

        public IEnumerable<object> GetBowlersWithTeams()
        {
            //Linq to query data
            var query = from Bowlers in _context.Bowlers
                        join Teams in _context.Teams on Bowlers.TeamId equals Teams.TeamId
                        where Teams.TeamName == "Marlins" || Teams.TeamName == "Sharks"
                        select new
                        {
                            BowlerId = Bowlers.BowlerId,
                            BowlerFirstName = Bowlers.BowlerFirstName,
                            BowlerMiddleInit = Bowlers.BowlerMiddleInit,
                            BowlerLastName = Bowlers.BowlerLastName,
                            BowlerAddress = Bowlers.BowlerAddress,
                            BowlerCity = Bowlers.BowlerCity,
                            BowlerState = Bowlers.BowlerState,
                            BowlerZip = Bowlers.BowlerZip,
                            BowlerPhoneNumber = Bowlers.BowlerPhoneNumber,
                            TeamId = Teams.TeamId,
                            TeamName = Teams.TeamName,
                            CaptainId = Teams.CaptainId
                        };

            return query.ToList();
        }
    }

}
