import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HealthCheckComponent } from './Views/health-check/health-check.component';
import { RegisterComponent } from './Views/register/register.component'
import { LogInComponent } from './Views/log-in/log-in.component';

const routes: Routes = [
  { path: "", component: HealthCheckComponent },
  { path: "register", component: RegisterComponent },
  { path: "login", component: LogInComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
