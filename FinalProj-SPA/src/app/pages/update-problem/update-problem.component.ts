import { Component, OnInit } from '@angular/core';
import {ProblemModel} from '../../shared/models/problem.model';
import {HttpRequestService} from '../../shared/http-request.service';

@Component({
  selector: 'app-update-problem',
  templateUrl: './update-problem.component.html',
  styleUrls: ['./update-problem.component.css']
})
export class UpdateProblemComponent implements OnInit {

  p: ProblemModel = new ProblemModel();

  Name: string;
  Description: string;
  StartDate: string;
  EndDate: string;
  UserId: number;
  StatusId: number;

  constructor(private httpRequestService: HttpRequestService) { }

  ngOnInit() {
  }

  updateProblem() {
  }

  receiveMessage($event) {
    alert($event);
  }


}
