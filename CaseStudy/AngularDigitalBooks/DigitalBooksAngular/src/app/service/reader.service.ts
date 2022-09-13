import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Book } from '../models/readermodel';

@Injectable({
  providedIn: 'root'
})
export class ReaderService {

  baseUrl = 'https://localhost:44349/api/Books';

  constructor(private https: HttpClient) {}
  //Get All Categories
  GetAllCategory():Observable<any[]>{
    return this.https.get<any>(this.baseUrl+"CategoryMasters/CategoryList");
}

//Get All Author List
GetAllAuthors():Observable<any[]>{
    return this.https.get<any>(this.baseUrl + "UserMasters/AuthorList");
}

//Get All Role List
GetAllRoles():Observable<any[]>{
    return this.https.get<any>(this.baseUrl + "Roles/RolesList");
}

// Save / Add new User
AddUser(val:any):Observable<any[]>{
    return this.https.post<any>(this.baseUrl + "UserMasters/AddUser",val);
}
  //Get all books
  getAllBooks():Observable<Book[]>{
      return this.https.get<Book[]>(this.baseUrl);
  }
   //search books by details
   searchBooks(Bname:string,Author:string,Publisher:string,publishedDate:string):Observable<Book[]>{
    return this.https.get<Book[]>(this.baseUrl +'/SearchBook?BName='+Bname+'&Author='+Author+'&Publisher='+Publisher+'&publishedDate='+publishedDate);
   
  }
  // Login WebAPI
  Login(val:any):Observable<any[]>{
    return this.https.post<any>(this.baseUrl + "Login",val)
}
}

