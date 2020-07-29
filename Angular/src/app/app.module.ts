import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms'; 
import { ReactiveFormsModule } from '@angular/forms';

import { HttpClientModule } from "@angular/common/http";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { ToastrModule } from 'ngx-toastr';
import { NgxSpinnerModule } from "ngx-spinner";

import { MatDialogModule } from "@angular/material/dialog";

import { AppComponent } from './app.component';

import { EmployeesComponent } from './employees/employees.component';
import { EmployeeComponent } from './employees/employee/employee.component';
import { EmployeeListComponent } from './employees/employee-list/employee-list.component';
import { EmployeeService } from './shared/employee.service';
import { ContractTypeService } from './shared/contracttype.service';
import { DialogComponent } from './components/dialog/dialog.component';
import { AlertComponent } from './components/alert/alert.component';

import { EmployeeDirective } from './shared/employee.directive';
import { CustomMinDirective, CustomMaxDirective } from './shared/global.directive';

@NgModule({
	declarations: [
		AppComponent,
		EmployeesComponent,
		EmployeeComponent,
		EmployeeListComponent,
		EmployeeDirective,
		CustomMinDirective,
		CustomMaxDirective,
		DialogComponent,
		AlertComponent
	],
	imports: [
		BrowserModule,
		FormsModule,
		ReactiveFormsModule,
		HttpClientModule,
		BrowserAnimationsModule,
		MatDialogModule,
		NgxSpinnerModule,
		ToastrModule.forRoot()
	],
	providers: [EmployeeService, ContractTypeService, DialogComponent, AlertComponent],
	bootstrap: [AppComponent]
})
export class AppModule { }