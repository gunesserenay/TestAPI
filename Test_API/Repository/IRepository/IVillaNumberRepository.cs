using System;
using System.Linq.Expressions;
using Test_API.Models;

namespace Test_API.Repository.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {

        Task<VillaNumber> UpdateAsync(VillaNumber entity);

    }
}

