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
            try
            {
                var response = await _httpClient.PostAsJsonAsync("MinesweeperLogs", record);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Failed to save game: {ex.Message}");
            }
        }
    }
}
