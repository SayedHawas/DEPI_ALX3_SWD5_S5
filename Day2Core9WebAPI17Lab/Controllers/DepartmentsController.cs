using Day2Core9WebAPI17Lab.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day2Core9WebAPI17Lab.Controllers
{
    //https://localhost:7293/api/Departments
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        //DJ Database 
        private readonly WEBAPIDBContext _db;

        public DepartmentsController(WEBAPIDBContext db)
        {
            this._db = db;
        }

        //Get 
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_db.Departments.ToList()); // _db.Departments.ToList();
        }
        //Get By ID 
        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var d = _db.Departments.Find(id);
            if (d == null) return NotFound();
            else
                return Ok(d);
        }
        //Create
        [HttpPost]
        public IActionResult Create([FromForm] Department newDepartment)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            else
            {
                _db.Departments.Add(newDepartment);
                _db.SaveChanges();
                return Created();
            }
        }
        //Edit
        [HttpPut]
        public IActionResult Edit(Department updateDepartment, int id)
        {
            if (id != updateDepartment.DepartmentId)
                return BadRequest("ID Not Match ...");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            else
            {
                var updateDep = _db.Departments.Find(id);
                if (updateDep == null)
                    return BadRequest(ModelState);
                else
                {
                    updateDep.Name = updateDepartment.Name;
                    updateDep.ManagerName = updateDepartment.ManagerName;
                    updateDep.Location = updateDepartment.Location;
                    updateDep.Decsription = updateDepartment.Decsription;
                    _db.SaveChanges();
                    return NoContent();
                }
            }
        }
        //Delete
        [HttpDelete]
        public IActionResult Delete(int id)
        {

            var deleteDep = _db.Departments.Find(id);
            if (deleteDep == null)
                return BadRequest(ModelState);
            else
            {
                _db.Departments.Remove(deleteDep);
                _db.SaveChanges();
                return NoContent();
            }

        }
    }
}
