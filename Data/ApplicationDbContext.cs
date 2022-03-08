using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HeroesApi.Models.IdentityModels;
using HeroesApi.Models.Heroes;

namespace HeroesApi.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<HeroSuitColor> HeroSuitColors { get; set; }
        public DbSet<HeroTraining> HeroTrainings { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override async void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Hero>()
                   .Property(h => h.StartingPower)
                   .HasPrecision(18, 2);

            builder.Entity<Hero>()
                  .Property(h => h.CurrentPower)
                  .HasPrecision(18, 2);

            builder.Entity<Hero>()
                 .HasIndex(h => h.Name)
                 .IsUnique();

            builder.Entity<HeroSuitColor>()
                .HasKey(suitColor => new { suitColor.HeroId, suitColor.ColorName });

            builder.Entity<HeroTraining>()
                .HasKey(heroTraining => new { heroTraining.HeroId, heroTraining.TrainedAt });

            DataSeed.SeedUsers(builder);
            DataSeed.SeedHeroes(builder);

            base.OnModelCreating(builder);
        }
    }
}
