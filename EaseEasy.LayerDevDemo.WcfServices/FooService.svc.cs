using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace EaseEasy.LayerDevDemo.WcfServices {
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceContract]
    public class FooService {
        [OperationContract]
        [WebInvoke( Method = "POST",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json, 
            ResponseFormat = WebMessageFormat.Json)] 
        public User GetUser(User user) {
            user.Name += " modifed in " + DateTime.Now;
            return user;
        }
    }

    [DataContract]
    public class User {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Age { get; set; }
    }
}
