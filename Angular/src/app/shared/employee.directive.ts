import { Directive } from '@angular/core';
import { AbstractControl, FormControl, FormGroup, NG_VALIDATORS, ValidationErrors, Validator, ValidatorFn } from '@angular/forms';

export const EmployeeValidator: ValidatorFn = (pControl: FormGroup): ValidationErrors | null => {
	const _Code = pControl.get('Code');
	const _Name = pControl.get('Name');
	const _LastName = pControl.get('LastName');
	const _Mobile = pControl.get('Mobile');
	const _Email = pControl.get('Email');
	const _ContractTypeID = pControl.get('ContractTypeID');
	const _SalaryBase = pControl.get('SalaryBase');

  return _Code?.invalid || _Name?.invalid  || _LastName?.invalid  || _Mobile?.invalid  || _Email?.invalid  || _ContractTypeID?.invalid  || _SalaryBase?.invalid ? { 'employee-form-validator': true } : null;	
};

@Directive({
	selector: '[employee-form-validator]',
	providers: [{ provide: NG_VALIDATORS, useExisting: EmployeeDirective, multi: true }]
})
export class EmployeeDirective implements Validator {
	validate(pControl: AbstractControl): ValidationErrors {
		return EmployeeValidator(pControl)
	}
}