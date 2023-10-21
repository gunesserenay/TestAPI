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
            CreateMap<VillaDTO, VillaCreateDTO>().ReverseMap();
            CreateMap<VillaDTO, VillaUpdateDTO>().ReverseMap();

        }
    }
}

