using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIServer.Requests
{
	/// <summary>
	/// ログインリクエスト
	/// </summary>
	public class LogInRequest
	{
		public string UserName { get; set; }
		public string Password { get; set; }
	}
}
