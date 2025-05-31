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

        [HttpGet("image/{fileName}")]
        public IActionResult GetImage(string fileName)
        {
            var uploadsDir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");
            var filePath = Path.Combine(uploadsDir, fileName);

            if (!System.IO.File.Exists(filePath))
                return NotFound("Image not found.");

            var extension = Path.GetExtension(filePath).Trim('.').ToLowerInvariant();
            var mimeType = extension switch
            {
                "png" => "image/png",
                "jpg" or "jpeg" => "image/jpeg",
                "gif" => "image/gif",
                _ => "application/octet-stream"
            };

            return PhysicalFile(filePath, mimeType);
        }

        [HttpGet("paged")]
        public async Task<ActionResult<PagedResult<PlantDto>>> GetPaged([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            if (page <= 0 || pageSize <= 0)
                return BadRequest("Invalid page or pageSize");

            var totalItems = await _context.Plants.CountAsync();
            var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            var items = await _context.Plants
                .OrderBy(p => p.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return Ok(new PagedResult<PlantDto>
            {
                Items = items.Select(ToDto),
                CurrentPage = page,
                TotalPages = totalPages
            });
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
