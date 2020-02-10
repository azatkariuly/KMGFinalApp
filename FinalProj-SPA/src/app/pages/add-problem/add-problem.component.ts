import { Component, OnInit } from '@angular/core';
import {ProblemModel} from '../../shared/models/problem.model';
import {HttpRequestService} from '../../shared/http-request.service';

@Component({
  selector: 'app-add-problem',
  templateUrl: './add-problem.component.html',
  styleUrls: ['./add-problem.component.css']
})
export class AddProblemComponent implements OnInit {

  problem: ProblemModel = new ProblemModel();

  Name: string;
  Description: string;
  StartDate: string;
  EndDate: string;
  UserId: number;
  StatusId: number;


  constructor(private httpRequestService: HttpRequestService) {
  }

  ngOnInit() {
  }

  AddProblem() {
    this.problem.name = this.Name;
    this.problem.description = this.Description;
    this.problem.startDate = this.StartDate;
    this.problem.endDate = this.EndDate;
    this.problem.userId = +this.UserId;
    this.problem.statusId = +this.StatusId;

    this.httpRequestService.addProblem(this.problem);

  }

}
