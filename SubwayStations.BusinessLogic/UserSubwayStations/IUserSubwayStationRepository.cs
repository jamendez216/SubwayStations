using SubwayStations.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SubwayStations.BusinessLogic.UserSubwayStationRepository
{
    public interface IUserSubwayStationRepository
    {
        public Task AddUserSubwayStation(UserSubwayStation userSubwayStation);
    }
}
