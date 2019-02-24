using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PokeOneWeb.Data.Entities;

namespace PokeOneWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {}

        #region DbSets

        public DbSet<Event> Events { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<LocationGroup> LocationGroups { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<MapLocation> MapLocations { get; set; }
        public DbSet<LocationInteraction> LocationInteractions { get; set; }
        public DbSet<Portal> Portals { get; set; }
        public DbSet<FruitTree> FruitTrees { get; set; }
        public DbSet<FruitTreeType> FruitTreeTypes { get; set; }
        public DbSet<PlacedItem> PlacedItems { get; set; }
        public DbSet<Npc> Npcs { get; set; }
        public DbSet<PokemonSpawnPoint> PokemonSpawnPoints { get; set; }
        public DbSet<PokemonSpawnPointType> PokemonSpawnPointTypes { get; set; }
        public DbSet<HumanNpc> HumanNpcs { get; set; }
        public DbSet<FunctionalNpc> FunctionalNpcs { get; set; }
        public DbSet<FunctionalNpcType> FunctionalNpcTypes { get; set; }
        public DbSet<MoveTutor> MoveTutors { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<TrainerType> TrainerTypes { get; set; }
        public DbSet<PokemonNpc> PokemonNpcs { get; set; }
        public DbSet<PokemonNpcType> PokemonNpcTypes { get; set; }
        public DbSet<BossPokemon> BossPokemon { get; set; }
        public DbSet<Quest> Quests { get; set; }
        public DbSet<QuestItemReward> QuestItemRewards { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemGift> ItemGifts { get; set; }
        public DbSet<BagCategory> BagCategories { get; set; }
        public DbSet<GloballyObtainableItem> GloballyObtainableItems { get; set; }
        public DbSet<ItemObtainMethod> ItemObtainMethods { get; set; }
        public DbSet<TrainerDropItem> TrainerDropItems { get; set; }
        public DbSet<PokemonDropItem> PokemonDropItems { get; set; }
        public DbSet<PokemonSpeciesVarietyDropItem> PokemonSpeciesVarietyDropItems { get; set; }
        public DbSet<MoveTutorMove> MoveTutorMoves { get; set; }
        public DbSet<TrainerPokemon> TrainerPokemon { get; set; }
        public DbSet<PokemonSpecies> PokemonSpecies { get; set; }
        public DbSet<PokemonSpeciesVariety> PokemonSpeciesVarieties { get; set; }
        public DbSet<PokemonSpeciesVarietyForm> PokemonSpeciesVarietyForms { get; set; }
        public DbSet<Stats> Stats { get; set; }
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<LearnableMove> LearnableMoves { get; set; }
        public DbSet<Move> Moves { get; set; }
        public DbSet<Pokemon> Pokemon { get; set; }
        public DbSet<PokemonMove> PokemonMoves { get; set; }
        public DbSet<ElementalType> ElementalTypes { get; set; }
        public DbSet<ElementalTypeCombination> ElementalTypeCombinations { get; set; }
        public DbSet<ElementalTypeDamageRelation> ElementalTypeDamageRelations { get; set; }
        public DbSet<PokemonSpawn> PokemonSpawns { get; set; }
        public DbSet<TimeOfDay> TimeOfDays { get; set; }
        public DbSet<PokemonSpawnTimeOfDay> PokemonSpawnTimeOfDays { get; set; }
        public DbSet<SpawnRarity> SpawnRarities { get; set; }
        public DbSet<PokemonGift> PokemonGifts { get; set; }
        public DbSet<PokemonTrade> PokemonTrades { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Make LocationGroup names unique and indexable (--> used to generate page URLs)
            modelBuilder.Entity<LocationGroup>()
                .HasIndex(x => x.Name)
                .IsUnique();

            //Declare PokedexNumber as unique and indexable
            modelBuilder.Entity<PokemonSpecies>()
                .HasIndex(x => x.PokedexNumber)
                .IsUnique();

            //Setting foreign key constraints between regular entities and entities in the
            //LocationInteraction hierarchy to ON DELETE NO ACTION to avoid Errors when
            //generating the model.
            modelBuilder.Entity<LocationInteraction>()
                .HasOne(x => x.Location)
                .WithMany(x => x.LocationInteractions)
                .HasForeignKey(x => x.LocationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Portal>()
                .HasOne(x => x.TargetLocation)
                .WithMany()
                .HasForeignKey(x => x.TargetLocationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FruitTree>()
                .HasOne(x => x.FruitItem)
                .WithMany(x => x.FruitTrees)
                .HasForeignKey(x => x.FruitItemId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<FruitTree>()
                .HasOne(x => x.FruitTreeType)
                .WithMany(x => x.FruitTrees)
                .HasForeignKey(x => x.FruitTreeTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PlacedItem>()
                .HasOne(x => x.Item)
                .WithMany(x => x.PlacedItems)
                .HasForeignKey(x => x.ItemId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PokemonSpawnPoint>()
                .HasOne(x => x.PokemonSpawnPointType)
                .WithMany(x => x.PokemonSpawnPoints)
                .HasForeignKey(x => x.PokemonSpawnPointTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PokemonNpc>()
                .HasOne(x => x.Pokemon)
                .WithOne(x => x.PokemonNpc) //1:[0..1] relationship
                .HasForeignKey<PokemonNpc>(x => x.PokemonId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<PokemonNpc>()
                .HasOne(x => x.PokemonNpcType)
                .WithMany(x => x.PokemonNpcs)
                .HasForeignKey(x => x.PokemonNpcTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FunctionalNpc>()
                .HasOne(x => x.FunctionalNpcType)
                .WithMany(x => x.FunctionalNpcs)
                .HasForeignKey(x => x.FunctionalNpcTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Trainer>()
                .HasOne(x => x.TrainerType)
                .WithMany(x => x.Trainers)
                .HasForeignKey(x => x.TrainerTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            //Set double-relations two ON DELETE NO ACTION to avoid multiple cascade paths
            modelBuilder.Entity<ElementalTypeDamageRelation>()
                .HasOne(x => x.AttackingType)
                .WithMany(x => x.AttackDamageRelations)
                .HasForeignKey(x => x.AttackingTypeId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ElementalTypeDamageRelation>()
                .HasOne(x => x.DefendingType)
                .WithMany(x => x.DefenseDamageRelations)
                .HasForeignKey(x => x.DefendingTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ElementalTypeCombination>()
                .HasOne(x => x.PrimaryType)
                .WithMany()
                .HasForeignKey(x => x.PrimaryTypeId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ElementalTypeCombination>()
                .HasOne(x => x.SecondaryType)
                .WithMany()
                .HasForeignKey(x => x.SecondaryTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PokemonSpeciesVariety>()
                .HasOne(x => x.BaseStats)
                .WithMany()
                .HasForeignKey(x => x.BaseStatsId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<PokemonSpeciesVariety>()
                .HasOne(x => x.EvYield)
                .WithMany()
                .HasForeignKey(x => x.EvYieldId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PokemonSpeciesVariety>()
                .HasOne(x => x.PrimaryAbility)
                .WithMany(x => x.PokemonSpeciesVarietiesAsPrimaryAbility)
                .HasForeignKey(x => x.PrimaryAbilityId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<PokemonSpeciesVariety>()
                .HasOne(x => x.SecondaryAbility)
                .WithMany(x => x.PokemonSpeciesVarietiesAsSecondaryAbility)
                .HasForeignKey(x => x.SecondaryAbilityId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<PokemonSpeciesVariety>()
                .HasOne(x => x.HiddenAbility)
                .WithMany(x => x.PokemonSpeciesVarietiesAsHiddenAbility)
                .HasForeignKey(x => x.HiddenAbilityId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PokemonTrade>()
                .HasOne(x => x.PokemonSpeciesVariety)
                .WithMany(x => x.PokemonTrades)
                .HasForeignKey(x => x.PokemonSpeciesVarietyId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<PokemonTrade>()
                .HasOne(x => x.TradeForSpeciesVariety)
                .WithMany()
                .HasForeignKey(x => x.TradeForSpeciesId)
                .OnDelete(DeleteBehavior.Restrict);

            //Cyclic relation between PokemonSpecies and PokemonSpeciesVariety
            modelBuilder.Entity<PokemonSpeciesVariety>()
                .HasOne(x => x.PokemonSpecies)
                .WithMany(x => x.Varieties)
                .HasForeignKey(x => x.PokemonSpeciesId)
                .OnDelete(DeleteBehavior.Restrict);

            //Cyclic relation between PokemonSpeciesVariety and PokemonSpeciesVarietyForm
            modelBuilder.Entity<PokemonSpeciesVarietyForm>()
                .HasOne(x => x.PokemonSpeciesVariety)
                .WithMany(x => x.Forms)
                .HasForeignKey(x => x.PokemonSpeciesVarietyId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
