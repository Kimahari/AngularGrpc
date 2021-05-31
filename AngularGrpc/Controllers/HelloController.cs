using AngularGrpc.Endpoints;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularGrpc.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase {

        [HttpPost]
        public HelloReply SayHello(HelloRequest helloRequest) {
            return new HelloReply() { Message = "Hello " + $"Saying hello to {helloRequest.Name}" + helloRequest.Name };
        }
    }
}
