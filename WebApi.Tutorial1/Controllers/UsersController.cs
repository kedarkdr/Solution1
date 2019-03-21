using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Tutorial1.Business.Repositories;
using WebApi.Tutorial1.Models;

namespace WebApi.Tutorial1.Controllers
{

    public partial class UsersController : ApiController
    {
        private static UserRepository _userRepository = new UserRepository();
        public IHttpActionResult GetAll()
        {
            return ResponseMessage(Request.CreateResponse( HttpStatusCode.OK, _userRepository.GetAll()));
        }

        public IHttpActionResult GetById(int id)
        {
            return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, _userRepository.GetById(id)));
        }

        public IHttpActionResult CreateUser([FromBody]User user)
        {
            _userRepository.Add(user);

            return ResponseMessage(Request.CreateResponse(HttpStatusCode.Created));
        }

    }
}
