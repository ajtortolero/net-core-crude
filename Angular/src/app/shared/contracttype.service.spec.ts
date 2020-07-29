import { TestBed } from '@angular/core/testing';

import { ContractTypeService } from './contracttype.service';

describe('ContractTypeService', () => {
  let _Service: ContractTypeService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    _Service = TestBed.inject(ContractTypeService);
  });

  it('should be created', () => {
    expect(_Service).toBeTruthy();
  });
});