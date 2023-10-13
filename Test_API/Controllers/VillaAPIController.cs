﻿using System;
using Microsoft.AspNetCore.Mvc;
using Test_API.Models;

namespace Test_API.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Villa> GetVillas()
        {
            return new List<Villa> {
                new Villa { Id=1, Name="Pool view"},
                new Villa { Id = 2, Name="Beach view" }
            };
        }
    }
}

