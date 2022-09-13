import { Component, OnInit } from '@angular/core';
import {ReaderService} from '../service/reader.service';

@Component({
  selector: 'app-signin',
  templateUrl: './signin.component.html',
  styleUrls: ['./signin.component.css']
})
export class SigninComponent implements OnInit {

  token : any;
  usernameC:any;
  passwordC:any;
  constructor(private service: ReaderService) { }

  ngOnInit(): void {
  }

  login(){
    var val = {
      userName : this.usernameC,
      password : this.passwordC
    }
    this.service.Login(val).subscribe(
      response => {  this.token = response; console.log(this.token); }
    )
  }
}
