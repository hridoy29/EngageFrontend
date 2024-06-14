using Engage.Views.Files;
using Magnus.Views.Admin.ImportSetup;
using Magnus.Views.Search;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Azure.Storage.Files.Shares.Models;
using Azure.Storage.Files.Shares;

namespace Magnus.APIs.Admin
{
    public class AdminService : IAdminService
    {
        private const string ApiPrefix = "/api/";
        private static string ApiAdmin => $"{ApiPrefix}Admin/";
        private static string ApiFile => $"{ApiPrefix}File/";

        private readonly HttpClient _apiClient;
        public AdminService(HttpClient httpClient)
        {
            _apiClient = httpClient;
        }
        public async Task<IEnumerable<ImportMappingFileView>> GetImportMappingFileAsync()
        {
            var result =
                 await _apiClient.GetAsync($"{ApiAdmin}GetFileTypes");

            if (result.StatusCode.Equals(HttpStatusCode.NotFound))
            {
                return default;
            }

            result.EnsureSuccessStatusCode();
            var list = await result.Content.ReadFromJsonAsync<IEnumerable<ImportMappingFileView>>();
            return list;
        }

        public async Task<IEnumerable<ImportMappingHeaderCategoryView>> GetImportMappingHeaderCategoryAsync(int fileTypeId)
        {
            var result =
                await _apiClient.GetAsync($"{ApiAdmin}GetMappingHeaders/{fileTypeId}");

            if (result.StatusCode.Equals(HttpStatusCode.NotFound))
            {
                return default;
            }

            result.EnsureSuccessStatusCode();
            var list = await result.Content.ReadFromJsonAsync<IEnumerable<ImportMappingHeaderCategoryView>>();
            return list;
        }

        public async Task<bool> AddNewImportMappingsAsync(ImportMappingView importMappingViewList)
        {
            var result =
                await _apiClient.PostAsJsonAsync($"{ApiAdmin}AddNewImportMappings", importMappingViewList);

           
            return false;
        }

        public async Task<List<FileDetailsView>> GetFileAsync(List<string> fileNames)
        {
            var result =
               await _apiClient.PostAsJsonAsync($"{ApiFile}GetFileAsync", fileNames);

            if (result.StatusCode.Equals(HttpStatusCode.NotFound))
            {
                return default;
            }

            result.EnsureSuccessStatusCode();
            var list = await result.Content.ReadFromJsonAsync<List<FileDetailsView>>();
            return list;
        }
    }
}
