﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

using UserManagementDemo.Domain.Enums.Account;
using UserManagementDemo.Domain.Models.Entities;

namespace UserManagementDemo.Persistence.Seeding
{
    public static class DefaultRoles
    {
        public static async Task SeedAsync(
            UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(UserRoles.RegularUser.ToString()));
            await roleManager.CreateAsync(new IdentityRole(UserRoles.AccountUser.ToString()));
            await roleManager.CreateAsync(new IdentityRole(UserRoles.Administrator.ToString()));
        }
    }
}
