using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PokeOneWeb.Data.Entities;

namespace PokeOneWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {}

        public DbSet<Location> Locations { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<PokemonSpecies> PokemonSpecieses { get; set; }
        //public DbSet<Portal> Portals { get; set; }
        //public DbSet<FruitTree> FruitTrees { get; set; }
        //public DbSet<PokemonSpawnPoint> PokemonSpawnPoints { get; set; }
        //public DbSet<Npc> Npcs { get; set; }
        //public DbSet<HumanNpc> HumanNpcs { get; set; }
        //public DbSet<PokemonNpc> PokemonNpcs { get; set; }
        //public DbSet<Tutor> Tutors { get; set; }
        //public DbSet<Trainer> Trainers { get; set; }
        //public DbSet<BossTrainer> BossTrainers { get; set; }
        //public DbSet<StaticPokemon> StaticPokemon { get; set; }
        //public DbSet<BossPokemon> BossPokemon { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Setting foreign key constraints between regular entities and entities in the
            //LocationInteraction hierarchy to ON DELETE SET NULL to avoid Errors when
            //generating the model.
            modelBuilder.Entity<PlacedItem>()
                .HasOne(p => p.Item)
                .WithMany(i => i.PlacedItems)
                .HasForeignKey(p => p.PlacedItemId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FruitTree>()
                .HasOne(f => f.Fruit)
                .WithMany(i => i.FruitTrees)
                .HasForeignKey(f => f.FruitId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PokemonNpc>()
                .HasOne(n => n.PokemonSpecies)
                .WithMany(s => s.PokemonNpcs)
                .HasForeignKey(n => n.PokemonNpcSpeciesId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BossPokemon>()
                .HasOne(b => b.Pokemon)
                .WithMany() //EF Core can not specify one to zero-or-one relationships...
                .HasForeignKey(b => b.BossPokemonPokemonId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StaticPokemon>()
                .HasOne(s => s.Pokemon)
                .WithMany() //EF Core can not specify one to zero-or-one relationships...
                .HasForeignKey(s => s.StaticPokemonPokemonId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Tutor>()
                .HasOne(t => t.TaughtMove)
                .WithMany()
                .HasForeignKey(t => t.TutorTaughtMoveId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<LocationInteraction>()
                .HasOne(i => i.Location)
                .WithMany(l => l.LocationInteractions)
                .HasForeignKey(i => i.LocationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Portal>()
                .HasOne(p => p.Target)
                .WithMany()
                .HasForeignKey(p => p.TargetLocationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TrainerPokemon>()
                .HasOne(tp => tp.Trainer)
                .WithMany(t => t.TrainerPokemon)
                .HasForeignKey(tp => tp.TrainerId)
                .OnDelete(DeleteBehavior.Restrict);

            //Double-relation between ElementalType and ElementalTypeCombination can
            //only have one relationship set to ON DELETE CASCADE
            modelBuilder.Entity<ElementalTypeCombination>()
                .HasOne(c => c.PrimaryType)
                .WithMany()
                .HasForeignKey(c => c.PrimaryTypeId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<ElementalTypeCombination>()
                .HasOne(c => c.SecondaryType)
                .WithMany()
                .HasForeignKey(c => c.SecondaryTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            //Double-relation between PokemonTrade and PokemonSpecies can
            //only have one relationship set to ON DELETE CASCADE
            modelBuilder.Entity<PokemonTrade>()
                .HasOne(t => t.PokemonSpecies)
                .WithMany()
                .HasForeignKey(t => t.PokemonSpeciesId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<PokemonTrade>()
                .HasOne(t => t.TradeForSpecies)
                .WithMany()
                .HasForeignKey(t => t.TradeForSpeciesId)
                .OnDelete(DeleteBehavior.Restrict);

            //Distinction between PokemonTraded vs. PokemonToTradeAgainst
            modelBuilder.Entity<PokemonTrade>()
                .HasOne(x => x.PokemonSpecies)
                .WithMany(x => x.PokemonTrades);
        }
    }
}
