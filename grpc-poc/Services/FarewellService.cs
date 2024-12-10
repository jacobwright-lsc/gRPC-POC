using Grpc.Core;
using grpc_poc;

namespace grpc_poc.Services {
    public class FarewellService : Fareweller.FarewellerBase {
        private readonly ILogger<FarewellService> _logger;
        public FarewellService(ILogger<FarewellService> logger) {
            _logger = logger;
        }

        public override Task<FarewellReply> SayFarewell(FarewellRequest request, ServerCallContext context) {
            _logger.LogInformation("Saying farewell to {Name}", request.Name);
            return Task.FromResult(new FarewellReply {
                Message = "Farewell " + request.Name
            });
        }
    }
}
