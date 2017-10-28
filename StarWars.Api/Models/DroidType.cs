using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using StarWars.Core.Models;

namespace StarWars.Api.Models
{
    public class DroidType : ObjectGraphType<Droid>
    {
        public DroidType()
        {
            Field(t => t.Id).Description("");
            Field(t => t.Name, nullable: true).Description("");
        }
    }
}
