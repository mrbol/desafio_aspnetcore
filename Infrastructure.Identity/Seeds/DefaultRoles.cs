﻿using Infrastructure.Identity.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Application.Enums;

namespace Infrastructure.Identity.Seeds
{
    public static class DefaultRoles
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new ApplicationRole() { Name=Roles.SuperAdmin.ToString() });
            await roleManager.CreateAsync(new ApplicationRole() { Name= Roles.Admin.ToString() });
            await roleManager.CreateAsync(new ApplicationRole() { Name= Roles.Moderator.ToString() });
            await roleManager.CreateAsync(new ApplicationRole() { Name= Roles.Basic.ToString() });
        }
    }
}
