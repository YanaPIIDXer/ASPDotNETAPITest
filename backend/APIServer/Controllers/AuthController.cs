using APIServer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIServer.Controllers
{
	/// <summary>
	/// 認証関係コントローラ
	/// </summary>
	[Route("auth")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private UserManager<User> usermanager = null;
		private SignInManager<User> signInManager = null;

		public AuthController(UserManager<User> userManager, SignInManager<User> signInManager)
		{
			this.usermanager = userManager;
			this.signInManager = signInManager;
		}
	}
}
