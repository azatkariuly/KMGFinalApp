import { Component, OnInit, Output, EventEmitter} from '@angular/core';
import {HttpRequestService} from '../../shared/http-request.service';

@Component({
  selector: 'app-problems',
  templateUrl: './problems.component.html',
  styleUrls: ['./problems.component.css']
})
export class ProblemsComponent implements OnInit {
  problems: any;

  @Output() messageEvent = new EventEmitter<number>();

  constructor(private httpRequestService: HttpRequestService) { }

  ngOnInit() {
    this.httpRequestService.problems().subscribe(response => this.problems = response);
  }

  delete(id: number) {
    this.httpRequestService.deleteProblem(id);
  }

  sendId(id: number) {
    this.messageEvent.emit(id);
  }
}
