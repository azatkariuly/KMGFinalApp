import { AppComponent } from './app.component';
import { NavComponent } from './shared/nav/nav.component';
import { UsersComponent } from './pages/users/users.component';
import { NgModule } from '@angular/core';
import {RouterModule} from '@angular/router';
import { AuthorizationComponent } from './pages/authorization/authorization.component';
import { AddProblemComponent } from './pages/add-problem/add-problem.component';
import { ProblemsComponent } from './pages/problems/problems.component';

import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http';
import {InputTextModule} from 'primeng/inputtext';
import {appRoutes} from './routes';
import {InputTextareaModule} from 'primeng/inputtextarea';
import {ButtonModule} from 'primeng/button';
import {FormsModule} from '@angular/forms';
import { UpdateProblemComponent } from './pages/update-problem/update-problem.component';


@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    UsersComponent,
    AuthorizationComponent,
    AddProblemComponent,
    ProblemsComponent,
    UpdateProblemComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    InputTextModule,
    RouterModule.forRoot(appRoutes),
    InputTextareaModule,
    ButtonModule,
    FormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
