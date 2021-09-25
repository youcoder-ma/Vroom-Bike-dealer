using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vroom.Helpers;
using Vroom.Models;

namespace Vroom.Data
{
    public class DbInitializer : IDbInitializer
    {
        private readonly VroomDbContext _vroomDbContext;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public DbInitializer(VroomDbContext vroomDbContext, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _vroomDbContext = vroomDbContext;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async void Initialize()
        {
            //Add Pending Migration if exist
            if (_vroomDbContext.Database.GetPendingMigrations().Count() > 0)
            {
                _vroomDbContext.Database.Migrate();
            }

            //Create Admin Role
            if (_vroomDbContext.Roles.Any(r => r.Name == Helpers.Roles.Admin)) return;
            _roleManager.CreateAsync(new IdentityRole(Roles.Admin)).GetAwaiter().GetResult();

            //Create Admin User
            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "Admin",
                Email = "Admin@gmail.com",
                EmailConfirmed = true,
            },"Admin@123").GetAwaiter().GetResult();

            //Assign role to Admin User
            await _userManager.AddToRoleAsync(await _userManager.FindByNameAsync("Admin"), Roles.Admin);

        }
    }
}
