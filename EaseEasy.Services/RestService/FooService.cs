using EaseEasy.RestService.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EaseEasy.Services.RestService {
    [Restful]
    public class FooService {
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
