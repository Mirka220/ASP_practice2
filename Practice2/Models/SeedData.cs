using Microsoft.EntityFrameworkCore;

namespace Practice2.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDBContext(serviceProvider.GetRequiredService<DbContextOptions<AppDBContext>>()))
            {
                if(context.SpongeBobFriends.Any() && context.Homes.Any())
                {
                    return;
                }
                context.SpongeBobFriends.AddRange(
                    new SpongeBobFriends
                    {
                        FirstName = "Patrik",
                        LastName = "Star",
                        Job = "None",
                        JobPlace = "Home",
                        SkinCollor = "Pink",
                        HomeId = new Home
                        {
                            HomeType = "Stone",
                            IsNeighbour = true
                        }
                    },
                    new SpongeBobFriends
                    {
                        FirstName = "Garry",
                        LastName = "Snail",
                        Job= "None",
                        JobPlace= "None",
                        SkinCollor = "Pink and Green",
                        HomeId = new Home
                        {
                            HomeType = "Pineapple",
                            IsNeighbour = true
                        }
                    },
                    new SpongeBobFriends
                    {
                        FirstName = "Mister",
                        LastName = "Krabs",
                        Job = "Counting money",
                        JobPlace = "Krasty Krab",
                        SkinCollor = "Red",
                        HomeId = new Home
                        {
                            HomeType = "Anchor",
                            IsNeighbour = false
                        }
                    });

                context.SaveChanges();
            }

        }

    }
}
