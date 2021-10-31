import { Component } from '@angular/core';
import { Router } from '@angular/router';
import conn from '../../Modules/apiconnection/apiconnection.module';

@Component({
  selector: 'log-in',
  templateUrl: './log-in.component.html',
  styleUrls: ['./log-in.component.css']
})
export class LogInComponent {

  userName: string
  password: string

  constructor(private router: Router) {
    this.userName = "";
    this.password = "";
  }

  async login(): Promise<void> {
    var params = new URLSearchParams();
    params.append("userName", this.userName);
    params.append("password", this.password);
    const res = await conn.post("/auth/login", params);
    if (res.status != 200 || !res.json.result) {
      alert("ログインに失敗しました。");
      return;
    }
    alert("ログインしました。");
    this.router.navigate(["/"]);
  }
}
