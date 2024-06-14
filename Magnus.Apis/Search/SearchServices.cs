using Magnus.Views.Params;
using Magnus.Views.Search;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Magnus.APIs.Search;

public class SearchServices : ISearchServices
{
    private readonly HttpClient _apiClient;

    private const string apiRoute = $"/api/Search";

    public SearchServices(HttpClient httpClient)
    {
        _apiClient = httpClient;
    }

    public async Task<IList<SearchView>> GetAllAsync(SearchViewParams searchViewParams)
    {
        try
        {
            HttpResponseMessage result = await _apiClient.PostAsJsonAsync($"{apiRoute}/SearchCases", searchViewParams);
            
            result.EnsureSuccessStatusCode();
            
            IList<SearchView> list = await result.Content.ReadFromJsonAsync<IList<SearchView>>();

            return list;
        }
        catch (Exception ex)
        {
            //TODO: add logging
            throw;
        }
    }

    public async Task<IList<ClientView>> GetAllClient(bool active)
    {
        try
        {
            var result = await _apiClient.GetAsync($"{apiRoute}/GetClients/{active}");

            result.EnsureSuccessStatusCode();

            IList<ClientView> list = await result.Content.ReadFromJsonAsync<IList<ClientView>>();
            return list;
        }
        catch (Exception ex)
        {
            //TODO: add logging
            throw;
        }
    }

    public async Task<IList<CaseStatusView>> GetAllCaseStatus()
    {
        try
        {
            var result = await _apiClient.GetAsync($"{apiRoute}/GetCaseStatuses");

            result.EnsureSuccessStatusCode();

            IList<CaseStatusView> list = await result.Content.ReadFromJsonAsync<IList<CaseStatusView>>();
            return list;
        }
        catch (Exception ex)
        {
            //TODO: add logging
            throw;
        }
    }
}
