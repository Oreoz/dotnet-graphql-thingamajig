using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using StarWars.Core.Models;

namespace StarWars.Api.Models
{
    public class StarWarsQuery : ObjectGraphType
    {
        public StarWarsQuery()
        {
            Field<DroidType>("hero", resolve: context => new Droid { Id = 1, Name = "R2-D2" });
        }
    }
}
