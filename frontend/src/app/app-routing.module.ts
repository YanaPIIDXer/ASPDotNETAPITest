import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HealthCheckComponent } from './Views/health-check/health-check.component';

const routes: Routes = [
  {path: "", component: HealthCheckComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
