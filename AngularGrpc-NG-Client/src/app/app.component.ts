import { Component, OnInit } from '@angular/core';

import { GreeterClient } from './generated/greeter_pb_service';
import { HelloReply, HelloRequest } from './generated/greeter_pb';

import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent implements OnInit {
  title = 'AngularGrpc-NG-Client';
  ccc: GreeterClient;

  constructor(private client: HttpClient) {}

  async ngOnInit() {
    this.ccc = new GreeterClient('https://localhost:5001', undefined);
  }

  async click2() {
    const ttt = new HelloRequest();

    ttt.setName('Angular');

    const data = await this.client
      .post<HelloReply>('https://localhost:5001/api/Hello', ttt)
      .toPromise();

    console.info('Here is data', data);
  }

  click() {
    const ttt = new HelloRequest();

    ttt.setName('Angular');

    this.ccc.sayHello(ttt, (e, serverMessage) => {
      console.info('Server', serverMessage);
    });
  }
}
