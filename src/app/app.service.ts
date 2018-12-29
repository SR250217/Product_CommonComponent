import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs/Rx';

// Import RxJs required methods
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import { error } from 'util';

@Injectable()
export class AppService {
    //Server Route
    private greetUrl = 'api/values';

    // Resolve HTTP using the constructor
    constructor(private _http: Http) { }

    sayHello(): Observable<any> {
        return this._http.get(this.greetUrl).map((response: Response) => {
            return response.text();
        });      
    }
    poseReq(): Observable<any>{
        const myModel = {Value: 'Brad'};
        return this._http.post(this.greetUrl,myModel).map((res:Response)=>{
            console.log(res.text());
return res;
        });
       
    
    }
}