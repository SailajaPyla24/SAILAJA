import { User } from "./usermodel";

export interface Book {
    bookId: string;
    bookName :string;
    publisher: string;
    publishedDate:string;
    // publisher:string;
    price:string;
    UserModel:User;
    
}