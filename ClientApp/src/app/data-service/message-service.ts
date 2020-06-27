import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ServiceMessage } from '../models/message-models';
import { Observable } from 'rxjs';

@Injectable()
export class MessageService {
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
  }
  sendMessage(serviceMessage: ServiceMessage): Observable<ServiceMessage> {
    return this.http.post<ServiceMessage>(this.baseUrl + 'message', serviceMessage, this.httpOptions);
  }
  getMessage(): Observable<ServiceMessage[]> {
    return this.http.get<ServiceMessage[]>(this.baseUrl + 'message');
  }
}
