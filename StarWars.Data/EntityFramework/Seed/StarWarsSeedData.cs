using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using StarWars.Core.Models;

namespace StarWars.Data.EntityFramework.Seed
{
    public static class StarWarsSeedData
    {
        public static void EnsureSeedData(this StarWarsContext context)
        {
            if (!context.Droids.Any())
            {
                context.Droids.Add(new Droid { Name  = "R2-D2" });
                context.SaveChanges();
            }
        }

        public static void EnsureDatabaseMigrated(this StarWarsContext context)
        {
            context.Database.Migrate();
        }
    }
}
