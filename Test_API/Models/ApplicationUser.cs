using System;
using Microsoft.AspNetCore.Identity;

namespace Test_API.Models
{
	public class ApplicationUser:IdentityUser
	{
		public string Name { get; set; }
	}
}

