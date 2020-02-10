import { Component, OnInit } from '@angular/core';
import {HttpRequestService} from '../../shared/http-request.service';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css'],
  providers: [HttpRequestService]
})
export class UsersComponent implements OnInit {
  users: any;

  constructor(private httpRequestService: HttpRequestService) { }

  ngOnInit() {
    this.httpRequestService.users().subscribe(response => this.users = response);
  }

}
