using Magnus.APIs;
using MagnusWebUI.Data.Navigation;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Blazored.Toast.Services;
using Blazored.Toast;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Blazored.LocalStorage;
using Toolbelt.Blazor.Extensions.DependencyInjection;
using Radzen;
using MagnusWebUI;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["Api:EngageAPI"]!) });
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5139") });

builder.Services.AddApiServices();
builder.Services.AddScoped<EnagageNavigationManager>();
builder.Services.AddScoped<ToastParameters>();
builder.Services.AddBlazoredToast();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddHttpClientInterceptor();

builder.Services.AddScoped<DialogService>();
builder.Services.AddSweetAlert2();

builder.Services.AddMsalAuthentication<RemoteAuthenticationState,
    CustomUserAccount>(options =>
{
    builder.Configuration.Bind("AzureAd", options.ProviderOptions.Authentication);
    //options.ProviderOptions.DefaultAccessTokenScopes.Add("https://contoso.onmicrosoft.com/2229ef4f-df3c-4989-ae92-2f3a20b319ca/User.Read");
})
    .AddAccountClaimsPrincipalFactory<RemoteAuthenticationState, CustomUserAccount,
        CustomAccountFactory>();



var baseUrl = string.Join("/",
    builder.Configuration.GetSection("MicrosoftGraph")["BaseUrl"],
    builder.Configuration.GetSection("MicrosoftGraph")["Version"]);
var scopes = builder.Configuration.GetSection("MicrosoftGraph:Scopes")
    .Get<List<string>>();

builder.Services.AddGraphClient(baseUrl, scopes);

builder.Services.AddAuthorizationCore(options =>
{
    options.AddPolicy("Magnus-Users", policy =>
        policy.RequireClaim("directoryGroup",
            "8e49903c-7183-4f35-b35e-50316f02e622"));
    options.AddPolicy("Magnus-Devs", policy =>
       policy.RequireClaim("directoryGroup",
           "39ef60c1-c162-4c09-807a-e0e668bedf65"));
    options.AddPolicy("Magnus-UAT", policy =>
       policy.RequireClaim("directoryGroup",
           "4cdbc083-266c-48aa-8365-65f87423ca04"));

});

await builder.Build().RunAsync();
