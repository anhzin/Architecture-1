using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SoftwareAPI.Controllers
{
    public class OwnersController : ApiController
    {
        private static List<Models.Owner> owners = new List<Models.Owner>()
        {
            new Models.Owner(){ ActorID = Guid.NewGuid(), ActorTitle = "Owner 1", Number = 1}
        };

        // GET: api/Owners
        public IEnumerable<Models.Owner> Get()
        {
            return owners;
        }

        // GET: api/Owners/5
        public Models.Owner Get(int i)
        {
            return owners.Where(t => t.Number == i).FirstOrDefault();
        }

        // POST: api/Owners
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Owners/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Owners/5
        public void Delete(int id)
        {
        }
    }
}
