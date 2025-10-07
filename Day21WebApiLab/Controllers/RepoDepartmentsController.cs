using Day21WebApiLab.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Day21WebApiLab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepoDepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _service;

        public RepoDepartmentsController(IDepartmentService service)
        {
            _service = service;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetDepartmentDto>>> GetDepartments()
        {
            var departments = _service.GetDepartments();
            List<GetDepartmentDto> result = new List<GetDepartmentDto>();
            foreach (var item in departments)
            {
                result.Add(new GetDepartmentDto()
                {
                    DepartmentId = item.DepartmentId,
                    Name = item.Name,
                    Description = item.Description
                });
            }
            return Ok(result);
        }


        //// GET: api/RepoDepartments
        ////[HttpGet]
        ////public async Task<ActionResult<IEnumerable<Department>>> GetDepartments()
        ////{
        ////    return Ok(_repo.GetAll());
        ////}

        //// GET: api/RepoDepartments/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Department>> GetDepartment(int id)
        //{
        //    var department = _repo.GetByID(id);

        //    if (department == null)
        //    {
        //        return NotFound();
        //    }

        //    return department;
        //}

        //// PUT: api/RepoDepartments/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutDepartment(int id, Department department)
        //{
        //    if (id != department.DepartmentId)
        //    {
        //        return BadRequest();
        //    }
        //    _repo.Update(department);
        //    _repo.Save();
        //    return NoContent();
        //}

        //// POST: api/RepoDepartments
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Department>> PostDepartment(Department department)
        //{
        //    _repo.Add(department);
        //    //_repo.Add(department);
        //    //_repo.Add(department);
        //    _repo.Save();
        //    return CreatedAtAction("GetDepartment", new { id = department.DepartmentId }, department);
        //}

        //// DELETE: api/RepoDepartments/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteDepartment(int id)
        //{
        //    var department = _repo.GetByID(id);
        //    if (department == null)
        //    {
        //        return NotFound();
        //    }

        //    _repo.Delete(id);
        //    _repo.Save();
        //    return NoContent();
        //}

    }
}
