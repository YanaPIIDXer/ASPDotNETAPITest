﻿using APIServer.Models;
using APIServer.Requests;
using APIServer.Responses;
using Microsoft.AspNetCore.Authorization;
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
        private UserManager<User> userManager = null;
        private SignInManager<User> signInManager = null;

        public AuthController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [Route("register")]
        [HttpPost]
        public async Task<IActionResult> Register([FromForm] RegisterRequest request)
        {
            User user = new User();
            user.UserName = request.UserName;
            var registerResult = await userManager.CreateAsync(user, request.Password);
            SimpleResultResponse response = new SimpleResultResponse(registerResult == IdentityResult.Success);
            return new JsonResult(response);
        }

        [Authorize]
        public IActionResult Index()
        {
            HealthCheckResponse response = new HealthCheckResponse();
            response.Message = "Auth Health Check OK";
            return new JsonResult(response);
        }
    }
}
