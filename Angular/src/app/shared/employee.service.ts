import { Injectable } from '@angular/core';
import { Employee } from './employee.model';
import { HttpClient, HttpErrorResponse } from "@angular/common/http";
import { Environment } from 'src/environments/environment';

@Injectable({
	providedIn: 'root'
})
export class EmployeeService {
	_Error: any
	_EmployeeData: Employee;
	_EmployeeList: Employee[];

	readonly _ApiUri = Environment.api.uri;

	constructor(
		private pHttpClient: HttpClient
	) {

	}
	getList() {
		this.pHttpClient.get(this._ApiUri + '/Employee/Employees/GetList').toPromise()
			.then(Result => this._EmployeeList = Result as Employee[])
			.catch((ResultError: HttpErrorResponse) => {
				this._Error = ResultError.error;
				if (ResultError.error instanceof Error) {
					console.error('An error occurred:', ResultError.error.message);
				} else {
					console.error(`Backend returned code ${ResultError.status}, body was: ${ResultError.error}`);
				}
				this._EmployeeList = null;
			});
	}
	post(pEmployeeData: Employee) {
		pEmployeeData.EmployeeID = 0;
		pEmployeeData.SalaryAmount = 0;

		return this.pHttpClient.post(this._ApiUri + '/Employee/Employees/', pEmployeeData);
	}
	put(pEmployeeData: Employee) {
		return this.pHttpClient.put(this._ApiUri + '/Employee/Employees/' + pEmployeeData.EmployeeID, pEmployeeData);
	}
	delete(pID: number) {
		return this.pHttpClient.delete(this._ApiUri + '/Employee/Employees/' + pID);
	}
}