using System;
using AutoMapper;
using Test_API.Models;
using Test_API.Models.Dto;

namespace Test_API
{
	public class MappingConfig:Profile

	{
        public MappingConfig()

        {
            CreateMap<Villa, VillaDTO>();
            CreateMap<VillaDTO, Villa>();

            CreateMap<Villa, VillaCreateDTO>().ReverseMap();
            CreateMap<Villa, VillaUpdateDTO>().ReverseMap();

        }
    }
}

