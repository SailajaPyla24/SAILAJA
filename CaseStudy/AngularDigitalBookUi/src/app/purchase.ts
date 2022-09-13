import { bookModel } from "src/books.component";



export interface Purchase {
    purchaseId:number;
    emailid:string;
    bookid:number;
    purchaseDate:Date;
    paymentMode:string;
bookmodel:bookModel;
}