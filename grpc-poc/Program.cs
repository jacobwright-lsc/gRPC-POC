using grpc_poc.Services;

namespace grpc_poc {
    public class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddGrpc();

            // CORS https://learn.microsoft.com/en-us/aspnet/core/grpc/grpcweb?view=aspnetcore-9.0#grpc-web-and-cors
            builder.Services.AddCors(o => o.AddPolicy("AllowAll", builder =>
            {
                builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .WithExposedHeaders("Grpc-Status", "Grpc-Message", "Grpc-Encoding", "Grpc-Accept-Encoding");
            }));

            var app = builder.Build();
            
            // Add Web/Browser support
            app.UseGrpcWeb();
            app.UseCors();

            // Register services
            app.MapGrpcService<HelloService>().EnableGrpcWeb().RequireCors("AllowAll");
            app.MapGrpcService<FarewellService>().EnableGrpcWeb().RequireCors("AllowAll");


            // Configure the HTTP request pipeline.
            app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

            app.Run();
        }
    }
}