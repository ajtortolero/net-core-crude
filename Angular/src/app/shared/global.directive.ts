import { Directive, Input } from '@angular/core';
import { FormControl, NG_VALIDATORS, ValidationErrors, Validator, ValidatorFn } from '@angular/forms';

@Directive({
	//selector: '[customValueMin][formControlName],[customValueMin][formControl],[customValueMin][ngModel]',
	selector: '[customValueMin]',
	providers: [{ provide: NG_VALIDATORS, useExisting: CustomMinDirective, multi: true }]
})
export class CustomMinDirective implements Validator {
	@Input()
	customValueMin: number;

	validate(pFormControl: FormControl): { [key: string]: any } {
		return (pFormControl.value < this.customValueMin) ? { "customValueMin": true } : null;
	}
}

@Directive({
	//selector: '[customValueMax][formControlName],[customValueMax][formControl],[customValueMax][ngModel]',
	selector: '[customValueMax]',
	providers: [{ provide: NG_VALIDATORS, useExisting: CustomMaxDirective, multi: true }]
})
export class CustomMaxDirective implements Validator {

	@Input()
	customValueMax: number;

	validate(pFormControl: FormControl): { [key: string]: any } {
		return (pFormControl.value > this.customValueMax) ? { "customValueMax": true } : null;
	}
}