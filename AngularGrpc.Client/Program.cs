using AngularGrpc.Endpoints;
using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

namespace AngularGrpc.Client {
    class Program {
        static async Task Main(string[] args) {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);

            var response = await client.SayHelloAsync(
                new HelloRequest { Name = "World" });

            Console.WriteLine(response.Message);

        }
    }
}
