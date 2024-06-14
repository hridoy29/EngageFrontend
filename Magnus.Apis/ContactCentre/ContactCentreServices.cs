using Magnus.Views.ContactCentre;
using Magnus.Views.GridDataView;
using Magnus.Views.Params;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.APIs.ContactCentre
{
    public class ContactCentreServices:IContactCentreServices
    {
        private const string ApiPrefix = "/api/";
        private static string ApiContactCentre => $"{ApiPrefix}ContactCentre/";

        

        private readonly HttpClient _apiClient;
        public ContactCentreServices(HttpClient httpClient)
        {
            _apiClient = httpClient;
        }

        public async Task<List<string>> DropdownData()
        {
            var result =
                          await _apiClient.GetAsync($"{ApiContactCentre}GetDropDownData");

            if (result.StatusCode.Equals(HttpStatusCode.NotFound))
            {
                return default;
            }

            result.EnsureSuccessStatusCode();
            var list = await result.Content.ReadFromJsonAsync<List<string>>();
            return list;
        }

        public async Task<GridDataView<ContactCentreView>> GetPagedAllAsync(GridViewParams gridViewParams)
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
                await _apiClient.GetAsync(QueryHelpers.AddQueryString($"{ApiContactCentre}GetAll",
                    queryStringParam));

            if (result.StatusCode.Equals(HttpStatusCode.NotFound))
            {
                return default;
            }

            result.EnsureSuccessStatusCode();
            var list = await result.Content.ReadFromJsonAsync<GridDataView<ContactCentreView>>();
            return list;
        }
    }
}
