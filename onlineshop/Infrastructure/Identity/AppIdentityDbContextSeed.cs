using Core.Entities.Identity;
using Infrastructure.Data.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "James",
                    Email = "james@test.com",
                    UserName = "james@test.com",
                    Address = new Address
                    {
                        FirstName = "James",
                        LastName = "Jam",
                        street = "karen avenue",
                        city = "Singapore",
                        state = "SG",
                        zipcode = "650909" 
                    }
                };

                await userManager.CreateAsync(user,"@Tchu127");
            }
        }

        
    }
}
