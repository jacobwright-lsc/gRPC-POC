### Follow
https://learn.microsoft.com/en-us/aspnet/core/tutorials/grpc/grpc-start?view=aspnetcore-9.0&tabs=visual-studio

To test use Postman.
1. Select gRPC protocol
1. Click the lock to use TLS
1. Add "grpc://localhost:{port}
    1. Where {port} is the randomly assigned port noted in the server console at launch
1. If necessary, import proto file to have methods to select
1. In the Message tab
    1. `{ "name": "Jacob" }`
1. Click Invoke


### Related 
https://learn.microsoft.com/en-us/aspnet/core/grpc/aspnetcore?view=aspnetcore-9.0&tabs=visual-studio
https://learn.microsoft.com/en-us/aspnet/core/grpc/?view=aspnetcore-9.0
https://learn.microsoft.com/en-us/aspnet/core/grpc/grpcweb?view=aspnetcore-9.0
https://github.com/grpc/grpc-web/tree/master/net/grpc/gateway/examples/helloworld#write-client-code