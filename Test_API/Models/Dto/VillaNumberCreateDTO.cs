﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Test_API.Models.Dto
{
	public class VillaNumberCreateDTO
	{
        [Required]
        public int VillaNo { get; set; }

        public string SpecialDetails { get; set; }
    }
}

