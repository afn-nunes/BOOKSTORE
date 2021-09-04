import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
@Injectable()


export class BooksService {

  private url = 'https://localhost:44361/api/livraria';  // URL to web api

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  }
    
   constructor( private http: HttpClient){}


    getBook() {
      return this.http.get(this.url)

  
    }
}