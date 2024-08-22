using GymProject.BL.Models;
using GymProject.BL.Models.AccessModels;
using GymProject.DAL;
using GymProject.DAL.Services;
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
        private UserService _userService;

        public AccessService(IConfiguration configuration,
                            IDbContextFactory<ApplicationDbContext> dbContextFactory, 
                            UserService userService)
        {
            _configuration = configuration;
            _dbContextFactory = dbContextFactory;
            _userService = userService;
        }

        public async Task<bool> SignIn(SignInModel signInModel)
        {
            var userEntity = user.ToEntity();
            return await _userService.SaveUser(userEntity);
        }

        public int Prova()
        {
            using var dbContext = _dbContextFactory.CreateDbContext();

            return dbContext.Users.Count();
        }
    }
}
