using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace TestWithHedgehogs_TestTaskForAdmixer_.Services.API
{
    internal class HedgehogsOperAPIService
    {
        private readonly HttpClient httpClient;
        private readonly string apiBaseUrl;

        public HedgehogsOperAPIService(string apiBaseUrl)
        {
            httpClient = new HttpClient();
            this.apiBaseUrl = apiBaseUrl;
        }

        public async Task<Dictionary<int, string>> GetNumberHedgehogsTheirColor(int[] data)
        {
            string apiUrl = $"{apiBaseUrl}/colors";

            HttpResponseMessage response = await httpClient.PostAsJsonAsync(apiUrl, data);
            response.EnsureSuccessStatusCode();

            Dictionary<int, string> result = await response.Content.ReadAsAsync<Dictionary<int, string>>();

            return result;
        }
    }
}
