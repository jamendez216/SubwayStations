using SubwayStations.BusinessLogic.UserSubwayStationRepository;
using SubwayStations.Entities.Database;
using SubwayStations.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SubwayStations.Data.Database.Repositories
{
    public class UserSubwayStationRepository : IUserSubwayStationRepository
    {
        private readonly SubwayStationsDbContext dbContext;
        public UserSubwayStationRepository(SubwayStationsDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public Task AddUserSubwayStation(UserSubwayStation userSubwayStation)
        {
            throw new NotImplementedException();
        }
    }
}
