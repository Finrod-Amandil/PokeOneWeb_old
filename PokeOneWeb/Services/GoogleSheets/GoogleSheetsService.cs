using System.Collections.Generic;
using System.IO;
using System.Threading;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;

namespace PokeOneWeb.Services.GoogleSheets
{
    public class GoogleSheetsService
    {
        private static readonly string[] Scopes = {SheetsService.Scope.SpreadsheetsReadonly};
        private static readonly string ApplicationName = "Google Sheets API .NET Quickstart";

        private readonly SheetsService _service;

        public GoogleSheetsService()
        {
            var credential = GetUserCredential();

            // Create Google Sheets API service.
            _service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }

        public Spreadsheet GetSpreadsheet(string spreadsheetId)
        {
            var request = _service.Spreadsheets.Get(spreadsheetId);
            request.IncludeGridData = true;

            var response = request.Execute();
            return response;
        }

        private UserCredential GetUserCredential()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                var credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            return credential;
        }
    }
}