import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'The Dating App';
  users: any;

  // Injection http service putem konstruktora
  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getUsers();
  }

 getUsers() {
   // Mora da se podudara sa nasim endpoint-om gde dobijamo korisnike
    // Observables nece uraditi nista ukoliko se na pretplatimo na njih subscribe
    // Response - sta radimo sa podacima koje dobijemo

  this.http.get('https://localhost:5001/api/users').subscribe(response => {
    this.users = response;

  }, error => {
    console.log(error);
  })
 }
}
