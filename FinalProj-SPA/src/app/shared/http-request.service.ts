import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {ProblemModel} from './models/problem.model';

@Injectable({
  providedIn: 'root'
})
export class HttpRequestService {

  constructor(private http: HttpClient) { }

  myURL = 'http://localhost:5000'

  users() {
    return this.http.get(this.myURL + '/api/users');
  }

  problems() {
    return this.http.get(this.myURL + '/api/problems');
  }

  addProblem(request: ProblemModel) {
    return this.http.post(this.myURL + '/api/problems/add', request).subscribe();
  }

  deleteProblem(request: number) {
    return this.http.delete(this.myURL + '/api/problems/delete/' + request).subscribe();
  }

  updateProblem(id: number, request: ProblemModel) {
    return this.http.put(this.myURL + '/api/problems/update/' + id, request);
  }
}
