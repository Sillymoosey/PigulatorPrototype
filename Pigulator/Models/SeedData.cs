using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Pigulator.Data;

namespace Pigulator.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            PigulatorContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<PigulatorContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Pigulator.Any())
            {
                context.Pigulator.AddRange(
                    new Pigs
                    {
                        WholePig = 1450,
                        HalfPig = 800

                    }) ;
                context.SaveChanges();
            }
        }
    }
}
