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
    public class AisleProductController : ApiController
    {
        //// GET: api/AisleProduct/5
        //public AisleProduct Get(Guid id)
        //{
        //    return AisleProductManager.LoadById(id); ;
        //}

        //// GET: api/AisleProduct
        //public IEnumerable<AisleProduct> Get()
        //{
        //    return AisleProductManager.Load();                                        // Until methods are created

        //}

        // POST: api/AisleProduct
        public void Post([FromBody]AisleProduct ap)
        {
            AisleProductManager.Insert(ap);
        }

        // PUT: api/AisleProduct/5
        public void Put(Guid id, [FromBody]AisleProduct ap)
        {
            AisleProductManager.Update(ap);
        }

        //// DELETE: api/AisleProduct/5
        //public void Delete(Guid id)
        //{
        //    AisleProductManager.Delete(id);
        //}
    }
}
