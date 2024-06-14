using Magnus.Views.Import;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Magnus.APIs.Import
{
    public class ImportServices : IImportServices
    {
        private const string ApiPrefix = "/api/";
        private static string ApiImport => $"{ApiPrefix}Import/";

        private readonly HttpClient _apiClient;
        public ImportServices(HttpClient httpClient)
        {
            _apiClient = httpClient;
        }
        public async Task<ImportMultiselectView> GetAllMultiSelect()
        {
            var result =
              await _apiClient.GetAsync($"{ApiImport}GetAllMultiSelect");

            if (result.StatusCode.Equals(HttpStatusCode.NotFound))
            {
                return default;
            }

            result.EnsureSuccessStatusCode();
            var list = await result.Content.ReadFromJsonAsync<ImportMultiselectView>();
            return list;
        }
    }
}
