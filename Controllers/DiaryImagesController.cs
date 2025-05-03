using FloraSync.Models.Dtos;
using FloraSync.Models.Entities;
using FloraSync.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;

namespace FloraSync.Controllers
{
    [ApiController, Route("api/diary-images")]
    public class DiaryImagesController : Controller
    {
        private readonly FloraSyncContext _context;
        private readonly IWebHostEnvironment _env;
        public DiaryImagesController(FloraSyncContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        [HttpPost("upload")]
        [Consumes("multipart/form-data")]
        public async Task<ActionResult<DiaryImage>> Upload([FromForm] DiaryImageUploadDto dto)
        {
            var file = dto.File;

            if (file == null || file.Length == 0)
                return BadRequest("No file provided.");

            var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
            var uploadsDir = Path.Combine(_env.WebRootPath ?? "wwwroot", "uploads");
            Directory.CreateDirectory(uploadsDir);

            var path = Path.Combine(uploadsDir, fileName);
            await using var stream = new FileStream(path, FileMode.Create);
            await file.CopyToAsync(stream);

            var diaryImage = new DiaryImage
            {
                FileName = fileName,
                ImageUrl = "/uploads/" + fileName
            };

            _context.DiaryImages.Add(diaryImage);
            await _context.SaveChangesAsync();

            return Ok(diaryImage);
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<DiaryImage>>> GetAll()
            => await _context.DiaryImages.OrderByDescending(x => x.Uploaded).ToListAsync();


        [HttpGet("serve/{fileName}")]
        public IActionResult Serve(string fileName)
        {
            var uploadsDir = Path.Combine(_env.WebRootPath ?? "wwwroot", "uploads");
            var filePath = Path.Combine(uploadsDir, fileName);

            if (!System.IO.File.Exists(filePath)) return NotFound();
            var mimeType = "image/" + Path.GetExtension(filePath).Trim('.');
            return PhysicalFile(filePath, mimeType);
        }
    }
}
