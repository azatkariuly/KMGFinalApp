import {Routes} from '@angular/router';
import {AuthorizationComponent} from './pages/authorization/authorization.component';
import {UsersComponent} from './pages/users/users.component';
import {AddProblemComponent} from './pages/add-problem/add-problem.component';
import {ProblemsComponent} from './pages/problems/problems.component';
import {UpdateProblemComponent} from './pages/update-problem/update-problem.component';

export const appRoutes: Routes = [
  {path: 'users', component: UsersComponent },
  {path: '', component: AuthorizationComponent },
  {path: 'addProblem', component: AddProblemComponent},
  {path: 'problems', component: ProblemsComponent},
  {path: 'updateProblem', component: UpdateProblemComponent}
]

