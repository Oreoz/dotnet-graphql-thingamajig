using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using StarWars.Core.Data;
using StarWars.Core.Models;

namespace StarWars.Api.Models
{
    public class StarWarsQuery : ObjectGraphType
    {
        public StarWarsQuery(IDroidRepository droidRepository)
        {
            Field<DroidType>(
                "hero", 
                resolve: context => droidRepository.Get(1)
            );
        }
    }
}
