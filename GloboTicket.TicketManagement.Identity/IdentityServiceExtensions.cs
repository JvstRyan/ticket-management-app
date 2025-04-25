using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using GloboTicket.TicketManagement.Identity.Models;

namespace GloboTicket.TicketManagement.Identity
{
    public static class IdentityServiceExtensions
    {
        public static void AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(IdentityConstants.ApplicationScheme).AddIdentityCookies();

            services.AddAuthorizationBuilder();

            services.AddDbContext<GloboTicketIdentityDbContext>(options
                => options.UseSqlServer(configuration.GetConnectionString("GloboTicketIdentityConnectionString")));

            services.AddIdentityCore<ApplicationUser>()
                .AddEntityFrameworkStores<GloboTicketIdentityDbContext>()
                .AddApiEndpoints();
        }
    }
}
