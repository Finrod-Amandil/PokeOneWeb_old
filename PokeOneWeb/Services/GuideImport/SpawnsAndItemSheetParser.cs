using System;
using System.Collections.Generic;
using System.Linq;
using Google.Apis.Sheets.v4.Data;
using PokeOneWeb.ViewModels.GuideImport;

namespace PokeOneWeb.Services.GuideImport
{
    public class SpawnsAndItemSheetParser
    {
        public IList<LocationViewModel> Parse(Spreadsheet spreadsheet, string sheetName)
        {
            var sheet = spreadsheet.Sheets.Single(s => s.Properties.Title.Equals(sheetName, StringComparison.InvariantCulture));
            var rowData = sheet.Data[0].RowData;

            var rowIndex = 1;

            //Iterate through sheet
            while (rowIndex < rowData.Count)
            {
                //Find first relevant row: First row where leftmost cell is not empty
                while (string.IsNullOrEmpty(rowData[rowIndex].Values[0].FormattedValue))
                {
                    rowIndex++;
                }

                var spawns = ParsePokemonSpawns(sheet, rowIndex);

                rowIndex++;
            }




            return null;
        }

        private List<PokemonSpawnViewModel> ParsePokemonSpawns(Sheet sheet, int rowIndex)
        {
            var pokemonSpawns = new List<PokemonSpawnViewModel>();

            var rowData = sheet.Data[0].RowData;

            if (!rowData[rowIndex].Values[1].FormattedValue.Equals("Pokémon", StringComparison.InvariantCulture) ||
                !rowData[rowIndex].Values[2].FormattedValue.Equals("Time", StringComparison.InvariantCulture) ||
                !rowData[rowIndex].Values[3].FormattedValue.Equals("Method", StringComparison.InvariantCulture) ||
                !rowData[rowIndex].Values[6].FormattedValue.Equals("Rarity", StringComparison.InvariantCulture) ||
                !rowData[rowIndex].Values[7].FormattedValue.Equals("Notes", StringComparison.InvariantCulture))
            {
                throw new Exception("Invalid column name");
            }

            rowIndex++;
            while (
                rowIndex < rowData.Count && //End of sheet is reached
                string.IsNullOrEmpty(rowData[rowIndex].Values[0].FormattedValue) && //End of location is reached
                !string.IsNullOrEmpty(rowData[rowIndex].Values[1].FormattedValue)) //No more Pokémon in this location
            {
                var spawnViewModel = new PokemonSpawnViewModel
                {
                    PokemonSpeciesName = rowData[rowIndex].Values[1].FormattedValue,
                    TimesOfDayString = rowData[rowIndex].Values[2].FormattedValue,
                    MethodName = rowData[rowIndex].Values[3].FormattedValue,
                    RarityName = rowData[rowIndex].Values[6].FormattedValue,
                    Notes = rowData[rowIndex].Values[7].FormattedValue
                };
                pokemonSpawns.Add(spawnViewModel);

                //Split spawns with method "Fish/Surf" into two spawns with methods "Fishing" and "Surfing"
                if (spawnViewModel.MethodName.Equals("Surf/Fish", StringComparison.InvariantCulture))
                {
                    spawnViewModel.MethodName = "Fishing";
                    pokemonSpawns.Add(new PokemonSpawnViewModel
                    {
                        PokemonSpeciesName = spawnViewModel.PokemonSpeciesName,
                        TimesOfDayString = spawnViewModel.TimesOfDayString,
                        MethodName = "Surfing",
                        RarityName = spawnViewModel.RarityName,
                        Notes = spawnViewModel.Notes
                    });
                }

                //Special procedure for method "Fishing": Has additional info of fishing rod compatibility
                if (spawnViewModel.MethodName.Equals("Fishing", StringComparison.InvariantCulture))
                {
                    rowIndex++;
                    
                    var oldRodColor = rowData[rowIndex].Values[3].EffectiveFormat.BackgroundColor;
                    var goodRodColor = rowData[rowIndex].Values[4].EffectiveFormat.BackgroundColor;
                    var superRodColor = rowData[rowIndex].Values[5].EffectiveFormat.BackgroundColor;

                    spawnViewModel.FishingRodTypes = new Dictionary<string, bool?>
                    {
                        { "OR", GetFishingRodStatusByColor(oldRodColor) },
                        { "GR", GetFishingRodStatusByColor(goodRodColor) },
                        { "SR", GetFishingRodStatusByColor(superRodColor) }
                    };

                }
                rowIndex++;
            }

            return pokemonSpawns;
        }

        private bool? GetFishingRodStatusByColor(Color color)
        {
            //Field is green --> can be fished using this rod
            if (color.Green != null && color.Red == null && color.Blue == null)
            {
                return true;
            }

            //Field is red --> can not be fished using this rod
            else if (color.Green == null && color.Red != null && color.Blue == null)
            {
                return false;
            }

            //Any other color: unknown whether can be fished using this rod
            else
            {
                return null;
            }
        }
    }
}
