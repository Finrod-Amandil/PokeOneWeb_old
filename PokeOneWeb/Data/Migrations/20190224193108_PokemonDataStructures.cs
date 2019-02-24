using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PokeOneWeb.Data.Migrations
{
    public partial class PokemonDataStructures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ability",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ability", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BagCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BagCategory", x => x.Id);
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
                name: "FruitTreeType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FruitTreeType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FunctionalNpcType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FunctionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FunctionalNpcType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemObtainMethod",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemObtainMethod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocationGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokemonNpcType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonNpcType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokemonSpawnPointType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonSpawnPointType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    IsEventRegion = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpawnRarity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpawnRarity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Attack = table.Column<int>(nullable: false),
                    Defense = table.Column<int>(nullable: false),
                    SpecialAttack = table.Column<int>(nullable: false),
                    SpecialDefense = table.Column<int>(nullable: false),
                    Speed = table.Column<int>(nullable: false),
                    Hp = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Id);
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
                name: "TrainerType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainerType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    BagCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_BagCategory_BagCategoryId",
                        column: x => x.BagCategoryId,
                        principalTable: "BagCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElementalTypeCombination",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PrimaryTypeId = table.Column<int>(nullable: false),
                    SecondaryTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementalTypeCombination", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElementalTypeCombination_ElementalType_PrimaryTypeId",
                        column: x => x.PrimaryTypeId,
                        principalTable: "ElementalType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ElementalTypeCombination_ElementalType_SecondaryTypeId",
                        column: x => x.SecondaryTypeId,
                        principalTable: "ElementalType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ElementalTypeDamageRelation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AttackEffectivity = table.Column<double>(nullable: false),
                    AttackingTypeId = table.Column<int>(nullable: false),
                    DefendingTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementalTypeDamageRelation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElementalTypeDamageRelation_ElementalType_AttackingTypeId",
                        column: x => x.AttackingTypeId,
                        principalTable: "ElementalType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ElementalTypeDamageRelation_ElementalType_DefendingTypeId",
                        column: x => x.DefendingTypeId,
                        principalTable: "ElementalType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Move",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Strength = table.Column<int>(nullable: true),
                    Accuracy = table.Column<double>(nullable: false),
                    PP = table.Column<int>(nullable: false),
                    MoveDamageClass = table.Column<int>(nullable: false),
                    ElementalTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Move", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Move_ElementalType_ElementalTypeId",
                        column: x => x.ElementalTypeId,
                        principalTable: "ElementalType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Map",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    LocationGroupId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Map", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Map_LocationGroup_LocationGroupId",
                        column: x => x.LocationGroupId,
                        principalTable: "LocationGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    RegionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Event_Region_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Region",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GloballyObtainableItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemId = table.Column<int>(nullable: false),
                    ItemObtainMethodId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GloballyObtainableItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GloballyObtainableItem_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GloballyObtainableItem_ItemObtainMethod_ItemObtainMethodId",
                        column: x => x.ItemObtainMethodId,
                        principalTable: "ItemObtainMethod",
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
                    DoesLevelIncrease = table.Column<bool>(nullable: false),
                    MaxLevel = table.Column<int>(nullable: false),
                    IsCatchable = table.Column<bool>(nullable: false),
                    PokemonSpeciesVarietyId = table.Column<int>(nullable: false),
                    AbilityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pokemon_Ability_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "Ability",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonDropItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsGuaranteed = table.Column<bool>(nullable: false),
                    PokemonId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonDropItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonDropItem_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonDropItem_Pokemon_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "PokemonSpeciesVariety",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    Availability = table.Column<int>(nullable: false),
                    PokemonSpeciesId = table.Column<int>(nullable: false),
                    DefaultFormId = table.Column<int>(nullable: false),
                    BaseStatsId = table.Column<int>(nullable: false),
                    EvYieldId = table.Column<int>(nullable: false),
                    ElementalTypeCombinationId = table.Column<int>(nullable: false),
                    PrimaryAbilityId = table.Column<int>(nullable: false),
                    SecondaryAbilityId = table.Column<int>(nullable: false),
                    HiddenAbilityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonSpeciesVariety", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonSpeciesVariety_Stats_BaseStatsId",
                        column: x => x.BaseStatsId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PokemonSpeciesVariety_ElementalTypeCombination_ElementalTypeCombinationId",
                        column: x => x.ElementalTypeCombinationId,
                        principalTable: "ElementalTypeCombination",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonSpeciesVariety_Stats_EvYieldId",
                        column: x => x.EvYieldId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PokemonSpeciesVariety_Ability_HiddenAbilityId",
                        column: x => x.HiddenAbilityId,
                        principalTable: "Ability",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PokemonSpeciesVariety_Ability_PrimaryAbilityId",
                        column: x => x.PrimaryAbilityId,
                        principalTable: "Ability",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PokemonSpeciesVariety_Ability_SecondaryAbilityId",
                        column: x => x.SecondaryAbilityId,
                        principalTable: "Ability",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LearnableMove",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LearnMethod = table.Column<int>(nullable: false),
                    IsAvailable = table.Column<bool>(nullable: false),
                    MoveId = table.Column<int>(nullable: false),
                    PokemonSpeciesVarietyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearnableMove", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LearnableMove_Move_MoveId",
                        column: x => x.MoveId,
                        principalTable: "Move",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LearnableMove_PokemonSpeciesVariety_PokemonSpeciesVarietyId",
                        column: x => x.PokemonSpeciesVarietyId,
                        principalTable: "PokemonSpeciesVariety",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    IsAccessible = table.Column<bool>(nullable: false),
                    IsDiscoverable = table.Column<bool>(nullable: false),
                    RegionId = table.Column<int>(nullable: false),
                    LocationGroupId = table.Column<int>(nullable: false),
                    SignificantPokemonSpeciesVarietyId = table.Column<int>(nullable: true),
                    InGameAreaName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Location_LocationGroup_LocationGroupId",
                        column: x => x.LocationGroupId,
                        principalTable: "LocationGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Location_Region_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Region",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Location_PokemonSpeciesVariety_SignificantPokemonSpeciesVarietyId",
                        column: x => x.SignificantPokemonSpeciesVarietyId,
                        principalTable: "PokemonSpeciesVariety",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PokemonSpecies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PokedexNumber = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Availability = table.Column<int>(nullable: false),
                    DefaultVarietyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonSpecies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonSpecies_PokemonSpeciesVariety_DefaultVarietyId",
                        column: x => x.DefaultVarietyId,
                        principalTable: "PokemonSpeciesVariety",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonSpeciesVarietyDropItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PokemonSpeciesVarietyId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonSpeciesVarietyDropItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonSpeciesVarietyDropItem_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonSpeciesVarietyDropItem_PokemonSpeciesVariety_PokemonSpeciesVarietyId",
                        column: x => x.PokemonSpeciesVarietyId,
                        principalTable: "PokemonSpeciesVariety",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonSpeciesVarietyForm",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    Sprite = table.Column<string>(nullable: true),
                    Artwork = table.Column<string>(nullable: true),
                    ShinyArtwork = table.Column<string>(nullable: true),
                    PokemonSpeciesVarietyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonSpeciesVarietyForm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonSpeciesVarietyForm_PokemonSpeciesVariety_PokemonSpeciesVarietyId",
                        column: x => x.PokemonSpeciesVarietyId,
                        principalTable: "PokemonSpeciesVariety",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LocationInteraction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlacementDescription = table.Column<string>(nullable: true),
                    X = table.Column<int>(nullable: false),
                    Y = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    LocationId = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    FruitTree_FruitItemId = table.Column<int>(nullable: true),
                    FruitTree_TypeId = table.Column<int>(nullable: true),
                    HumanNpc_Name = table.Column<string>(nullable: true),
                    FunctionalNpc_FunctionalNpcTypeId = table.Column<int>(nullable: true),
                    Trainer_TrainerTypeId = table.Column<int>(nullable: true),
                    Trainer_ExperienceReward = table.Column<int>(nullable: true),
                    Trainer_MoneyReward = table.Column<int>(nullable: true),
                    PokemonNpc_PokemonId = table.Column<int>(nullable: true),
                    PokemonNpc_PokemonNpcTypeId = table.Column<int>(nullable: true),
                    BossPokemon_ExperienceReward = table.Column<int>(nullable: true),
                    BossPokemon_MoneyReward = table.Column<int>(nullable: true),
                    PlacedItem_ItemId = table.Column<int>(nullable: true),
                    PlacedItem_IsHidden = table.Column<bool>(nullable: true),
                    PokemonSpawnPoint_PokemonSpawnPointTypeId = table.Column<int>(nullable: true),
                    Portal_Label = table.Column<string>(nullable: true),
                    Portal_TargetLocationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationInteraction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationInteraction_Item_FruitTree_FruitItemId",
                        column: x => x.FruitTree_FruitItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationInteraction_FruitTreeType_FruitTree_TypeId",
                        column: x => x.FruitTree_TypeId,
                        principalTable: "FruitTreeType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationInteraction_FunctionalNpcType_FunctionalNpc_FunctionalNpcTypeId",
                        column: x => x.FunctionalNpc_FunctionalNpcTypeId,
                        principalTable: "FunctionalNpcType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationInteraction_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationInteraction_Item_PlacedItem_ItemId",
                        column: x => x.PlacedItem_ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationInteraction_Pokemon_PokemonNpc_PokemonId",
                        column: x => x.PokemonNpc_PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationInteraction_PokemonNpcType_PokemonNpc_PokemonNpcTypeId",
                        column: x => x.PokemonNpc_PokemonNpcTypeId,
                        principalTable: "PokemonNpcType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationInteraction_PokemonSpawnPointType_PokemonSpawnPoint_PokemonSpawnPointTypeId",
                        column: x => x.PokemonSpawnPoint_PokemonSpawnPointTypeId,
                        principalTable: "PokemonSpawnPointType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationInteraction_Location_Portal_TargetLocationId",
                        column: x => x.Portal_TargetLocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationInteraction_TrainerType_Trainer_TrainerTypeId",
                        column: x => x.Trainer_TrainerTypeId,
                        principalTable: "TrainerType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MapLocation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MapId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapLocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MapLocation_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MapLocation_Map_MapId",
                        column: x => x.MapId,
                        principalTable: "Map",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    From = table.Column<string>(nullable: true),
                    ExperienceReward = table.Column<int>(nullable: false),
                    MoneyReward = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quest_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemGift",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NpcId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemGift", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemGift_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemGift_LocationInteraction_NpcId",
                        column: x => x.NpcId,
                        principalTable: "LocationInteraction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MoveTutorMove",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MoveTutorId = table.Column<int>(nullable: false),
                    TaughtMoveId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoveTutorMove", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoveTutorMove_LocationInteraction_MoveTutorId",
                        column: x => x.MoveTutorId,
                        principalTable: "LocationInteraction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoveTutorMove_Move_TaughtMoveId",
                        column: x => x.TaughtMoveId,
                        principalTable: "Move",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonGift",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NpcId = table.Column<int>(nullable: false),
                    PokemonSpeciesVarietyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonGift", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonGift_LocationInteraction_NpcId",
                        column: x => x.NpcId,
                        principalTable: "LocationInteraction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonGift_PokemonSpeciesVariety_PokemonSpeciesVarietyId",
                        column: x => x.PokemonSpeciesVarietyId,
                        principalTable: "PokemonSpeciesVariety",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonSpawn",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsConfirmed = table.Column<bool>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    SpawnRarityId = table.Column<int>(nullable: false),
                    PokemonSpeciesVarietyId = table.Column<int>(nullable: false),
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
                        name: "FK_PokemonSpawn_PokemonSpeciesVariety_PokemonSpeciesVarietyId",
                        column: x => x.PokemonSpeciesVarietyId,
                        principalTable: "PokemonSpeciesVariety",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonSpawn_SpawnRarity_SpawnRarityId",
                        column: x => x.SpawnRarityId,
                        principalTable: "SpawnRarity",
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
                    PriceInCoins = table.Column<int>(nullable: true),
                    PriceInPokeDollar = table.Column<int>(nullable: true),
                    HumanNpcId = table.Column<int>(nullable: false),
                    PokemonSpeciesVarietyId = table.Column<int>(nullable: false),
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
                        name: "FK_PokemonTrade_PokemonSpeciesVariety_PokemonSpeciesVarietyId",
                        column: x => x.PokemonSpeciesVarietyId,
                        principalTable: "PokemonSpeciesVariety",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PokemonTrade_PokemonSpeciesVariety_TradeForSpeciesId",
                        column: x => x.TradeForSpeciesId,
                        principalTable: "PokemonSpeciesVariety",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainerDropItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsGuaranteed = table.Column<bool>(nullable: false),
                    TrainerId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainerDropItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainerDropItem_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainerDropItem_LocationInteraction_TrainerId",
                        column: x => x.TrainerId,
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestItemReward",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemId = table.Column<int>(nullable: false),
                    QuestId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestItemReward", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestItemReward_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestItemReward_Quest_QuestId",
                        column: x => x.QuestId,
                        principalTable: "Quest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_ElementalTypeCombination_PrimaryTypeId",
                table: "ElementalTypeCombination",
                column: "PrimaryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ElementalTypeCombination_SecondaryTypeId",
                table: "ElementalTypeCombination",
                column: "SecondaryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ElementalTypeDamageRelation_AttackingTypeId",
                table: "ElementalTypeDamageRelation",
                column: "AttackingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ElementalTypeDamageRelation_DefendingTypeId",
                table: "ElementalTypeDamageRelation",
                column: "DefendingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_RegionId",
                table: "Event",
                column: "RegionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GloballyObtainableItem_ItemId",
                table: "GloballyObtainableItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_GloballyObtainableItem_ItemObtainMethodId",
                table: "GloballyObtainableItem",
                column: "ItemObtainMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_BagCategoryId",
                table: "Item",
                column: "BagCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemGift_ItemId",
                table: "ItemGift",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemGift_NpcId",
                table: "ItemGift",
                column: "NpcId");

            migrationBuilder.CreateIndex(
                name: "IX_LearnableMove_MoveId",
                table: "LearnableMove",
                column: "MoveId");

            migrationBuilder.CreateIndex(
                name: "IX_LearnableMove_PokemonSpeciesVarietyId",
                table: "LearnableMove",
                column: "PokemonSpeciesVarietyId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_LocationGroupId",
                table: "Location",
                column: "LocationGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_RegionId",
                table: "Location",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_SignificantPokemonSpeciesVarietyId",
                table: "Location",
                column: "SignificantPokemonSpeciesVarietyId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationGroup_Name",
                table: "LocationGroup",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_LocationInteraction_FruitTree_FruitItemId",
                table: "LocationInteraction",
                column: "FruitTree_FruitItemId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationInteraction_FruitTree_TypeId",
                table: "LocationInteraction",
                column: "FruitTree_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationInteraction_FunctionalNpc_FunctionalNpcTypeId",
                table: "LocationInteraction",
                column: "FunctionalNpc_FunctionalNpcTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationInteraction_LocationId",
                table: "LocationInteraction",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationInteraction_PlacedItem_ItemId",
                table: "LocationInteraction",
                column: "PlacedItem_ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationInteraction_PokemonNpc_PokemonId",
                table: "LocationInteraction",
                column: "PokemonNpc_PokemonId",
                unique: true,
                filter: "[PokemonNpc_PokemonId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_LocationInteraction_PokemonNpc_PokemonNpcTypeId",
                table: "LocationInteraction",
                column: "PokemonNpc_PokemonNpcTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationInteraction_PokemonSpawnPoint_PokemonSpawnPointTypeId",
                table: "LocationInteraction",
                column: "PokemonSpawnPoint_PokemonSpawnPointTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationInteraction_Portal_TargetLocationId",
                table: "LocationInteraction",
                column: "Portal_TargetLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationInteraction_Trainer_TrainerTypeId",
                table: "LocationInteraction",
                column: "Trainer_TrainerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Map_LocationGroupId",
                table: "Map",
                column: "LocationGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_MapLocation_LocationId",
                table: "MapLocation",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_MapLocation_MapId",
                table: "MapLocation",
                column: "MapId");

            migrationBuilder.CreateIndex(
                name: "IX_Move_ElementalTypeId",
                table: "Move",
                column: "ElementalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MoveTutorMove_MoveTutorId",
                table: "MoveTutorMove",
                column: "MoveTutorId");

            migrationBuilder.CreateIndex(
                name: "IX_MoveTutorMove_TaughtMoveId",
                table: "MoveTutorMove",
                column: "TaughtMoveId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_AbilityId",
                table: "Pokemon",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_PokemonSpeciesVarietyId",
                table: "Pokemon",
                column: "PokemonSpeciesVarietyId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonDropItem_ItemId",
                table: "PokemonDropItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonDropItem_PokemonId",
                table: "PokemonDropItem",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonGift_NpcId",
                table: "PokemonGift",
                column: "NpcId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonGift_PokemonSpeciesVarietyId",
                table: "PokemonGift",
                column: "PokemonSpeciesVarietyId");

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
                name: "IX_PokemonSpawn_PokemonSpeciesVarietyId",
                table: "PokemonSpawn",
                column: "PokemonSpeciesVarietyId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpawn_SpawnRarityId",
                table: "PokemonSpawn",
                column: "SpawnRarityId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpawnTimeOfDay_PokemonSpawnId",
                table: "PokemonSpawnTimeOfDay",
                column: "PokemonSpawnId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpawnTimeOfDay_TimeOfDayId",
                table: "PokemonSpawnTimeOfDay",
                column: "TimeOfDayId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpecies_DefaultVarietyId",
                table: "PokemonSpecies",
                column: "DefaultVarietyId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpecies_PokedexNumber",
                table: "PokemonSpecies",
                column: "PokedexNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpeciesVariety_BaseStatsId",
                table: "PokemonSpeciesVariety",
                column: "BaseStatsId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpeciesVariety_DefaultFormId",
                table: "PokemonSpeciesVariety",
                column: "DefaultFormId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpeciesVariety_ElementalTypeCombinationId",
                table: "PokemonSpeciesVariety",
                column: "ElementalTypeCombinationId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpeciesVariety_EvYieldId",
                table: "PokemonSpeciesVariety",
                column: "EvYieldId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpeciesVariety_HiddenAbilityId",
                table: "PokemonSpeciesVariety",
                column: "HiddenAbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpeciesVariety_PokemonSpeciesId",
                table: "PokemonSpeciesVariety",
                column: "PokemonSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpeciesVariety_PrimaryAbilityId",
                table: "PokemonSpeciesVariety",
                column: "PrimaryAbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpeciesVariety_SecondaryAbilityId",
                table: "PokemonSpeciesVariety",
                column: "SecondaryAbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpeciesVarietyDropItem_ItemId",
                table: "PokemonSpeciesVarietyDropItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpeciesVarietyDropItem_PokemonSpeciesVarietyId",
                table: "PokemonSpeciesVarietyDropItem",
                column: "PokemonSpeciesVarietyId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpeciesVarietyForm_PokemonSpeciesVarietyId",
                table: "PokemonSpeciesVarietyForm",
                column: "PokemonSpeciesVarietyId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonTrade_HumanNpcId",
                table: "PokemonTrade",
                column: "HumanNpcId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonTrade_PokemonSpeciesVarietyId",
                table: "PokemonTrade",
                column: "PokemonSpeciesVarietyId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonTrade_TradeForSpeciesId",
                table: "PokemonTrade",
                column: "TradeForSpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_Quest_LocationId",
                table: "Quest",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestItemReward_ItemId",
                table: "QuestItemReward",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestItemReward_QuestId",
                table: "QuestItemReward",
                column: "QuestId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerDropItem_ItemId",
                table: "TrainerDropItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerDropItem_TrainerId",
                table: "TrainerDropItem",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerPokemon_PokemonId",
                table: "TrainerPokemon",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerPokemon_TrainerId",
                table: "TrainerPokemon",
                column: "TrainerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_PokemonSpeciesVariety_PokemonSpeciesVarietyId",
                table: "Pokemon",
                column: "PokemonSpeciesVarietyId",
                principalTable: "PokemonSpeciesVariety",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonSpeciesVariety_PokemonSpeciesVarietyForm_DefaultFormId",
                table: "PokemonSpeciesVariety",
                column: "DefaultFormId",
                principalTable: "PokemonSpeciesVarietyForm",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonSpeciesVariety_PokemonSpecies_PokemonSpeciesId",
                table: "PokemonSpeciesVariety",
                column: "PokemonSpeciesId",
                principalTable: "PokemonSpecies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElementalTypeCombination_ElementalType_PrimaryTypeId",
                table: "ElementalTypeCombination");

            migrationBuilder.DropForeignKey(
                name: "FK_ElementalTypeCombination_ElementalType_SecondaryTypeId",
                table: "ElementalTypeCombination");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonSpecies_PokemonSpeciesVariety_DefaultVarietyId",
                table: "PokemonSpecies");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonSpeciesVarietyForm_PokemonSpeciesVariety_PokemonSpeciesVarietyId",
                table: "PokemonSpeciesVarietyForm");

            migrationBuilder.DropTable(
                name: "ElementalTypeDamageRelation");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "GloballyObtainableItem");

            migrationBuilder.DropTable(
                name: "ItemGift");

            migrationBuilder.DropTable(
                name: "LearnableMove");

            migrationBuilder.DropTable(
                name: "MapLocation");

            migrationBuilder.DropTable(
                name: "MoveTutorMove");

            migrationBuilder.DropTable(
                name: "PokemonDropItem");

            migrationBuilder.DropTable(
                name: "PokemonGift");

            migrationBuilder.DropTable(
                name: "PokemonMove");

            migrationBuilder.DropTable(
                name: "PokemonSpawnTimeOfDay");

            migrationBuilder.DropTable(
                name: "PokemonSpeciesVarietyDropItem");

            migrationBuilder.DropTable(
                name: "PokemonTrade");

            migrationBuilder.DropTable(
                name: "QuestItemReward");

            migrationBuilder.DropTable(
                name: "TrainerDropItem");

            migrationBuilder.DropTable(
                name: "TrainerPokemon");

            migrationBuilder.DropTable(
                name: "ItemObtainMethod");

            migrationBuilder.DropTable(
                name: "Map");

            migrationBuilder.DropTable(
                name: "Move");

            migrationBuilder.DropTable(
                name: "PokemonSpawn");

            migrationBuilder.DropTable(
                name: "TimeOfDay");

            migrationBuilder.DropTable(
                name: "Quest");

            migrationBuilder.DropTable(
                name: "LocationInteraction");

            migrationBuilder.DropTable(
                name: "SpawnRarity");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "FruitTreeType");

            migrationBuilder.DropTable(
                name: "FunctionalNpcType");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Pokemon");

            migrationBuilder.DropTable(
                name: "PokemonNpcType");

            migrationBuilder.DropTable(
                name: "PokemonSpawnPointType");

            migrationBuilder.DropTable(
                name: "TrainerType");

            migrationBuilder.DropTable(
                name: "BagCategory");

            migrationBuilder.DropTable(
                name: "LocationGroup");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropTable(
                name: "ElementalType");

            migrationBuilder.DropTable(
                name: "PokemonSpeciesVariety");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "PokemonSpeciesVarietyForm");

            migrationBuilder.DropTable(
                name: "ElementalTypeCombination");

            migrationBuilder.DropTable(
                name: "Ability");

            migrationBuilder.DropTable(
                name: "PokemonSpecies");
        }
    }
}
