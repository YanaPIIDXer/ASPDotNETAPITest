import { Component } from '@angular/core';
import conn from '../../Modules/apiconnection/apiconnection.module';

@Component({
  selector: 'app-health-check',
  templateUrl: './health-check.component.html',
  styleUrls: ['./health-check.component.css']
})
export class HealthCheckComponent {

  constructor() { }

  async healthCheck(): Promise<void> {
    const res = await conn.get("/");
    var msg: string = "";
    if (res.status == 200) {
      msg = res.json.message;
    } else {
      msg = "Fuck.";
    }
    alert(msg);
    console.log(res);
  }
  
  async healthCheckWithAuth(): Promise<void> {
    const res = await conn.get("/auth/");
    var msg: string = "";
    if (res.status == 200) {
      msg = res.json.message;
    } else {
      msg = "Fuck.";
    }
    alert(msg);
    console.log(res); 
  }
}
