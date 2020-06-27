import { Component, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ServiceMessage } from './../models/message-models'
import { MessageService } from '../data-service/message-service';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  message: string = '';
  serviceMessage = <ServiceMessage>{};
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private messageService: MessageService) {
  }

  sendmessage(e) {
    console.info('Message sent');
    this.serviceMessage.name = 'Test User'
    this.serviceMessage.message = this.message;
    console.log(this.message);
    this.messageService.sendMessage(this.serviceMessage).subscribe(result => {
      this.serviceMessage = result;
    }, error => console.error(error));  
  }
  readmessage(e) {
    console.info('Read Message');
    this.messageService.getMessage().subscribe(result => {
      console.log(result);
    },
      error => console.error(error)
    );
  }
}
