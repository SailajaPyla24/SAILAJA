import { Component, OnInit } from '@angular/core';
import { BooksService } from '../bookservice.component';
@Component({
  selector: 'app-reader',
  templateUrl: './reader.component.html',
  styleUrls: ['./reader.component.css']
})
export class ReaderComponent implements OnInit {
  book:any;



 constructor(public bookServiceComponent : BooksService){
  }



 ngOnInit(): void {
  
      this.bookServiceComponent.getAllBooks()
      .subscribe(
        response => { this.book = response;}
      );
    
  }



}