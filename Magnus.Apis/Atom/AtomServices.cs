using Magnus.Views.Atom;
using Magnus.Views.GridDataView;
using Magnus.Views.Params;
using Microsoft.AspNetCore.WebUtilities;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Magnus.APIs.Atom;

public class AtomServices : IAtomServices
{
    private const string ApiPrefix = "/api/";
    private static string ApiAtom => $"{ApiPrefix}Atom/";

    private readonly HttpClient _apiClient;
    
    public AtomServices(HttpClient httpClient)
    {
        _apiClient = httpClient;
    }
    
    public async Task<GridDataView<AtomPlanningView>> GetAllAsync(GridViewParams gridViewParams)
    {
        switch (gridViewParams)
        {
            case null:
                return default;
            default:
                break;
        }

        var queryStringParam = new Dictionary<string, string>
        {
            ["Filter"] = gridViewParams.Filter is null ? string.Empty : gridViewParams.Filter,
            ["OrderBy"] = gridViewParams.OrderBy is null ? string.Empty : gridViewParams.OrderBy,
            ["Skip"] = gridViewParams.Skip.ToString(),
            ["Take"] = gridViewParams.Take.ToString()
        };
        var result =
            await _apiClient.GetAsync(QueryHelpers.AddQueryString($"{ApiAtom}GetAll",
                queryStringParam));

        if (result.StatusCode.Equals(HttpStatusCode.NotFound))
        {
            return default;
        }

        result.EnsureSuccessStatusCode();
        var list= await result.Content.ReadFromJsonAsync<GridDataView<AtomPlanningView>>();
        return list;
    }

    public async Task<List<PlanningMultiSelectView>> GetAllPlanningMutiselectAsync()
    {
        var result =
           await _apiClient.GetAsync($"{ApiAtom}GetAllMultiSelect");

        if (result.StatusCode.Equals(HttpStatusCode.NotFound))
        {
            return default;
        }

        result.EnsureSuccessStatusCode();
        var list = await result.Content.ReadFromJsonAsync<List<PlanningMultiSelectView>>();
        return list;
    }

    public async Task<GridDataView<AtomExportPlansView>> GetAllExportplanAsync(GridViewParams gridViewParams)
    {
        switch (gridViewParams)
        {
            case null:
                return default;
            default:
                break;
        }

        var queryStringParam = new Dictionary<string, string>
        {
            ["DateFilter"]=gridViewParams.DateFilter,
            ["Filter"] = gridViewParams.Filter is null ? string.Empty : gridViewParams.Filter,
            ["OrderBy"] = gridViewParams.OrderBy is null ? string.Empty : gridViewParams.OrderBy,
            ["Skip"] = gridViewParams.Skip.ToString(),
            ["Take"] = gridViewParams.Take.ToString()
        };
        var result =
            await _apiClient.GetAsync(QueryHelpers.AddQueryString($"{ApiAtom}GetAllExportPlans",
                queryStringParam));

        if (result.StatusCode.Equals(HttpStatusCode.NotFound))
        {
            return default;
        }

        result.EnsureSuccessStatusCode();
        var list = await result.Content.ReadFromJsonAsync<GridDataView<AtomExportPlansView>>();
        return list;
    }

    public async Task<GridDataView<AtomDisconnectionStatusView>> GetAllDisconnectionStatusAsync(GridViewParams gridViewParams)
    {
        switch (gridViewParams)
        {
            case null:
                return default;
            default:
                break;
        }

        var queryStringParam = new Dictionary<string, string>
        {
            ["DateFilter"] = gridViewParams.DateFilter,
            ["Filter"] = gridViewParams.Filter is null ? string.Empty : gridViewParams.Filter,
            ["OrderBy"] = gridViewParams.OrderBy is null ? string.Empty : gridViewParams.OrderBy,
            ["Skip"] = gridViewParams.Skip.ToString(),
            ["Take"] = gridViewParams.Take.ToString()
        };
        var result =
            await _apiClient.GetAsync(QueryHelpers.AddQueryString($"{ApiAtom}GetAllDisconnectionStatuses",
                queryStringParam));

        if (result.StatusCode.Equals(HttpStatusCode.NotFound))
        {
            return default;
        }

        result.EnsureSuccessStatusCode();
        var list = await result.Content.ReadFromJsonAsync<GridDataView<AtomDisconnectionStatusView>>();
        return list;
    }

    public async Task<List<AtomDisconnectionStatusMultiSelect>> GetAllDisconnectioStatusMutiselectAsync()
    {
        var result =
           await _apiClient.GetAsync($"{ApiAtom}GetAllDisconnectionStatusMultiSelect");

        if (result.StatusCode.Equals(HttpStatusCode.NotFound))
        {
            return default;
        }

        result.EnsureSuccessStatusCode();
        var list = await result.Content.ReadFromJsonAsync<List<AtomDisconnectionStatusMultiSelect>>();
        return list;
    }
}
