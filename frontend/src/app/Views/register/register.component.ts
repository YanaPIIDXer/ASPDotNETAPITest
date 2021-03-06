import { Component } from '@angular/core';
import { Router } from '@angular/router';
import conn from '../../Modules/apiconnection/apiconnection.module';

@Component({
  selector: 'register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {

  userName: string
  password: string

  constructor(private router: Router) {
    this.userName = "";
    this.password = "";
  }

  async register(): Promise<void> {
    if (!confirm("登録しますか？")) { return; }
    var params = new URLSearchParams();
    params.append("userName", this.userName);
    params.append("password", this.password);
    const res = await conn.post("/auth/register", params);
    console.log(res);
    if (res.status != 200 || !res.json.result) {
      alert("登録に失敗しました");
      return;
    }
    alert("登録しました");
    this.router.navigate(["/login"]);
  }
}
