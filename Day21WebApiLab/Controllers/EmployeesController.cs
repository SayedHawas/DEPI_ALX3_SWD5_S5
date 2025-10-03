using Day21WebApiLab.Data;
using Day21WebApiLab.DTOs.EmployeeDtos;
using Day21WebApiLab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day21WebApiLab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmployeesController(AppDbContext context)
        {
            _context = context;
        }
        //https://localhost:7153/api/Employees?page1&Pagesize=3
        [HttpGet("Pagination")]
        public async Task<ActionResult<IEnumerable<GetEmployeeDto>>> GetDepartments([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            var employees = await _context.Employees.Include("Department").AsNoTracking().ToListAsync();
            List<GetEmployeeDto> result = new List<GetEmployeeDto>();
            foreach (var item in employees)
            {
                result.Add(new GetEmployeeDto
                {
                    Name = item.Name,
                    Job = item.Job,
                    Salary = item.Salary.ToString("C"),
                    DepartmentName = item.Department.Name,
                    ManagerName = item.Department.ManagerName
                });
            }
            //7/3
            //2.1 -->3
            // 1 3 , 2 3 , 3 1,
            //Modify for Pagination
            var totalCount = employees.Count();
            var totalPage = (int)Math.Ceiling((double)totalCount / pageSize);

            result = result.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            return Ok(result);
        }
        // GET: api/Employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetEmployeeDto>>> GetEmployees()
        {
            var emps = await _context.Employees.Include("Department").AsNoTracking().ToListAsync();
            List<GetEmployeeDto> result = new List<GetEmployeeDto>();
            foreach (var item in emps)
            {
                result.Add(new GetEmployeeDto()
                {
                    Name = item.Name,
                    Job = item.Job,
                    Salary = item.Salary.ToString("C"),
                    DepartmentName = item.Department.Name,
                    ManagerName = item.Department.ManagerName
                });
            }
            return Ok(result);
        }
        // GET: api/Employees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetEmployeeDto>> GetEmployee(int id)
        {
            var employee = await _context.Employees.Include("Department").AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);//.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            GetEmployeeDto result = new GetEmployeeDto()
            {
                Name = employee.Name,
                Job = employee.Job,
                Salary = employee.Salary.ToString("C"),
                DepartmentName = employee.Department.Name,
                ManagerName = employee.Department.ManagerName
            };

            return Ok(result);
        }
        // PUT: api/Employees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee([FromRoute] int id, [FromBody] PostPutEmployeeDto employee)
        {
            if (id != employee.Id) return BadRequest();

            if (!ModelState.IsValid) return BadRequest(employee);
            //_context.Entry(department).State = EntityState.Modified;
            var oldemployee = await _context.Employees.FindAsync(id);

            oldemployee.Name = employee.Name;
            oldemployee.Job = employee.Job;
            oldemployee.Salary = employee.Salary;
            oldemployee.departmentId = employee.departmentId;
            //_context.Entry(employee).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(id))
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
        // POST: api/Employees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Consumes("application/json")]
        //[Consumes("text/xml")]
        [Produces("application/json")]
        public async Task<ActionResult<PostPutEmployeeDto>> PostEmployee(PostPutEmployeeDto employee)
        {
            if (!ModelState.IsValid) return BadRequest(employee);
            _context.Employees.Add(new Employee()
            {
                Name = employee.Name,
                Job = employee.Job,
                Salary = employee.Salary,
                departmentId = employee.departmentId,
            });
            await _context.SaveChangesAsync();
            int newId = _context.Employees.Max(e => e.Id);
            return CreatedAtAction("GetEmployee", new { id = newId }, employee);
        }
        // DELETE: api/Employees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.Id == id);
        }
    }
}
