using Grpc.Core;
using grpc_poc;

namespace grpc_poc.Services {
    public class HelloService : Helloer.HelloerBase {
        private readonly ILogger<HelloService> _logger;
        public HelloService(ILogger<HelloService> logger) {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context) {
            _logger.LogInformation("Saying hello to {Name}", request.Name);
            return Task.FromResult(new HelloReply {
                Message = "Hello " + request.Name
            });
        }
    }
}
