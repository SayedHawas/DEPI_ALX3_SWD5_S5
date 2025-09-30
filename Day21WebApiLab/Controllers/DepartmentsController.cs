using Day21WebApiLab.Data;
using Day21WebApiLab.DTOs.DepartmentDtos;
using Day21WebApiLab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day21WebApiLab.Controllers
{
    //https://localhost:7153/api/Departments
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DepartmentsController(AppDbContext context)
        {
            _context = context;
        }

        //https://localhost:7153/api/Departments?page=1&pagesize=10
        //Pagination
        [HttpGet("Pagination")]
        public async Task<ActionResult<IEnumerable<GetDepartmentDto>>> GetDepartments([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            var departments = await _context.Departments.ToListAsync();
            List<GetDepartmentDto> result = new List<GetDepartmentDto>();
            foreach (var item in departments)
            {
                result.Add(new GetDepartmentDto
                {
                    DepartmentId = item.DepartmentId,
                    Name = item.Name,
                    Description = item.Description,
                });
            }
            //Modify for Pagination
            var totalCount = departments.Count();
            var totalPage = (int)Math.Ceiling((double)totalCount / pageSize);

            result = result.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            return Ok(result);
        }
        //https://localhost:7153/api/Departments
        // GET: api/Departments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetDepartmentDto>>> GetDepartments()
        {
            var departments = await _context.Departments.ToListAsync();
            List<GetDepartmentDto> result = new List<GetDepartmentDto>();
            foreach (var item in departments)
            {
                result.Add(new GetDepartmentDto
                {
                    DepartmentId = item.DepartmentId,
                    Name = item.Name,
                    Description = item.Description,
                });
            }
            return Ok(result);
        }

        // GET: api/Departments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetDepartmentDto>> GetDepartment(int id)
        {
            if (id == null || id == 0) return BadRequest();
            var department = await _context.Departments.FindAsync(id);
            if (department == null)
            {
                return NotFound();
            }
            GetDepartmentDto result = new GetDepartmentDto()
            {
                DepartmentId = department.DepartmentId,
                Name = department.Name,
                Description = department.Description
            };
            return Ok(result);
        }

        // PUT: api/Departments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //https://localhost:7153/api/Departments/9
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartment([FromRoute] int id, [FromBody] PutDepartmentDto department)
        {
            /*
                Department Id 1
                Name : Ali 
                De:toto

                Department Id 1
                Name : Ahmed 
                De:Yaha
             */
            if (id != department.DepartmentId)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid) return BadRequest(department);
            //_context.Entry(department).State = EntityState.Modified;
            var oldDepartment = await _context.Departments.FindAsync(id);

            oldDepartment.Name = department.Name;
            oldDepartment.Description = department.Description;
            oldDepartment.ManagerName = department.ManagerName;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartmentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        // POST: api/Departments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PostDepartmentDto>> PostDepartment(PostDepartmentDto department)
        {
            if (!ModelState.IsValid) return BadRequest(department);

            _context.Departments.Add(new Department()
            {
                Name = department.Name,
                Description = department.Description,
                ManagerName = department.ManagerName
            });
            await _context.SaveChangesAsync();

            //return Created();
            //Location
            int newId = _context.Departments.Max(d => d.DepartmentId);
            //return CreatedAtAction("GetDepartment", new { id = department.DepartmentId }, department);
            return CreatedAtAction("GetDepartment", new { id = newId }, department);
        }

        // DELETE: api/Departments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            if (id == 0) return BadRequest();
            var department = await _context.Departments.FindAsync(id);
            if (department == null)
            {
                return NotFound();
            }
            _context.Departments.Remove(department);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        private bool DepartmentExists(int id)
        {
            return _context.Departments.Any(e => e.DepartmentId == id);
        }
    }
}
