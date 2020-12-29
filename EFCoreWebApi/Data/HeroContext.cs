using EFCoreWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreWebApi.Data
{
    public class HeroContext : DbContext
    {
        public DbSet<Hero> Heroes { get; set; }

        public DbSet<Battle> Battles { get; set; }

        public DbSet<Weapon> Weapons { get; set; }

        public DbSet<BattleHero> BattleHeroes { get; set; }

        public DbSet<SecretIdentity> SecretIdentities{ get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security = SSPI; Persist Security Info=False;User ID = ruan; Initial Catalog = heroapp; Data Source = RUAN\\SQLEXPRESS");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BattleHero>(entity =>
            {
                entity.HasKey(e => new { e.BattleId, e.HeroId });
            });
        }

    }
}
