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
    public class UserProductController : ApiController
    {
        //// GET: api/UserProduct/5
        //public UserProduct Get(Guid id)
        //{
        //    return UserProductManager.LoadById(id); ;
        //}

        //// GET: api/UserProduct
        //public IEnumerable<UserProduct> Get()
        //{
        //    return UserProductManager.Load();

        //}

        // POST: api/UserProduct
        public void Post([FromBody]UserProduct up)
        {
            UserProductManager.Insert(up);
        }

        //// PUT: api/UserProduct/5
        //public void Put(Guid id, [FromBody]UserProduct up)
        //{
        //    UserManager.Update(up);
        //}

        // DELETE: api/UserProduct/5
        public void Delete(Guid id)
        {
            UserProductManager.Delete(id);
        }
    }
}
