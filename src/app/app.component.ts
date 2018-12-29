import { Component,OnInit  } from '@angular/core';
import { Http, Response } from '@angular/http';

import { AppService } from './app.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent  implements OnInit {
  constructor(private _appService: AppService) { }
  ngOnInit(): void {
    this._appService.sayHello()
    .subscribe(
    result => {
      this.greetings = result;
    }
    );
    this._appService.poseReq().subscribe(result=>{
      console.log(result);
    })
  }
  greetings = '';

}
