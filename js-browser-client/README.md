### Prerequisites
1. Create a proto file https://github.com/grpc/grpc-web/tree/master/net/grpc/gateway/examples/helloworld#define-the-service
1. Ensure dependencies are installed https://github.com/grpc/grpc-web?tab=readme-ov-file#code-generator-plugins
1. Code generation https://github.com/grpc/grpc-web/tree/master/net/grpc/gateway/examples/helloworld#generate-protobuf-messages-and-client-service-stub
1. Write client.js, package.json, index.html https://github.com/grpc/grpc-web/tree/master/net/grpc/gateway/examples/helloworld#write-client-code
    1. I don't know if we should have `"main" : "server.js"`
1. webpack https://github.com/grpc/grpc-web/tree/master/net/grpc/gateway/examples/helloworld#compile-the-client-javascript-code


### Compilation and Packaging
1. Generate proto files
    1. protoc -I=. hello.proto --js_out=import_style=commonjs:. --grpc-web_out=import_style=commonjs,mode=grpcwebtext:.
1. npm i
1. npx webpack ./client.js


### Run
1. python -m http.server 8081 &


### Test
1. Open browser
1. Navigate to `http://localhost:8081`
1. Open developer console
1. Refresh if needed after server is running to see "Hello World"


### Notes
1. Might need to update port based on the random assignment in the server
