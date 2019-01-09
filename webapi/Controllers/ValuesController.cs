using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webapi.Controllers
{
    public class ValuesController : ApiController
    {
        /// <summary>
        /// Gets the values from the server.
        /// </summary>
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Looks up some value by ID.
        /// </summary>
        /// <param name="id">The ID of the value.</param>
        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Insert new value on the server.
        /// </summary>
        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// Update value by ID.
        /// </summary>
        /// <param name="id">The ID of the value.</param>
        /// <param name="value">The value.</param>
        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// Delete value by ID.
        /// </summary>
        /// <param name="id">The ID of the value.</param>
        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
