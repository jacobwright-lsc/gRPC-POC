const {HelloRequest, HelloReply} = require('./hello_pb.js');
const {HelloerClient} = require('./hello_grpc_web_pb.js');

var client = new HelloerClient('https://localhost:7001');

var request = new HelloRequest();
request.setName('World');

client.sayHello(request, {}, (err, response) => {
  console.log(response.getMessage());
});