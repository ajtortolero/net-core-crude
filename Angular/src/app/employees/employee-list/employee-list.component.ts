import { Component, OnInit } from '@angular/core';
import { EmployeeService } from 'src/app/shared/employee.service';
import { Employee } from 'src/app/shared/employee.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit {

  pageView: Array<Employee>;

  constructor(
    public pEmployeeService: EmployeeService,
    private pToastr: ToastrService
  ) {

  }

  ngOnInit() {
    this.pEmployeeService.getList();
  }
  populateForm(pEmployee: Employee) {
    this.pEmployeeService._EmployeeData = Object.assign({}, pEmployee);
  }
  onDelete(pID: number) {
    if (confirm('Are you sure to delete this record?')) {
      this.pEmployeeService.delete(pID).subscribe(Result => {
        this.pEmployeeService.getList();
        this.pToastr.warning('Deleted successfully', 'EMP. Register');
      });
    }
  }
}