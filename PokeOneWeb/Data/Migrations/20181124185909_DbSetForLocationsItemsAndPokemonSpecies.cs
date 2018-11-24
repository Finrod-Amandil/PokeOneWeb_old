using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PokeOneWeb.Data.Migrations
{
    public partial class DbSetForLocationsItemsAndPokemonSpecies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coordinates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    X = table.Column<int>(nullable: false),
                    Y = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordinates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ElementalType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementalType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EvYield",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Attack = table.Column<int>(nullable: false),
                    Defense = table.Column<int>(nullable: false),
                    SpecialAttack = table.Column<int>(nullable: false),
                    SpecialDefense = table.Column<int>(nullable: false),
                    Speed = table.Column<int>(nullable: false),
                    HealthPoints = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvYield", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Move",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Move", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimeOfDay",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Start = table.Column<DateTime>(nullable: false),
                    Finish = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeOfDay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ElementalTypeCombination",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PrimaryTypeId = table.Column<int>(nullable: false),
                    SecondaryTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementalTypeCombination", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElementalTypeCombination_ElementalType_PrimaryTypeId",
                        column: x => x.PrimaryTypeId,
                        principalTable: "ElementalType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElementalTypeCombination_ElementalType_SecondaryTypeId",
                        column: x => x.SecondaryTypeId,
                        principalTable: "ElementalType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    IsAccessible = table.Column<bool>(nullable: false),
                    RegionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Region_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Region",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonSpecieses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ElementalTypeCombinationId = table.Column<int>(nullable: false),
                    EvYieldId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonSpecieses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonSpecieses_ElementalTypeCombination_ElementalTypeCombinationId",
                        column: x => x.ElementalTypeCombinationId,
                        principalTable: "ElementalTypeCombination",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonSpecieses_EvYield_EvYieldId",
                        column: x => x.EvYieldId,
                        principalTable: "EvYield",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pokemon",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Level = table.Column<int>(nullable: false),
                    PokemonSpeciesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pokemon_PokemonSpecieses_PokemonSpeciesId",
                        column: x => x.PokemonSpeciesId,
                        principalTable: "PokemonSpecieses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonSpeciesDropItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PokemonSpeciesId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonSpeciesDropItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonSpeciesDropItem_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonSpeciesDropItem_PokemonSpecieses_PokemonSpeciesId",
                        column: x => x.PokemonSpeciesId,
                        principalTable: "PokemonSpecieses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocationInteraction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlacementDescription = table.Column<string>(nullable: true),
                    LocationId = table.Column<int>(nullable: false),
                    CoordinatesId = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    FruitTree_FruitId = table.Column<int>(nullable: true),
                    HumanNpc_Name = table.Column<string>(nullable: true),
                    Trainer_TrainerType = table.Column<int>(nullable: true),
                    Trainer_ExperienceReward = table.Column<int>(nullable: true),
                    Trainer_MoneyReward = table.Column<int>(nullable: true),
                    BossTrainer_StartLevel = table.Column<int>(nullable: true),
                    Tutor_TutorType = table.Column<int>(nullable: true),
                    Tutor_TaughtMoveId = table.Column<int>(nullable: true),
                    PokemonNpc_PokemonSpeciesId = table.Column<int>(nullable: true),
                    BossPokemon_PokemonId = table.Column<int>(nullable: true),
                    BossPokemon_StartLevel = table.Column<int>(nullable: true),
                    StaticPokemon_PokemonId = table.Column<int>(nullable: true),
                    PlacedItem_ItemId = table.Column<int>(nullable: true),
                    PlacedItem_IsHidden = table.Column<bool>(nullable: true),
                    PokemonSpawnPoint_Type = table.Column<int>(nullable: true),
                    Portal_TargetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationInteraction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationInteraction_Pokemon_BossPokemon_PokemonId",
                        column: x => x.BossPokemon_PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationInteraction_Items_FruitTree_FruitId",
                        column: x => x.FruitTree_FruitId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationInteraction_Coordinates_CoordinatesId",
                        column: x => x.CoordinatesId,
                        principalTable: "Coordinates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationInteraction_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationInteraction_Items_PlacedItem_ItemId",
                        column: x => x.PlacedItem_ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationInteraction_PokemonSpecieses_PokemonNpc_PokemonSpeciesId",
                        column: x => x.PokemonNpc_PokemonSpeciesId,
                        principalTable: "PokemonSpecieses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationInteraction_Locations_Portal_TargetId",
                        column: x => x.Portal_TargetId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationInteraction_Pokemon_StaticPokemon_PokemonId",
                        column: x => x.StaticPokemon_PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationInteraction_Move_Tutor_TaughtMoveId",
                        column: x => x.Tutor_TaughtMoveId,
                        principalTable: "Move",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PokemonMove",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PokemonId = table.Column<int>(nullable: false),
                    MoveId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonMove", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonMove_Move_MoveId",
                        column: x => x.MoveId,
                        principalTable: "Move",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonMove_Pokemon_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BossPokemonDropItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BossPokemonId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BossPokemonDropItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BossPokemonDropItem_LocationInteraction_BossPokemonId",
                        column: x => x.BossPokemonId,
                        principalTable: "LocationInteraction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BossPokemonDropItem_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BossTrainerDropItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BossTrainerId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BossTrainerDropItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BossTrainerDropItem_LocationInteraction_BossTrainerId",
                        column: x => x.BossTrainerId,
                        principalTable: "LocationInteraction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BossTrainerDropItem_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemGift",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HumanNpcId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemGift", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemGift_LocationInteraction_HumanNpcId",
                        column: x => x.HumanNpcId,
                        principalTable: "LocationInteraction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemGift_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonGift",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HumanNpcId = table.Column<int>(nullable: false),
                    PokemonSpeciesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonGift", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonGift_LocationInteraction_HumanNpcId",
                        column: x => x.HumanNpcId,
                        principalTable: "LocationInteraction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonGift_PokemonSpecieses_PokemonSpeciesId",
                        column: x => x.PokemonSpeciesId,
                        principalTable: "PokemonSpecieses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonSpawn",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SpawnRarity = table.Column<int>(nullable: false),
                    PokemonSpeciesId = table.Column<int>(nullable: false),
                    PokemonSpawnPointId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonSpawn", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonSpawn_LocationInteraction_PokemonSpawnPointId",
                        column: x => x.PokemonSpawnPointId,
                        principalTable: "LocationInteraction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonSpawn_PokemonSpecieses_PokemonSpeciesId",
                        column: x => x.PokemonSpeciesId,
                        principalTable: "PokemonSpecieses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonTrade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PokemonTradeType = table.Column<int>(nullable: false),
                    PriceInCoins = table.Column<int>(nullable: false),
                    HumanNpcId = table.Column<int>(nullable: false),
                    PokemonSpeciesId = table.Column<int>(nullable: false),
                    TradeForSpeciesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonTrade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonTrade_LocationInteraction_HumanNpcId",
                        column: x => x.HumanNpcId,
                        principalTable: "LocationInteraction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonTrade_PokemonSpecieses_PokemonSpeciesId",
                        column: x => x.PokemonSpeciesId,
                        principalTable: "PokemonSpecieses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonTrade_PokemonSpecieses_TradeForSpeciesId",
                        column: x => x.TradeForSpeciesId,
                        principalTable: "PokemonSpecieses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Quest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QuestType = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ExperienceReward = table.Column<int>(nullable: false),
                    MoneyReward = table.Column<int>(nullable: false),
                    NpcId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quest_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Quest_LocationInteraction_NpcId",
                        column: x => x.NpcId,
                        principalTable: "LocationInteraction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainerPokemon",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TrainerId = table.Column<int>(nullable: false),
                    PokemonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainerPokemon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainerPokemon_Pokemon_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainerPokemon_LocationInteraction_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "LocationInteraction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PokemonSpawnTimeOfDay",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PokemonSpawnId = table.Column<int>(nullable: false),
                    TimeOfDayId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonSpawnTimeOfDay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonSpawnTimeOfDay_PokemonSpawn_PokemonSpawnId",
                        column: x => x.PokemonSpawnId,
                        principalTable: "PokemonSpawn",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonSpawnTimeOfDay_TimeOfDay_TimeOfDayId",
                        column: x => x.TimeOfDayId,
                        principalTable: "TimeOfDay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BossPokemonDropItem_BossPokemonId",
                table: "BossPokemonDropItem",
                column: "BossPokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_BossPokemonDropItem_ItemId",
                table: "BossPokemonDropItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_BossTrainerDropItem_BossTrainerId",
                table: "BossTrainerDropItem",
                column: "BossTrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_BossTrainerDropItem_ItemId",
                table: "BossTrainerDropItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ElementalTypeCombination_PrimaryTypeId",
                table: "ElementalTypeCombination",
                column: "PrimaryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ElementalTypeCombination_SecondaryTypeId",
                table: "ElementalTypeCombination",
                column: "SecondaryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemGift_HumanNpcId",
                table: "ItemGift",
                column: "HumanNpcId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemGift_ItemId",
                table: "ItemGift",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationInteraction_BossPokemon_PokemonId",
                table: "LocationInteraction",
                column: "BossPokemon_PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationInteraction_FruitTree_FruitId",
                table: "LocationInteraction",
                column: "FruitTree_FruitId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationInteraction_CoordinatesId",
                table: "LocationInteraction",
                column: "CoordinatesId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationInteraction_LocationId",
                table: "LocationInteraction",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationInteraction_PlacedItem_ItemId",
                table: "LocationInteraction",
                column: "PlacedItem_ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationInteraction_PokemonNpc_PokemonSpeciesId",
                table: "LocationInteraction",
                column: "PokemonNpc_PokemonSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationInteraction_Portal_TargetId",
                table: "LocationInteraction",
                column: "Portal_TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationInteraction_StaticPokemon_PokemonId",
                table: "LocationInteraction",
                column: "StaticPokemon_PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationInteraction_Tutor_TaughtMoveId",
                table: "LocationInteraction",
                column: "Tutor_TaughtMoveId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_RegionId",
                table: "Locations",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_PokemonSpeciesId",
                table: "Pokemon",
                column: "PokemonSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonGift_HumanNpcId",
                table: "PokemonGift",
                column: "HumanNpcId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonGift_PokemonSpeciesId",
                table: "PokemonGift",
                column: "PokemonSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonMove_MoveId",
                table: "PokemonMove",
                column: "MoveId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonMove_PokemonId",
                table: "PokemonMove",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpawn_PokemonSpawnPointId",
                table: "PokemonSpawn",
                column: "PokemonSpawnPointId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpawn_PokemonSpeciesId",
                table: "PokemonSpawn",
                column: "PokemonSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpawnTimeOfDay_PokemonSpawnId",
                table: "PokemonSpawnTimeOfDay",
                column: "PokemonSpawnId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpawnTimeOfDay_TimeOfDayId",
                table: "PokemonSpawnTimeOfDay",
                column: "TimeOfDayId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpeciesDropItem_ItemId",
                table: "PokemonSpeciesDropItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpeciesDropItem_PokemonSpeciesId",
                table: "PokemonSpeciesDropItem",
                column: "PokemonSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpecieses_ElementalTypeCombinationId",
                table: "PokemonSpecieses",
                column: "ElementalTypeCombinationId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpecieses_EvYieldId",
                table: "PokemonSpecieses",
                column: "EvYieldId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonTrade_HumanNpcId",
                table: "PokemonTrade",
                column: "HumanNpcId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonTrade_PokemonSpeciesId",
                table: "PokemonTrade",
                column: "PokemonSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonTrade_TradeForSpeciesId",
                table: "PokemonTrade",
                column: "TradeForSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_Quest_LocationId",
                table: "Quest",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Quest_NpcId",
                table: "Quest",
                column: "NpcId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerPokemon_PokemonId",
                table: "TrainerPokemon",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerPokemon_TrainerId",
                table: "TrainerPokemon",
                column: "TrainerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BossPokemonDropItem");

            migrationBuilder.DropTable(
                name: "BossTrainerDropItem");

            migrationBuilder.DropTable(
                name: "ItemGift");

            migrationBuilder.DropTable(
                name: "PokemonGift");

            migrationBuilder.DropTable(
                name: "PokemonMove");

            migrationBuilder.DropTable(
                name: "PokemonSpawnTimeOfDay");

            migrationBuilder.DropTable(
                name: "PokemonSpeciesDropItem");

            migrationBuilder.DropTable(
                name: "PokemonTrade");

            migrationBuilder.DropTable(
                name: "Quest");

            migrationBuilder.DropTable(
                name: "TrainerPokemon");

            migrationBuilder.DropTable(
                name: "PokemonSpawn");

            migrationBuilder.DropTable(
                name: "TimeOfDay");

            migrationBuilder.DropTable(
                name: "LocationInteraction");

            migrationBuilder.DropTable(
                name: "Pokemon");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Coordinates");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Move");

            migrationBuilder.DropTable(
                name: "PokemonSpecieses");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropTable(
                name: "ElementalTypeCombination");

            migrationBuilder.DropTable(
                name: "EvYield");

            migrationBuilder.DropTable(
                name: "ElementalType");
        }
    }
}
