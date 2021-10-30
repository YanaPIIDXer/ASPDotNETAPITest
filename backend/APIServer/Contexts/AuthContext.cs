using APIServer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIServer.Contexts
{
	/// <summary>
	/// 認証関係コンテキスト
	/// </summary>
	public class AuthContext : IdentityDbContext<User>
	{
		public AuthContext(DbContextOptions options)
			: base(options)
		{
		}
	}
}
