using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using StarWars.Core.Models;

namespace StarWars.Data.EntityFramework
{
    public class StarWarsContext : DbContext
    {
        public StarWarsContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Droid> Droids { get; set; }
    }
}
