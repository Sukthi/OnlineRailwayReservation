import { Component } from '@angular/core';
import { TraindetailsService } from './traindetails.service';

@Component({
  selector: 'app-train-details',
  templateUrl: './train-details.component.html',
  styleUrls: ['./train-details.component.css']
})
export class TrainDetailsComponent {
  constructor(private traindetailsService : TraindetailsService)
  {

  }
  ngOnInit(): void{
    //Fetch Train details
    this.traindetailsService.getTrainDetails()
    .subscribe(
      (successResponse) => {
        console.log(successResponse);
      },
      (errorResponse) =>{
        console.log(errorResponse);
      }
    );
  }

}
