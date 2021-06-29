using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UserDataBaseAccess;

namespace Deliver_Eat.Controllers
{
    public class UserController : ApiController
    {
        //pour recevoir des reponse avec un Http get
        public IEnumerable<DeliverEatUser> Get()
        {
            using (Deliver_Eat_CustomerBaseEntities entities = new Deliver_Eat_CustomerBaseEntities())
            {
                return entities.DeliverEatUser.ToList();
            }
        }

        public DeliverEatUser Get(string username)
        {
            using (Deliver_Eat_CustomerBaseEntities entities = new Deliver_Eat_CustomerBaseEntities())
            {
                return entities.DeliverEatUser.FirstOrDefault(e =>e.Username == username)
            }
        }
    }
}
