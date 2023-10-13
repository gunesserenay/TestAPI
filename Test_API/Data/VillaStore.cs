using System;
using Test_API.Models.Dto;

namespace Test_API.Data
{
	public static class VillaStore
	{
		public static List<VillaDTO> VillaList = new List<VillaDTO> {
                new VillaDTO { Id=1, Name="Pool view"},
                new VillaDTO { Id = 2, Name="Beach view" }
            };
	}
}

