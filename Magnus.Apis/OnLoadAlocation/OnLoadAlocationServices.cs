using Magnus.Views.GridDataView;
using Magnus.Views.OnLoadAlocation;
using Magnus.Views.Params;
using Microsoft.AspNetCore.WebUtilities;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Magnus.APIs.OnLoadAlocation
{
    public class LoadAlocationServices : ILoadAlocationServices
    {
        private static string ApiLoadAlocation => $"/api/OnLoadAlocation/";

        private readonly HttpClient _apiClient;
        public LoadAlocationServices(HttpClient httpClient)
        {
            _apiClient = httpClient;
        }

        public async Task<GridDataView<OnLoadAlocationView>> GetAllAsync(GridViewParams gridViewParams)
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
                await _apiClient.GetAsync(QueryHelpers.AddQueryString($"{ApiLoadAlocation}GetAll",
                    queryStringParam));

            if (result.StatusCode.Equals(HttpStatusCode.NotFound))
            {
                return default;
            }

            result.EnsureSuccessStatusCode();
            var list = await result.Content.ReadFromJsonAsync<GridDataView<OnLoadAlocationView>>();
            return list;
        }

        public async Task<List<NotAvailableMultiSelectView>> GetAllNotAvailableMultiSelectViews()
        {
            var result =
                await _apiClient.GetAsync(ApiLoadAlocation+"GetAllMultiSelect");

            if (result.StatusCode.Equals(HttpStatusCode.NotFound))
            {
                return default;
            }

            result.EnsureSuccessStatusCode();
            var list = await result.Content.ReadFromJsonAsync<List<NotAvailableMultiSelectView>>();
            return list;
        }

        public async Task<GridDataView<LetterSelectionView>> LetterSelectionGetPagedAsync(GridViewParams gridViewParams)
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
                await _apiClient.GetAsync(QueryHelpers.AddQueryString($"{ApiLoadAlocation}GetPagedLetterSelectionAll",
                    queryStringParam));

            if (result.StatusCode.Equals(HttpStatusCode.NotFound))
            {
                return default;
            }

            result.EnsureSuccessStatusCode();
            var list = await result.Content.ReadFromJsonAsync<GridDataView<LetterSelectionView>>();
            return list;
        }

        public async Task<GridDataView<PostCodeCheckerView>> PostCodeCheckerGetPagedAsync(GridViewParams gridViewParams)
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
                await _apiClient.GetAsync(QueryHelpers.AddQueryString($"{ApiLoadAlocation}GetPostCodeCheckerAll",
                    queryStringParam));

            if (result.StatusCode.Equals(HttpStatusCode.NotFound))
            {
                return default;
            }

            result.EnsureSuccessStatusCode();
            var list = await result.Content.ReadFromJsonAsync<GridDataView<PostCodeCheckerView>>();
            return list;
        }

        public async Task<GridDataView<OlAFSettingView>> olAFSettingGetPagedAsync(GridViewParams gridViewParams)
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
                await _apiClient.GetAsync(QueryHelpers.AddQueryString($"{ApiLoadAlocation}GetOlafSettingAll",
                    queryStringParam));

            if (result.StatusCode.Equals(HttpStatusCode.NotFound))
            {
                return default;
            }

            result.EnsureSuccessStatusCode();
            var list = await result.Content.ReadFromJsonAsync<GridDataView<OlAFSettingView>>();
            return list;
        }
    }
}
