using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;


namespace SoftwareAPI.Controllers
{
    public class DocumentsController : ApiController
    {
        private static List<Models.Document> documents = new List<Models.Document>()
        {
            new Models.Document{ ActorID = Guid.NewGuid(), ActorPropID = Guid.NewGuid(), ActorPropTitle = "Doc1", Number = 1},
            new Models.Document{ ActorID = Guid.NewGuid(), ActorPropID = Guid.NewGuid(), ActorPropTitle = "Doc2", Number = 2},
            new Models.Document{ ActorID = Guid.NewGuid(), ActorPropID = Guid.NewGuid(), ActorPropTitle = "Doc3", Number = 3}
        };
        // GET: api/Documents
        public async Task<List<Models.Document>> Get()
        {
            return documents;
        }
        // GET: api/Doc/5
        public Models.Document Get(int id)
        {
            return documents[id];
        }

        // POST: api/Doc
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Doc/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Doc/5
        public void Delete(int id)
        {
        }
    }
}
