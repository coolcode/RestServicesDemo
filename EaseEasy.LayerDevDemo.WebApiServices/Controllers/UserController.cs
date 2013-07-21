using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EaseEasy.LayerDevDemo.WebApiServices.Controllers {
    public class UserController : ApiController {
        [HttpPost]
        public User GetUser(User user) {
            user.Name += " modifed in " + DateTime.Now;
            return user;
        }
    }

    public class User {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}