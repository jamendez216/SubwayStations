using SubwayStations.BusinessLogic.User;
using SubwayStations.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SubwayStations.Entities.Database.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SubwayStationsDbContext dbContext;
        public UserRepository(SubwayStationsDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        
        public Task AddUserAsync(User user)
        {
            dbContext.Add(user);
            return dbContext.SaveChangesAsync();
        }

        public Task<bool> EMailExists(string email)
        {
            throw new NotImplementedException();
        }
    }
}
