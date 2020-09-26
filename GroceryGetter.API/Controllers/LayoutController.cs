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
    public class LayoutController : ApiController
    {
        // GET: api/Layout/5
        public Layout Get(Guid id)
        {
            return LayoutManager.LoadById(id); ;
        }

        // GET: api/Layout
        //public IEnumerable<Layout> Get()
        //{
        //    return LayoutManager.Load();          // Until a Load method is created

        //}

        // POST: api/Layout
        public void Post([FromBody]Layout layout)
        {
            LayoutManager.Insert(layout);
        }

        // PUT: api/Layout/5
        public void Put(Guid id, [FromBody]Layout layout)
        {
            LayoutManager.Update(layout);
        }

        // DELETE: api/Layout/5
        //public void Delete(Guid id)
        //{
        //    LayoutManager.Delete(id);         // Until a Delete method is created
        //}
    }
}
