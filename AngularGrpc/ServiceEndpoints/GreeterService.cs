using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularGrpc.Endpoints;
using Microsoft.Extensions.Logging;
using Grpc.Core;

namespace AngularGrpc.ServiceEndpoints {
    public class GreeterService : Greeter.GreeterBase {
        private readonly ILogger<GreeterService> _logger;

        public GreeterService(ILogger<GreeterService> logger) {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context) {
            _logger.LogInformation($"Saying hello to {request.Name}", request.Name);
            return Task.FromResult(new HelloReply {
                Message = $"Hello " + $"Saying hello to {request.Name}" + request.Name
            });
        }
    }
}
