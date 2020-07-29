import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
	selector: 'app-alert',
	templateUrl: './alert.component.html',
	styleUrls: ['./alert.component.css']
})
export class AlertComponent {

	title: string = "";
	message: string = "";
	buttonCancelText: string = "";

	constructor(@Inject(MAT_DIALOG_DATA) public pData: any) {
		if (pData) {

			this.title = pData.title || this.title;
			this.message = pData.message || this.message;

			if (pData.buttonText) {
				this.buttonCancelText = pData.buttonText.cancel || this.buttonCancelText;
			}
		}
	}
}