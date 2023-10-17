using System;
using Microsoft.EntityFrameworkCore;
using Test_API.Models;

namespace Test_API.Data
{
	public class ApplicationDbContext:DbContext
	{
		public DbSet<Villa> Villas { get; set; }
	}
}

