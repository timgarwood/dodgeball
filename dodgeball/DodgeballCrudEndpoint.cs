using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;
using Nancy.Hosting.Self;

namespace dodgeball
{
    /// <summary>
    /// This endpoint handles the standard CRUD operations for
    /// dodgeball related domain objects
    /// </summary>
    class DodgeballCrudEndpoint : Nancy.NancyModule
    {
        public DodgeballCrudEndpoint() : base()
        {
            Post["/season/add"] = AddSeason;
            Get["/season/add"] = AddSeason;
        }

        private dynamic AddSeason(dynamic d)
        {
            Response response = new Response();
            return response.WithStatusCode(200);
        }
    }
}
