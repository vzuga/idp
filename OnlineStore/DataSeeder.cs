using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Models;

namespace OnlineStore
{
    public static class DataSeeder
    {
        public static void SeedData(this IApplicationBuilder app)
        {
            using (var context = new OnlineStoreContext())
            {
                if (!context.Database.EnsureCreated())
                {
                    context.Database.Migrate();
                }
            }
        }
    }
}
