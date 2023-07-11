using API.DataContext;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DirectorsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public DirectorsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //get all directors
        [HttpGet("GetAllDirectors")]
        public ActionResult<List<Director>> GetDirectors()
        {
            return _dbContext.Directors.ToList();
        }

        //create a director
        [HttpPost("CreateDirector")]
        public IActionResult CreateDirector(Director model)
        {
            Director director = new Director
            {
                Name = model.Name,
                Department = model.Department,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber
            };

            _dbContext.Directors.Add(director);

            _dbContext.SaveChanges();

            return Ok();
        }
    }
}