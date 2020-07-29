import { Component, OnInit } from '@angular/core';
import { EmployeeService } from 'src/app/shared/employee.service';
import { ContractTypeService } from 'src/app/shared/contracttype.service';

import { NgForm } from '@angular/forms';

import { ToastrService } from 'ngx-toastr';
import { NgxSpinnerService } from "ngx-spinner";
import { AlertComponent } from 'src/app/components/alert/alert.component';
import { MatDialog } from '@angular/material/dialog';

@Component({
	selector: 'app-employee',
	templateUrl: './employee.component.html',
	styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

	/** Switch To form submitted */
	formSubmitted = false;

	/** Min value to Salary Base */
	salaryBaseMinValue = 15;

	/** Min value to Salary Base */
	salaryBaseMaxValue = 50;

	/** Class form constructor */
	constructor(
		public pEmployeeService: EmployeeService,
		public pContractTypeService: ContractTypeService,
		private pDialog: MatDialog,
		private pToastr: ToastrService,
		private pSpinner: NgxSpinnerService
	) {

	}

	/** Init form */
	ngOnInit() {
		this.resetForm();
		this.pContractTypeService.refreshList();
	}

	/** On reset form */
	resetForm(pForm?: NgForm) {
		if (pForm != null)
			pForm.resetForm();

		this.formSubmitted = false;
		this.pEmployeeService._EmployeeData = {
			EmployeeID: null,
			Code: '',
			Name: '',
			LastName: '',
			Mobile: 0,
			Email: '',
			ContractTypeID: 0,
			SalaryBase: 0,
			SalaryAmount: 0
		};
	}

	/** On Submit form */
	onSubmit(pForm: NgForm) {
		this.formSubmitted = true;
		// this.srvToastr.success('Inserted successfully', 'EMP. Register');
		// this.pDialog.open(AlertComponent, {
		// 	data: {
		// 		title: "Paju",
		// 		message: "Paju"
		// 	}
		// });
		console.log(pForm);
		if (!pForm.invalid) {
			if (pForm.value.EmployeeID == null) {
				this.createdEmployee(pForm);
			}
			else {
				this.updateEmployee(pForm);
			}
		}
	}

	/** Method to create a employee */
	createdEmployee(pForm: NgForm) {
		try {
			this.pSpinner.show();
			this.pEmployeeService.post(pForm.value).subscribe(res => {
				this.pSpinner.hide();
				this.pToastr.success('Inserted successfully', 'Employee Created');
				this.resetForm(pForm);
				this.pEmployeeService.getList();
			});
		} catch (error) {
			console.log(error);
			this.pSpinner.hide();
		}
	}

	/** Method to update a employee */
	updateEmployee(pForm: NgForm) {
		try {
			this.pSpinner.show();
			this.pEmployeeService.put(pForm.value).subscribe(res => {
				this.pSpinner.hide();
				this.pToastr.success('Updated successfully', 'Employee Updated');
				this.resetForm(pForm);
				this.pEmployeeService.getList();
			});
		} catch (error) {
			console.log(error);
			this.pSpinner.hide();
		}
	}
}