using AutoveloxProject.WebAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoveloxProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LuoghiController : ControllerBase
    {
        private readonly LuoghiService _luoghiService;

        public LuoghiController(LuoghiService luoghiService)
        {
            _luoghiService = luoghiService;
        }

        [HttpGet("allRegioni")]
        public async Task<IActionResult> GetAllRegioni()
        {
            var regioni = await _luoghiService.GetAllRegioniAsync();
            return Ok(regioni);
        }

        [HttpGet("allProvince")]
        public async Task<IActionResult> GetAllProvince()
        {
            var province = await _luoghiService.GetAllProvinceAsync();
            return Ok(province);
        }

        [HttpGet("allComuni")]
        public async Task<IActionResult> GetAllComuni()
        {
            var comuni = await _luoghiService.GetAllComuniAsync();
            return Ok(comuni);
        }

        [HttpGet("provinceByRegione")]
        public async Task<IActionResult> GetProvinceByRegione(string regione)
        {
            var province = await _luoghiService.GetProvinceByRegione(regione);
            return Ok(province);
        }

        [HttpGet("comuniByProvincia")]
        public async Task<IActionResult> GetComuniByProvincia(string provincia)
        {
            var comuni = await _luoghiService.GetComuniByProvincia(provincia);
            return Ok(comuni);
        }

        [HttpGet("DTOByRegione")]
        public async Task<IActionResult> DTOByRegione(string regione)
        {
            var DTO = await _luoghiService.GetDTOByRegione(regione);
            return Ok(DTO);
        }
    }
}
