using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using webapi.Models;

namespace webapi.Controllers
{
    public class UsersController : ApiController
    {

        private User[] users = new User[]
        {
            new User { id = 1, name = "Vladwoguer Bezerra", email = "vladwoguerbezerra@gmail.com", phone = "01111111", role = 1},
            new User { id = 2, name = "Tacila Magalhães", email = "vladwoguerbezerra@gmail.com", phone = "01111111", role = 1},
        };


        /// <summary>
        /// Gets the users from the server.
        /// </summary>
        // GET: api/Users
        [ResponseType(typeof(IEnumerable<User>))]
        public IEnumerable<User> Get()
        {
            return users;
        }

        /// <summary>
        /// Looks up some user by ID.
        /// </summary>
        /// <param name="id">The ID of the user.</param>
        // GET: api/Users/5
        public IHttpActionResult Get(int id)
        {
            var product = users.FirstOrDefault((p) => p.id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
