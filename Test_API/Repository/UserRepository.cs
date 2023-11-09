using System;
using Test_API.Data;
using Test_API.Models;
using Test_API.Models.Dto;
using Test_API.Repository.IRepository;

namespace Test_API.Repository
{
	public class UserRepository : IUserRepository
	{
		private readonly ApplicationDbContext _db;

		public UserRepository(ApplicationDbContext db)
		{
			_db = db;
		}

        public bool IsUniqueUser(string username)
        {
            throw new NotImplementedException();
        }

        public Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO)
        {
            throw new NotImplementedException();
        }

        public Task<LocalUser> Register(RegistrationRequestDTO registrationRequestDTO)
        {
            throw new NotImplementedException();
        }
    }
}

