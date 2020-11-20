﻿using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Web.Http;

namespace TRMDataManager.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {




      
        public IEnumerable<string> Get()
        {

            string userID = RequestContext.Principal.Identity.GetUserId();

            string myEmail = RequestContext.Principal.Identity.GetUserName();

           return new string[] { "value1", "value2", userID, myEmail };

        }













        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }



        // POST api/values
        public void Post([FromBody] string value)
        {
        }




        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }



        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
