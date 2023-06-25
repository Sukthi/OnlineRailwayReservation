import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TraindetailsService {
  private baseApiUrl = 'https://localhost:7030';

  constructor(private httpClient: HttpClient ) { }

  getTrainDetails():Observable<any>{
    return this.httpClient.get<any>(this.baseApiUrl + '/traindetails')
  }
}
