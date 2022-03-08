using HeroesApi.Models.Heroes;
using HeroesApi.Models.IdentityModels;
using HeroesApi.Utilities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HeroesApi.Data
{
    public static class DataSeed
    {
        private static List<ApplicationUser> _users;
        private static List<string> _heroNames;
        private static List<string> _colors;
        private static List<string> _abilities;

        static DataSeed()
        {
            _users = new List<ApplicationUser>()
            {
                new ApplicationUser()
                {
                    Id = Guid.NewGuid().ToString(),
                    Email= "user1@example.com",
                    UserName = "user1@example.com",
                    FirstName = "Moshe",
                    LastName = "Cohen"
                },
                new ApplicationUser()
                {
                    Id = Guid.NewGuid().ToString(),
                    Email= "user2@example.com",
                    UserName = "user2@example.com",
                    FirstName = "Keren",
                    LastName = "David"
                },
                new ApplicationUser()
                {
                    Id = Guid.NewGuid().ToString(),
                    Email= "user3@example.com",
                    UserName= "user3@example.com",
                    FirstName = "Sholomo",
                    LastName = "Daniel"
                }
            };

            _heroNames = new List<string>();
            _heroNames.AddRange(new string[]
            {
                "Dr. Strange", "Deadpool", "Thanos", "Iron-Man", "Captain America", "Thor", "Black Widow",
                "Scarlet Witch", "Captain Marvel", "Pheonix", "Spider-Man", "The Punisher", "The Hulk",
                "Wolverine", "Ant-Man", "Black Panther", "Venom", "Star Lord", "Super-Man", "Bat-Man",
                "The Joker", "Bane", "Wonder Woman", "Adam Warlock", "Loki", "Hela", "She-Hulk", "Dr. Doom",
                "Bat-Girl", "Super-Girl"
            });

            _colors = new List<string>();
            _colors.AddRange(new string[]
            { "White", "Black", "Yellow", "Green", "Blue", "Purple", "Red", "Gold", "Brown", "Orange", "Silver", "Pink",});

            _abilities = new List<string>();
            _abilities.AddRange(new string[] { "Attacker", "Defender" });
        }
        public static void SeedUsers(ModelBuilder builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            _users.ForEach(user =>
            {
                user.NormalizedUserName = user.UserName.ToUpper();
                user.NormalizedEmail = user.Email.ToUpper();
                user.LockoutEnabled = true;
                user.PasswordHash = hasher.HashPassword(user, "Aa12345!");
            });

            builder.Entity<ApplicationUser>().HasData(_users);
        }

        public static void SeedHeroes(ModelBuilder builder)
        {
            List<Hero> heroes = new List<Hero>();
            List<HeroSuitColor> suitColorsList = new List<HeroSuitColor>();

            _heroNames.ForEach(name =>
            {
                var userId = heroes.Count switch
                {
                    < 10 => _users[0].Id,
                    < 20 => _users[1].Id,
                    _ => _users[2].Id,
                };

                var heroId = Guid.NewGuid();
                var power = Utils.GetRandomNumberInRange(30, 50);
                var ability = _abilities[Utils.GetRandomNumberInRange(0, _abilities.Count - 1)];

                var firstColor = _colors[Utils.GetRandomNumberInRange(0, _colors.Count - 1)];
                var secondColor = "";

                while (firstColor == secondColor || secondColor == "")
                    secondColor = _colors[Utils.GetRandomNumberInRange(0, _colors.Count - 1)];

                var suitColors = new HeroSuitColor[]
                {
                    new HeroSuitColor
                    {
                        ColorName = firstColor,
                        HeroId = heroId
                    },
                    new HeroSuitColor
                    {
                        ColorName= secondColor,
                        HeroId=heroId,
                    }
                };

                suitColorsList.AddRange(suitColors);

                heroes.Add(new Hero
                {
                    Id = heroId,
                    Name = name,
                    ApplicationUserId = userId,
                    StartingPower = power,
                    CurrentPower = power,
                    Ability = ability,
                    StartedTrainingAt = DateTime.UtcNow
                });
            });

            builder.Entity<HeroSuitColor>().HasData(suitColorsList);
            builder.Entity<Hero>().HasData(heroes);
        }
    }
}
