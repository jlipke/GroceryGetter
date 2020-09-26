using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GroceryGetter.BL;
using GroceryGetter.BL.Models;

namespace GroceryGetter.API.Controllers
{
    public class StoreController : ApiController
    {
        // GET: api/Store/5
        public Store Get(Guid id)
        {
            return StoreManager.LoadbyId(id); ;
        }

        // GET: api/Store
        public IEnumerable<Store> Get()
        {
            return StoreManager.Load();

        }

        // POST: api/Store
        public void Post([FromBody]Store store)
        {
            StoreManager.Insert(store);
        }

        // PUT: api/Store/5
        public void Put(Guid id, [FromBody]Store store)
        {
            StoreManager.Update(store);
        }

        // DELETE: api/Store/5
        public void Delete(Guid id)
        {
            StoreManager.Delete(id);
        }
    }
}
