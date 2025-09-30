using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIDay4DemoLab.Data;
using WebAPIDay4DemoLab.Models;

namespace WebAPIDay4DemoLab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Employees1Controller : ControllerBase
    {
        //https://localhost:7265/api/Employees1
        private readonly AppDbContext _db;

        public Employees1Controller(AppDbContext db)
        {
            this._db = db;
        }
        //status Code 200,201,404
        //[HttpGet]
        //public IEnumerable<Employee> Get()
        //{
        //    return _db.Employees.ToList();
        //}

        //[HttpGet]
        //public IActionResult Get()
        //{
        //    return Ok(_db.Employees.ToList());
        //}

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> Get()
        {
            return Ok(await _db.Employees.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetById(int id)
        {
            return Ok(await _db.Employees.FindAsync(id));
            //return await _db.Employees.SingleOrDefaultAsync(i => i.Id == id);
            //return await _db.Employees.FirstOrDefaultAsync(i=>i.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Employee newEmployee)
        {
            if (!ModelState.IsValid)
                return BadRequest(newEmployee);

            _db.Employees.Add(newEmployee);
            await _db.SaveChangesAsync();
            //return Created();
            return CreatedAtAction("GetById", new { newEmployee.Id }, newEmployee);
        }


    }
}
