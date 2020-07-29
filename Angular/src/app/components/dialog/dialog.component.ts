import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';

@Component({
	selector: 'app-dialog',
	templateUrl: './dialog.component.html',
	styleUrls: ['./dialog.component.css']
})

export class DialogComponent {

	title: string = "";
	message: string = "";

	/** */
	constructor(
		public pMatDialog: MatDialog
	) {

	}
	/** */
	openDialog(pTitle: string, pMessage: string) {
		this.title = pTitle;
		this.message = pMessage;

		this.pMatDialog.open(DialogComponent, {
			data: {
				title: this.title,
				message: this.message
			}
		});
	}
}