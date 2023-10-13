using System;
using Microsoft.AspNetCore.Mvc;
using Test_API.Data;
using Test_API.Models;
using Test_API.Models.Dto;

namespace Test_API.Controllers
{
   // [Route("api/[controller]")]
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return VillaStore.VillaList; 
        }
    }
}

