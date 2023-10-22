using System;
using System.Linq.Expressions;
using Test_API.Models;

namespace Test_API.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {

        Task<Villa> UpdateAsync(Villa entity);

    }
}

