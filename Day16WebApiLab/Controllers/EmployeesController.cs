using Microsoft.AspNetCore.Mvc;

namespace Day16WebApiLab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        static List<string> Names = new List<string>() { "Ahmed", "Ali ", "Retaj", "Mariem", "Ramy" };
        //int index = Names.Count;
        //[HttpGet]
        //public string Get()
        //{
        //    return "Welcome in WebAPI";
        //}
        [HttpGet]
        public IEnumerable<string> GetName()
        {
            return Names;
        }
        [HttpGet("{id}")]
        public string GetByID(int id)
        {
            return Names[id];
        }
        [HttpPost]
        public string Create(string newName)
        {
            Names.Add(newName);
            return Ok().ToString();
        }
        [HttpPut]
        public string Put(int id, string updateName)
        {
            Names[id] = updateName;
            return NoContent().ToString();
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            Names.RemoveAt(id);
            return NoContent().ToString();
        }
        //Get 
        //GetID 
        //Post 
        //Put
        //Delete


    }
}
