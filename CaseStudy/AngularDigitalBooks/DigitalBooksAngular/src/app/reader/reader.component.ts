import { Component, OnInit } from '@angular/core';
import { Book } from '../models/readermodel';
import { User } from '../models/usermodel';
import {ReaderService} from '../service/reader.service';
@Component({
  selector: 'app-reader',
  templateUrl: './reader.component.html',
  styleUrls: ['./reader.component.css']
})
export class ReaderComponent implements OnInit {
  title = 'Search Books';
  
  users:User[]=[];
  user:User={
    userId:'',
    userName:'',
    emailId:'',
    firstName:'',
    lastName:'',
    userpassword:'',
    roleId:'',
    active:true
  }
  books:Book[] = [];
  book : Book = {
    bookId: '',
    bookName :'',
    publisher:'',
    publishedDate:'',
    price:'',
    UserModel:this.user
  }
  constructor(private booksService : ReaderService
){
  }

  ngOnInit(): void {
  }

  getAllBooks() {
    this.booksService.getAllBooks()
    .subscribe(
      response => { this.books = response}
    );
  }

  onSubmit()
    {
      this.searchBook(this.book);
    }
  searchBook(book: Book)
  {
    this.booksService.searchBooks(book.bookName,book.UserModel.userName,book.publisher,book.publishedDate).subscribe(
      response => { this.books = response});
  }
}
