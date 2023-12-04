using System;
using Test_API.Models;
using Test_API.Models.Dto;

namespace Test_API.Repository.IRepository
{
	public interface IUserRepository
    {
		bool IsUniqueUser(string username);
		Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
		Task<UserDTO> Register(RegistrationRequestDTO registrationRequestDTO);
	}
}

