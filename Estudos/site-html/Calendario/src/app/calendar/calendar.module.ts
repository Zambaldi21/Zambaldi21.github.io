import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AppointmentFormComponent } from './appointment-form/appointment-form.component';
import { AppointmentListComponent } from './appointment-list/appointment-list.component';



@NgModule({
  declarations: [
    AppointmentFormComponent,
    AppointmentListComponent
  ],
  imports: [
    CommonModule
  ]
})
export class CalendarModule { }
