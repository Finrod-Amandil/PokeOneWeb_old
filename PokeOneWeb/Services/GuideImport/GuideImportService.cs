using System.Collections.Generic;
using Google.Apis.Sheets.v4.Data;
using PokeOneWeb.Services.GoogleSheets;

namespace PokeOneWeb.Services.GuideImport
{
    public class GuideImportService
    {
        private GoogleSheetsService _googleSheetsService;
        private SpawnsAndItemSheetParser _spawnsAndItemSheetParser;

        private Spreadsheet _spreadsheet;

        public GuideImportService()
        {
            _googleSheetsService = new GoogleSheetsService();
            _spawnsAndItemSheetParser = new SpawnsAndItemSheetParser();
        }

        public void ImportGuideDataToDatabase()
        {
            //Load spreadsheet data
            _spreadsheet = _googleSheetsService.GetSpreadsheet(GuideImportConstants.SPREADSHEET_ID);

            ImportKantoSpawnsAndItems();
        }

        private void ImportKantoSpawnsAndItems()
        {
            var parsedLocations = _spawnsAndItemSheetParser.Parse(_spreadsheet, GuideImportConstants.KANTO_SPAWNS_AND_ITEMS_NAME);
        }
    }
}