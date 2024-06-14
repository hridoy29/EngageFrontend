using Magnus.Core.Models.CaseDetailsModels;
using Magnus.Views.Params;
using System.Net;
using System.Net.Http.Json;

namespace Magnus.APIs.ClientDetails;

public class ClientDetailsServices : IClientDetailsServices
{
    private const string ApiPrefix = "/api/";
    private static string ApiClientDetail => $"{ApiPrefix}CaseDetails/";
    //private static string ApiFileUpload => $"{ApiPrefix}File/";

    private readonly HttpClient _apiClient;
    public ClientDetailsServices(HttpClient httpClient)
    {
        _apiClient = httpClient;
    }

    public async Task<CaseDetails> GetCaseDetailsAsync(int ourReference)
    {
        var result =
           await _apiClient.GetAsync($"{ApiClientDetail}GetCaseDetails/{ourReference}");

        if (result.StatusCode.Equals(HttpStatusCode.NotFound))
        {
            return default;
        }

        result.EnsureSuccessStatusCode();
        var obj = await result.Content.ReadFromJsonAsync<CaseDetails>();
        return obj;
    }

    public async Task<bool> PostActionHistoryAsync(ActionHistoryViewParams actionHistoryViewParams)
    {
        var result = await _apiClient.PostAsJsonAsync($"{ApiClientDetail}PostActionHistory", actionHistoryViewParams);

        return result.IsSuccessStatusCode;
    }
}
