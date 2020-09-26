using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GroceryGetter.BL.Models;
using GroceryGetter.BL;


namespace GroceryGetter.API.Controllers
{
    public class AisleController : ApiController
    {
        // GET: api/Aisle/5
        //public Aisle Get(Guid id)
        //{
        //    return AisleManager.LoadById(id);
        //}

        // GET: api/Aisle
        public IEnumerable<Aisle> Get()
        {
            return AisleManager.Load();

        }

        // POST: api/Aisle
        public void Post([FromBody]Aisle aisle)
        {
            AisleManager.Insert(aisle);
        }

        // PUT: api/Aisle/5
        public void Put(Guid id, [FromBody]Aisle aisle)
        {
            AisleManager.Update(aisle);
        }

        // DELETE: api/Aisle/5
        public void Delete(Guid id)
        {
            AisleManager.Delete(id);
        }
    }
}
