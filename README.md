# AngularGrpcNGClient

This project is a basic project testing how to use GRPC web with angular and updating the protobuff file

## Required Tools

* [protoc.exe](https://developers.google.com/protocol-buffers/docs/downloads) -- Tool used to convert proto files to provided by google *This tool will need to be added to environment path*

## Required dev dependencies

* ts-protoc-gen -- Use to generate typings from protobuff files

## Commands used to generate

```bash
protoc \
    --plugin="protoc-gen-ts=./node_modules/.bin/protoc-gen-ts.cmd" \
    --js_out="import_style=commonjs,binary:./src/app/generated" \
    --ts_out="service=grpc-web:./src/app/generated" \
    ./greeter.proto
```

This will generate the following structure

* ./generated
    * greeter_pb_service.d.ts
    * greeter_pb_service.js
    * greeter_pb.d.ts
    * greeter_pb.js

## Using the generated references

### Imports

```ts
import { GreeterClient } from './generated/greeter_pb_service';
import { HelloReply, HelloRequest } from './generated/greeter_pb';
```

### Creating the client
```ts
this.ccc = new GreeterClient('https://localhost:5001', undefined);
```

### Sending the request
```ts
const ttt = new HelloRequest();

ttt.setName('Angular');

this.ccc.sayHello(ttt, (e, serverMessage) => {
    console.info('Server', serverMessage);
});

```

    
