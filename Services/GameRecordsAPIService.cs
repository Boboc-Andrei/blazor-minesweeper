using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MinesweeperAPI.Services
{
    public class GameRecordsAPIService
    {
        private readonly HttpClient _httpClient;

        public GameRecordsAPIService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task AddGameRecordAsync(MinesweeperGameRecord record)
        {
            await _httpClient.PostAsJsonAsync("api/gamerecords", record);
        }
    }
}
