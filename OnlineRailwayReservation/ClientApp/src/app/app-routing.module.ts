import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TrainDetailsComponent } from './train-details/train-details.component';
import { HttpClientModule } from '@angular/common/http';
import { RegisterComponent } from './register/register.component';
import { PaymentComponent } from './payment/payment.component';
import { PassengerDetailsComponent } from './passenger-details/passenger-details.component';
import { ContactUsComponent } from './contact-us/contact-us.component';
import { ReservationComponent } from './reservation/reservation.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { LoginComponent } from './login/login.component';


const routes: Routes = [
  
  {
    path:'Register',
    component:RegisterComponent
  },
  {
    path:'View-Ticktets',
    component:ReservationComponent
  },
  {
    path:'Contact-Us',
    component:ContactUsComponent

  },
  {
    path:'Search',
    component:TrainDetailsComponent

  },
  {
    path:'Home',
    component:DashboardComponent

  },
  {
    path:'Login',
    component:LoginComponent

  },
  {
    path:'Book-Now',
    component:PassengerDetailsComponent

  },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
