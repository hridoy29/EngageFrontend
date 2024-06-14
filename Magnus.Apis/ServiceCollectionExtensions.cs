using Magnus.APIs.Admin;
using Magnus.APIs.Atom;
using Magnus.APIs.ClientDetails;
using Magnus.APIs.ContactCentre;
using Magnus.APIs.Import;
using Magnus.APIs.OnLoadAlocation;
using Magnus.APIs.Search;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.APIs
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services)
        {
            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IAtomServices, AtomServices>();
            services.AddScoped<ISearchServices, SearchServices>();
            services.AddScoped<IContactCentreServices, ContactCentreServices>();
            services.AddScoped<ILoadAlocationServices, LoadAlocationServices>();
            services.AddScoped<IImportServices, ImportServices>();
            services.AddScoped<IClientDetailsServices, ClientDetailsServices>();
            return services;
        }
    }
}
