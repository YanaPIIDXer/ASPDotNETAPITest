using APIServer.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIServer.Controllers
{
	/// <summary>
	/// ヘルスチェックコントローラ
	/// </summary>
	[Route("/")]
	[ApiController]
	public class HealthCheckController : ControllerBase
	{
		public IActionResult Index()
		{
			return new JsonResult(new HealthCheckResponse());
		}
	}
}
