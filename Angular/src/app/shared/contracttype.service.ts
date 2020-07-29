import { Injectable } from '@angular/core';
import { ContractType } from './contracttype.model';
import { HttpClient } from "@angular/common/http";
import { Environment } from 'src/environments/environment';

@Injectable({
	providedIn: 'root'
})
export class ContractTypeService {
	_ContractTypeData: ContractType;
	_ContractTypeList: ContractType[];

	readonly _ApiUri = Environment.api.uri;

	constructor(private pHttpClient: HttpClient) { }

	postContractType(pContractTypeData: ContractType) {
		return this.pHttpClient.post(this._ApiUri + '/ContractType/ContractTypes', pContractTypeData);
	}
	refreshList() {
		this.pHttpClient.get(this._ApiUri + '/ContractType/ContractTypes/GetList').toPromise().then(res => this._ContractTypeList = res as ContractType[]);
	}
	putContractType(pContractTypeData: ContractType) {
		return this.pHttpClient.put(this._ApiUri + '/ContractType/ContractTypes/' + pContractTypeData.contractTypeID, pContractTypeData);

	}
	deleteContractType(pID: number) {
		return this.pHttpClient.delete(this._ApiUri + '/ContractType/ContractTypes/' + pID);
	}
}