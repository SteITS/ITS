using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Autovelox.Data.Models;
using System.Drawing;

namespace AutoveloxProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MappeController : ControllerBase
    {
        private readonly MappaService _mappaService;

        public MappeController(MappaService mappaService)
        {
            _mappaService = mappaService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllAutovelox()
        {
            var maps = await _mappaService.GetAllMappeAsync();
            return Ok(maps);
        }

        [HttpGet("filtered")]
        public async Task<IActionResult> GetAutoveloxByFilter(string? comune, string? provincia, string? regione)
        {
            var maps = await _mappaService.GetMapsByFilter(comune, provincia, regione);
            return Ok(maps);
        }

        [HttpGet("byId")]
        public async Task<IActionResult> GetAutoveloxById(int id)
        {
            var maps = await _mappaService.GetMapsById(id);
            return Ok(maps);
        }



    }
}
