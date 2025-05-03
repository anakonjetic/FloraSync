using FloraSync.Models.Dtos;
using FloraSync.Models.Entities;
using FloraSync.Models.Enums;
using FloraSync.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FloraSync.Controllers
{
    [ApiController, Route("api/plants")]
    public class PlantsController : Controller
    {
        private readonly FloraSyncContext _context;
        public PlantsController(FloraSyncContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<PlantDto>> GetAll() => (await _context.Plants.ToListAsync()).Select(ToDto);

        [HttpGet("{id}")]
        public async Task<ActionResult<PlantDto>> Get(int id)
        {
            var plant = await _context.Plants.FindAsync(id);
            return plant == null ? NotFound() : Ok(ToDto(plant));
        }



        private static PlantDto ToDto(Plant p) => new()
        {
            Id = p.Id,
            Name = p.Name,
            Type = p.Type.ToDescription(),
            TypeValue = p.Type.ToConstant(),
            TypeIcon = p.Type.ToIcon(),
            Water = p.Water.ToDescription(),
            WaterValue = p.Water.ToConstant(),
            WaterIcon = p.Water.ToIcon(),
            Light = p.Light.ToDescription(),
            LightValue = p.Light.ToConstant(),
            LightIcon = p.Light.ToIcon(),
            Temperature = p.Temperature.ToDescription(),
            TemperatureValue = p.Temperature.ToConstant(),
            TemperatureIcon = p.Temperature.ToIcon(),
            ImageUrl = p.ImageUrl,
            FunFact = p.FunFact
        };
    }
}
