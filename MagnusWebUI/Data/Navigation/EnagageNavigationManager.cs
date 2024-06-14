using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MagnusWebUI.Data.Navigation
{
    public class EnagageNavigationManager
    {
        private readonly NavigationManager _navigate;
        private readonly IJSRuntime _jSRuntime;

        public EnagageNavigationManager(NavigationManager navigate, IJSRuntime JSRuntime)
        {
            _navigate = navigate;
            _jSRuntime = JSRuntime;
        }
        public async Task closeSideNav()
        {
            await _jSRuntime.InvokeVoidAsync("sidebarclose");
        }
        
        public void Atom()
        {
            _ = closeSideNav();
            _navigate.NavigateTo($"/atom");
        }
        public void Agent()
        {
            _ = closeSideNav();
            _navigate.NavigateTo($"/agent");
        }
        public void AdminImportSetup()
        {
            _ = closeSideNav();
            _navigate.NavigateTo($"/admin/import_setup");
        }
        public void AdminUAT()
        {
            _ = closeSideNav();
            _navigate.NavigateTo($"/admin/Uat");
        }
        public void ContactCentre()
        {
            _ = closeSideNav();
            _navigate.NavigateTo($"/dialler");
        }
        public void Import()
        {
            _ = closeSideNav();
            _navigate.NavigateTo($"/import");
        }
        public void Search()
        {
            _ = closeSideNav();
            _navigate.NavigateTo($"/search");
        }
        public void BackToSearch(string query)
        {
            _ = closeSideNav();
            _navigate.NavigateTo($"/search?"+query);
        }
        public void OnloadAlocation()
        {
            _ = closeSideNav();
            _navigate.NavigateTo($"/on-load-alocation");
        }
        public void Devtools()
        {
            _ = closeSideNav();
            _navigate.NavigateTo($"/dev-tools");
        } 
        public void CaseDetails(int ourReference)
        {
            _ = closeSideNav();
            _navigate.NavigateTo($"/case-details?oref={ourReference}");
        }
    }
}
