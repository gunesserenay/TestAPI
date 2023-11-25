﻿using System;
using System.Linq.Expressions;
using Test_API.Models;

namespace Test_API.Repository.IRepository
{
	public interface IRepository<T> where T: class
	{
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, string? includeProperties = null, int pageSize=3, int pageNumber=1);
        Task<T> GetAsync(Expression<Func<T, bool>> filter = null, bool tracked = true, string? includeProperties = null);
        Task CreateAsync(T entity);
        Task RemoveAsync(T entity);
        Task SaveAsync();

    }
}

