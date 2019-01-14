using Microsoft.AspNetCore.Identity;
using VCDRent.Models;
using VCDRent.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace VCDRent.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            INetcoreService VCDRentService)
        {
            context.Database.EnsureCreated();

            //check for users
            if (context.ApplicationUser.Any())
            {
                await VCDRentService.CreateMenu();
                return; //if user is not empty, DB has been seed
            }

            //init app with super admin user
            await VCDRentService.CreateDefaultSuperAdmin();


        }
    }
}
