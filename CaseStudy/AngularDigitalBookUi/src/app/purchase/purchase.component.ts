import { Component, OnInit } from '@angular/core';
import { BooksService } from '../bookservice.component';
import { bookModel } from 'src/books.component';
import { UserModel } from '../users.component';
import { Category } from '../category';
import { Purchase } from '../purchase';
import { ActivatedRoute } from '@angular/router';



@Component({
  selector: 'app-purchase',
  templateUrl: './purchase.component.html',
  styleUrls: ['./purchase.component.css']
})
export class PurchaseComponent implements OnInit {
  



 selectedObject='';
  categories:Category[]=[];
  category:Category={
    categoryId:0,
    categoryName:''
  }



 users:UserModel[] = [];
  user : UserModel = {
    userId :0,
  userName :'',
  emailId :'',
  password :'',
  roleId :'',
  firstName :'',
  lastName :'',
  active : true
  }
  
  
  books:bookModel[] = [];
   book : bookModel = {
    bookId: 0,
  bookName :'',
  categoryId :'',
  price :'',
  publisher :'',
  userId:0,
  publishedDate : new Date(),
  content :'',
  active :true,
  userModel :this.user
  }
  
  purchasess:Purchase[]=[]
  purchases:Purchase={
    purchaseId:0,
    emailid:'',
    bookid:0,
    purchaseDate:new Date(),
    paymentMode:'',
    bookmodel:this.book



 }
  bookename:any;
  constructor(public bookServiceComponent : BooksService,private route:ActivatedRoute){
  }

  ngOnInit(): void {
   this. getAllBooks();
  this.bookename =this.route.snapshot.paramMap.get('id');
   console.log(this.bookename);
  }
getAllBooks() {
    this.bookServiceComponent.getAllBooks()
    .subscribe(
      response => { this.books = response}
    );
  }

  onSubmit()
    {
      this.PurchaseBook(this.purchases);
    }
    
    PurchaseBook(purchases: Purchase)
    {
      
    const  selectedOrder = this.books.find(books => books.bookName == this.book.bookName);
     

    //    console.log(selectedOrder); 
       this.book.bookId=selectedOrder?.bookId!; 
     this.purchases.bookid= this.bookename; 
     console.log(this.bookename);
      this.bookServiceComponent.PurchaseBook(purchases)
      .subscribe(
        response => { this.purchasess }
    );
    }

    
   
}