import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { TrainDetailsComponent } from './train-details/train-details.component';
import { HttpClientModule } from '@angular/common/http';

import { RegisterComponent } from './register/register.component';
import { PaymentComponent } from './payment/payment.component';
import { PassengerDetailsComponent } from './passenger-details/passenger-details.component';
import { ContactUsComponent } from './contact-us/contact-us.component';
import { ReservationComponent } from './reservation/reservation.component';
import { NavbarComponent } from './navbar/navbar.component';
import { LoginComponent } from './login/login.component';


@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    TrainDetailsComponent,
   
    RegisterComponent,
    PaymentComponent,
    PassengerDetailsComponent,
    ContactUsComponent,
    ReservationComponent,
    NavbarComponent,
    LoginComponent,
 
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
