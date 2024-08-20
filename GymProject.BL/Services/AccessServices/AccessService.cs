using GymProject.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymProject.BL.Services.AccessServices
{
    public class AccessService
    {
        private readonly IConfiguration _configuration;
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

        public AccessService(IConfiguration configuration, IDbContextFactory<ApplicationDbContext> dbContextFactory)
        {
            _configuration = configuration;
            _dbContextFactory = dbContextFactory;
        }

        public int Prova()
        {
            using var dbContext = _dbContextFactory.CreateDbContext();

            return dbContext.Users.Count();
        }
    }
}
