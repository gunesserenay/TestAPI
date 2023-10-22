using System;
using System.Linq.Expressions;
using Test_API.Models;

namespace Test_API.Repository.IRepository
{
	public interface IVillaRepository
	{
		Task<List<Villa>> GetAll(Expression<Func<Villa,bool>> filter=null);
		Task<Villa> Get(Expression<Func<Villa,bool>> filter=null, bool tracked=true);
		Task Create(Villa entity);
        Task Remove(Villa entity);
		Task Save();
	}
}

