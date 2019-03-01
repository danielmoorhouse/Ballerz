using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Ballerz.Data.Models
{
    public class DataSeeder
    {
          public static async Task Initialize(ApplicationDbContext context,
                          UserManager<ApplicationUser> userManager,
                          RoleManager<ApplicationRole> roleManager)
    {
        context.Database.EnsureCreated();

         String adminId1 = "";
        

        string role1 = "Site Admin";
        string desc1 = "This is the site administrator role";

        string password = "P@$$w0rd";

          if (await roleManager.FindByNameAsync(role1) == null) {
            await roleManager.CreateAsync(new ApplicationRole(role1, desc1, DateTime.Now));
        }
        if (await userManager.FindByNameAsync("c") == null)
         {
            var user = new ApplicationUser 
            {
                UserName = "danielmoo",
                Email = "danmoo@mail.com",
                MemberSince = DateTime.Now
               
            
            };

            var result = await userManager.CreateAsync(user);
            if (result.Succeeded) {
                await userManager.AddPasswordAsync(user, password);
                await userManager.AddToRoleAsync(user, role1);
            }
            adminId1 = user.Id;
        }
         if (await userManager.FindByNameAsync("j") == null)
         {
            var user = new ApplicationUser 
            {
                UserName = "jimmyking",
                Email = "jking@mail.com",
                MemberSince = DateTime.Now
               
            
            };

            var result = await userManager.CreateAsync(user);
            if (result.Succeeded) {
                await userManager.AddPasswordAsync(user, password);
                await userManager.AddToRoleAsync(user, role1);
            }
            adminId1 = user.Id;
        }

    }
    }
}