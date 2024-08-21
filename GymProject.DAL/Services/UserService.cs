using GymProject.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymProject.DAL.Services
{
    public class UserService
    {
        private readonly IConfiguration _configuration;
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

        public UserService(IConfiguration configuration, IDbContextFactory<ApplicationDbContext> dbContextFactory)
        {
            _configuration = configuration;
            _dbContextFactory = dbContextFactory;
        }

        private async Task SaveUserHeader(User user, ApplicationDbContext dbContext)
        {
            await dbContext.Users.AddAsync(user);
            await dbContext.SaveChangesAsync();
        }

        private async Task SaveUserDetails(UserDetails details, ApplicationDbContext dbContext)
        {
            await dbContext.UserDetails.AddAsync(details);
            await dbContext.SaveChangesAsync();
        }

        public async Task<bool> SaveUser(User user)
        {
            using var dbContext = _dbContextFactory.CreateDbContext();

            var transactions = dbContext.Database.BeginTransaction();

            await SaveUserHeader(user, dbContext);
            await SaveUserDetails(user.Details, dbContext);
         

            return true;
        }


    }
}
