import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BookingComponent } from './booking/booking.component';
import { CustomerComponent } from './customer/customer.component';
import { CourtsComponent } from './courts/courts.component';


const routes: Routes = [
  { path: '', redirectTo: '/customer', pathMatch: 'full' },
  { path: 'booking', component: BookingComponent },
  { path: 'customer', component: CustomerComponent },
  { path: 'courts', component: CourtsComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }